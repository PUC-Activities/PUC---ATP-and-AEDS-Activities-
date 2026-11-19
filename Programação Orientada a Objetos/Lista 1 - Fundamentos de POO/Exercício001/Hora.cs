using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Hora
    {
        const int _tempoDuracaoHora = 24;
        const int _tempoDuracaoMin = 60;
        const int _tempoDuracaoSeg = 60;

        private int _horas, _minutos, _segundos;

        Hora(int horas, int minutos, int segundos)
        {
            this._horas = horas;
            this._minutos = minutos;
            this._segundos = segundos;
        }

        public bool VerificaTempo()
        {
            bool ehValida = false;
            if ((_horas >= 0 && _horas < _tempoDuracaoHora) && (_minutos >= 0 && _minutos < _tempoDuracaoMin) && (_segundos >= 0 && _segundos <= _tempoDuracaoSeg))
            {
                ehValida = true;
            }
            return ehValida;
        }

        public string IncrementaHora(int horaExterna)
        {
            int horasNovas = _horas;

            if (horaExterna >= 0 && horaExterna < _tempoDuracaoHora)
            {
                if
            }

            return;
        }

        public int ObterTempoTotalSegundos(int horas, int minutos, int segundos)
        {
            int _segundosTotais = (segundos) + (minutos * _tempoDuracaoMin) + (horas * _tempoDuracaoSeg * _tempoDuracaoMin);

            return _segundosTotais;
        }

        public string ComparaHoras(int horas, int minutos, int segundos)
        {
            bool tempoOriginalEhMaior = false;

            int segundosOriginais = ObterTempoTotalSegundos(_horas, _minutos, _segundos);
            int segundosNaoOriginais = ObterTempoTotalSegundos(horas, minutos, segundos);

            if (segundosOriginais > segundosNaoOriginais)
            {
                tempoOriginalEhMaior = true;
            }

            return 
        }
        
        }

    }
}
