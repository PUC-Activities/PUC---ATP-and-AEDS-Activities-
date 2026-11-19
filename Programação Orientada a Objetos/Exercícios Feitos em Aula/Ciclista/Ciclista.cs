using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclista
{
    internal class Ciclista
    {
        const int QuantidadeMaximaEtapas = 21;
        string _nome;
        int _id; // variável global que é incrementada a cada vez que um ciclista é criado
        Duracao _tempoTotalCiclista;
        List<Etapa> _dadosEtapas;

        Ciclista(string nome, int id)
        {
            this._nome = nome;
            this._id = id;  
        }

        void CadastrarEtapa(Etapa etapaAtualCandidato)
        {
            if(_dadosEtapas.Count < QuantidadeMaximaEtapas)
            {
                _dadosEtapas.Add(etapaAtualCandidato);
            }
        }

        Duracao TempoTotalCiclista()
        {

        }

        Ciclista GanhadorPorTempo() // Verifica o maior tempo, armazena o vencedor e calcula a diferença de tempo
        {
        }

        Ciclista GanhadorEtapa(Ciclista ciclistaA, Ciclista ciclistaB, int etapa) // Verifica o tempos de ambos na etapa X, armazena e retorna o vencedor 
        {
            Ciclista vencedor;

            return vencedor;
        }
    }
}
