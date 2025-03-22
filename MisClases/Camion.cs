using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {
        private double _capacidadCarga; // Encapsulación

        public int NumeroEjes { get; set; }
        public string TipoCarga { get; set; }

        public Camion(int anio, string elColor, string elModelo, double capacidadCarga)
            : base(anio, elColor, elModelo)
        {
            _capacidadCarga = capacidadCarga;
        }

        public double CapacidadCarga
        {
            get { return _capacidadCarga; }
            set { _capacidadCarga = value; }
        }

        public override void CargarCombustible(double cantidad)
        {
            Console.WriteLine($"El camión cargo {cantidad} litros de combustible");
        }
    }

}

