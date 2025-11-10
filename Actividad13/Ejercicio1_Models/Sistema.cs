using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Models
{
    [Serializable]
    public class Sistema
    {
        public List<Paquete> ListaPaquetes = new List<Paquete>();
        private List<Camion> listaCamiones = new List<Camion>();

        public Sistema()
        {
            listaCamiones.Add(new Camion(100, 1000));
            listaCamiones.Add(new Camion(101, 1000));
            listaCamiones.Add(new Camion(102, 3000));
        }

        public string[] CamionesCargados()
        {
            string[] camionesCargados = new string[listaCamiones.Count];

            int n = 0;
            foreach (Camion c in listaCamiones)
            {
                camionesCargados[n++] = c.ToString();
            }
            return camionesCargados;
        }

        public double CargarPaquete(int posicion, Paquete unPaquete)
        {
            Camion camion = listaCamiones[posicion];
            if(camion != null) {
                if (camion.AgregarPaquete(unPaquete) == true)
                {
                    ListaPaquetes.Remove(unPaquete);
                }
            }
            return camion.CargaEnKg();
        }

        public void Descargar(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();

                string[] datos = linea.Split(';');

                int id = Convert.ToInt32(datos[0].Trim());
                double peso = Convert.ToDouble(datos[1].Trim());
                string zona = datos[2].Trim();

                Paquete paquete = new Paquete(id, peso, zona);

                ListaPaquetes.Add(paquete);
            }

            sr.Close();
        }

        public void RetirarCamion(FileStream fs, int posicion)
        {
            StreamWriter sw = new StreamWriter(fs);

            Camion camion = listaCamiones[posicion];
            
            foreach(string linea in camion.VerCarga())
            {
                sw.WriteLine(linea);
            }

            sw.Close();
        }

        public double RetirarPaquete(int posicion)
        {
            Camion camion = listaCamiones[posicion];
            Paquete p = camion.QuitarPaquete();
            if (p != null) ListaPaquetes.Add(p);

            return camion.CargaEnKg();
        }

        public string[] VerCargaCamion(int posicion)
        {
            Camion camion = listaCamiones[posicion];
            return camion.VerCarga();
        }
    }
}
