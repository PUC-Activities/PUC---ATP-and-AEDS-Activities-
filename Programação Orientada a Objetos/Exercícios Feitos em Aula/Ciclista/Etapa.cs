using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclista
{
    internal class Etapa
    {
        const int QuantidadeMaximaEtapas = 21;
        int _numeroEtapa; // variável global que é incrementada a cada vez que uma etapa é criada
        Data _dataEtapa;
        Hora _horaInicioEtapa;
        Duracao _duracaoEtapa;

        Etapa(int _numeroEtapa, Data _dataEtapa, Hora _horaInicioEtapa, Duracao _duracaoEtapa)
        {
            this._numeroEtapa = _numeroEtapa;
            this._dataEtapa = _dataEtapa;
            this._horaInicioEtapa = _horaInicioEtapa ;
            this._duracaoEtapa = _duracaoEtapa ;
        }
    }
}
