using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class AutoDeCombustion : Vehiculo
    {
        private double _nivelCombustible; // Encapsulación

        public int NumeroPuertas { get; set; }
        public string TipoCombustible { get; set; }

        public AutoDeCombustion(int anio, string elColor, string elModelo, double nivelCombustible)
            : base(anio, elColor, elModelo)
        {
            _nivelCombustible = nivelCombustible;
        }

        public double NivelCombustible
        {
            get { return _nivelCombustible; }
            set { _nivelCombustible = value; }
        }

        public override void Frenar()
        {
            base.Frenar();
            _nivelCombustible -= 1; // Gasta combustible al frenar
            Console.WriteLine($"El auto de combustión frena y gasta combustible. Nivel de combustible: {_nivelCombustible}");
        }

        public override void CargarCombustible(double cantidad)
        {
            _nivelCombustible += cantidad;
            Console.WriteLine($"Se cargaron {cantidad} litros de combustible. Nivel actual: {_nivelCombustible}");
        }
    }
}