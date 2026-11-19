using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Circulo : IForma
    {
        private double raio;
        public double CalcularArea()
        {
            return Math.Pow((3.14 * raio), 2);
        }
    }
}
