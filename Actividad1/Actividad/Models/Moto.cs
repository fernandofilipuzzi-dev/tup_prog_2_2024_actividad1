using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    public class Moto
    {
        public string Marca{ get; private set; }
        public int Modelo { get; private set; }
        public double ValorFabricacion { get; private set; }

        public Moto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }

        public double CalcularValor(int añoACalcular) 
        {
            return ValorFabricacion*(Math.Pow(1-0.1, añoACalcular - Modelo));
        }

        public string VerDescripcion()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}, Valor Fabriación:${ValorFabricacion,10:f2}";
        }
    }
}
