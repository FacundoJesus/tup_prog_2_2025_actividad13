using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Models
{
    public class Paquete
    {
        public int NroRegistro { get; set; }
        public double Peso {  get; set; }
        public string ZonaDestino { get; set; }

        public Paquete(int id, double peso,string zona)
        {
            this.NroRegistro = id;
            this.Peso = peso;
            this.ZonaDestino = zona;
        }

        public override string ToString()
        {
            return $"{this.NroRegistro};{this.Peso};{this.ZonaDestino}";
        }
    }
}
