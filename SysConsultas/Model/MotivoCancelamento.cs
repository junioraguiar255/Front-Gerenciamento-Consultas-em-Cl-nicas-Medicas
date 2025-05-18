using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysConsultas.Model
{
    public enum MotivoCancelamento
    {
        PACIENTE_DESISTIU,
        MEDICO_CANCELOU,
        DESASTRES_NATURAIS,
        FERIADO,
        PROBLEMAS_ESTRUTURAIS,
        OUTROS,
        AGENDADO
    }

    public static class MotivoCancelamentoUtils
    {
        public static MotivoCancelamento CriarMotivoCancelamento(int id)
        {
            switch (id)
            {
                case 0:
                    return MotivoCancelamento.PACIENTE_DESISTIU;
                case 1:
                    return MotivoCancelamento.MEDICO_CANCELOU;
                case 2:
                    return MotivoCancelamento.DESASTRES_NATURAIS;
                case 3:
                    return MotivoCancelamento.FERIADO;
                case 4:
                    return MotivoCancelamento.PROBLEMAS_ESTRUTURAIS;
                case 5:
                    return MotivoCancelamento.OUTROS;
                case 6:
                    return MotivoCancelamento.AGENDADO;
                default:
                    throw new ArgumentException("ID de MOTIVO CANCELAMENTO inválido");
            }
        }
    }
}
