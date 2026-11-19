using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Retangulo : IForma 
    {
        private double altura;
        private double largura;
        public double CalcularArea()
        {
            return altura * largura;
        }
    }
}
