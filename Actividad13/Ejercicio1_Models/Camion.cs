using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Models
{
    public class Camion
    {
        private double pesoControl = 0;
        public int Patente { get; set; }
        public double PesoMax {  get; set; }

        Stack <Paquete> manifiesto = new Stack<Paquete>();

        public Camion(int patente,  double peso)
        {
            this.Patente = patente;
            this.PesoMax = peso;
        }

        public bool AgregarPaquete(Paquete unPaquete) {
            if (unPaquete == null) {
                throw new Exception("Paquete nulo");
            }

            if (unPaquete.Peso + pesoControl > PesoMax) return false;

            manifiesto.Push(unPaquete);
            pesoControl += unPaquete.Peso;
            return true;
        }

        public string[] VerCarga()
        {
            string[] carga = new string[manifiesto.Count];
            int i = 0;
            foreach(Paquete p in manifiesto)
            {
                carga[i++] = p.ToString();
            }
            return carga;
        }

        public double CargaEnKg()
        {
            return pesoControl;
        }

        public Paquete QuitarPaquete()
        {
            Paquete p = null;
            if(manifiesto.Count > 0)
            {
                p = manifiesto.Pop();
                pesoControl -= p.Peso;
            }
            return p;
        }
    }
}
