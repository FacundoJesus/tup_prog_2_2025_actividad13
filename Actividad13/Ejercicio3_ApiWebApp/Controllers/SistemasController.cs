using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ejercicio1_Models;

namespace Ejercicio3_ApiWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemasController : ControllerBase
    {

        private static Sistema sistema = new Sistema();

        protected Paquete BuscarPaquete(string zona)
        {
            Paquete p = null;
            for (int n = 0; n < sistema.ListaPaquetes.Count && p == null; n++)
            {
                if (sistema.ListaPaquetes[n].ZonaDestino == zona)
                    p = sistema.ListaPaquetes[n];
            }
            return p;
        }


        //POST /api/Sistemas/DescargarCamion
        //Descripción: Importa el fichero manifiesto de los paquetes descargados de un camión
        //y registra estos paquetes ingresados al depósito en el sistema.
        [HttpPost("DescargarCamion")]
        public ActionResult PostDescargarCamion(IFormFile manifiesto)
        {
            if (manifiesto == null || manifiesto.Length == 0)
                return BadRequest("No se ha proporcionado ningún archivo");

            try
            {
                //using Stream stream = new MemoryStream();
                //await file.CopyToAsync(stream);
                //stream.Position = 0;
                // MiEmpresa.Descargar(stream);

                sistema.Descargar(manifiesto.OpenReadStream());
                return Ok("Archivo procesado correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                $"Error al procesar el archivo: {ex.Message}");
            }
        }


        //GET /api/Sistemas/listaPaquetes
        //Descripción: Devuelve la lista de paquetes disponibles en el depósito
        [HttpGet("listaPaquetes")]
        public ActionResult<List<Paquete>> GetListaPaquetes()
        {
            if (sistema.ListaPaquetes == null || sistema.ListaPaquetes.Count == 0)
                return NotFound("No hay paquetes");

            return Ok(sistema.ListaPaquetes);
        }


        //GET /api/Sistemas/CamionesCargados
        //Descripción: Devuelve la lista de camiones disponibles para ser cargados.
        [HttpGet("CamionesCargados")]
        public ActionResult<string[]> GetCamionesCargados()
        {
            string[] camiones = sistema.CamionesCargados();

            if (camiones == null || camiones.Length == 0)
                return NotFound("No hay camiones cargados.");

            return Ok(camiones);
        }


        //GET /api/Sistemas/VerCargaCamion
        //Descripción: Devuelve el detalle de paquetes del manifiesto de carga de un camión.
        [HttpGet("VerCargaCamion")]
        public ActionResult<List<Paquete>> GetVerCarga(int posicion)
        {
            if (posicion <= 0)
                return BadRequest("posicion de camión es requerido");

            string[] paquetes = sistema.VerCargaCamion(posicion);

            if (paquetes == null || paquetes.Length == 0) return NotFound("No hay paquetes");

            return Ok(paquetes);
        }


        //GET /api/Sistemas/AgregarPaqueteDelCamion/{posicion}
        //Descripción: Agrega un paquete al manifiesto del camión quitandolo del depósito del sistema.
        [HttpGet("AgregarPaqueteDelCamion/{posicion}")]
        public ActionResult<double> GetAgregarPaqueteDelCamion(int posicion)
        {
            try
            {
                if (posicion <= 0)
                    return BadRequest("Número de camión es requerido");

                Paquete paquete = null;

                paquete = BuscarPaquete("3");
                if (paquete == null) paquete = BuscarPaquete("2");
                if (paquete == null) paquete = BuscarPaquete("1");

                double pesoCamion = sistema.CargarPaquete(posicion, paquete);

                return Ok(pesoCamion);
            }
            catch (Exception ex)
            {
               return StatusCode(StatusCodes.Status500InternalServerError,
               $"Error al procesar el paquete: {ex.Message}");
            }
        }

        //GET /api/Sistemas/QuitarPaqueteDelCamion
        //Descripción: Quita un paquete del manifiesto del camión y lo devuelve al depósito del sistema.
        [HttpGet("QuitarPaqueteDelCamion")]
        public ActionResult<double> QuitarPaquete(int posicion)
        {
            if (posicion <= 0)
                return BadRequest("posicion de camión es requerido");

            double pesoCamion = sistema.RetirarPaquete(posicion);

            return Ok(pesoCamion);
        }

        //GET /api/Sistemas/EnviarCamion
        //Descripción: Devuelve el fichero con el manifiesto con los paquetes que transporta el camión
        [HttpGet("EnviarCamion")]
        public async Task<IActionResult> GetEnviarCamion(int posicion)
        {
            try
            {
                if (posicion <= 0)
                    return BadRequest("posicion de camión es requerido");

                using MemoryStream stream = new MemoryStream();

                sistema.RetirarCamion(stream, posicion);

                byte[] fileContents = stream.ToArray();

                return File(fileContents, "text/csv", $"camion_{posicion}.csv");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                $"Error al procesar el archivo: {ex.Message}");
            }
        }
    }
}
