using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001_Extra
{
    internal class Arvore_Avl
    {
        private No raiz;
        public Arvore_Avl() {
            raiz = null;
        }

        private void Inserir(int x)
        {
            raiz = Inserir(x, raiz);
        }
        public void Inserir(int x, No i) {
            if (i == null)
            {
                raiz = Inserir(x, raiz);
            }
            else if (x < i.Elemento)
            {
                i.Esq = Inserir(x, i.Esq);
            }
            else if (x > i.Elemento)
            {
                i.Dir = Inserir(x, i.Dir);
            }
            else {
                throw new Exception("Erro!");
            }
        } }
        public bool Pesquisar(int x) { 
        }
        public void CaminharCentral() { 
        }
        public void CaminharPre() {
        }
        public void CaminharPos() { 
        }
        public void Remover(int x) { 
        }
    }
}
