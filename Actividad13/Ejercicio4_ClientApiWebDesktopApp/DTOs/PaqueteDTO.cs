using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_ClientApiWebDesktopApp.DTOs
{
    public class PaqueteDTO
    {
        public int NroRegistro { get; set; }
        public double Peso { get; set; }
        public string ZonaDestino { get; set; }


        public override string ToString()
        {
            return $"{NroRegistro};{Peso:f2}";
        }
    }
}
