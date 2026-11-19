using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_Feitos_em_Aula
{
    public class Pizza
    {
        private int _maxIngredientes;
        private double _precoBase;
        private int _quantidadeIngredientes;
        private double _valorPorAdicional;

        public Pizza()
        {

        }

        private double ValorAdicionais()
        {
            int quantidadeAdicionais = _quantidadeIngredientes - _maxIngredientes;
            double valorTotalAdicionais = 0;

            if (quantidadeAdicionais > 0)
            {
                valorTotalAdicionais = quantidadeAdicionais * _valorPorAdicional;
            }
            return valorTotalAdicionais;
        }

        private bool PodeAlterarIngredientes(int quantos)
        {
            return _quantidadeIngredientes >= quantos && _quantidadeIngredientes <= 8;
        }

        public double ValorFinal()
        {
            return _precoBase + ValorAdicionais();
        }

        public int AdicionarIngredientes(int quantos)
        {

            return _quantidadeIngredientes += quantos;            
        }

        public int RetirarIngredientes(int quantos)
        {
            if (_quantidadeIngredientes <= 0)
            {
                return -1;
            }
            else
            {
                return _quantidadeIngredientes = +quantos;
            }
        }

        public string NotaDeCompra()
        {
            return $"Pizza X, quantidade de ingredientes: {_quantidadeIngredientes}, valor: {ValorFinal()}";
        }
    }
}
