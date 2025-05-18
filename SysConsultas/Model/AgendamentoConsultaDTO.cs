using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysConsultas.Model
{
    public class AgendamentoConsultaDTO
    {

        public long idPaciente { get; set; }
        public long idMedico { get; set; }
        public string data { get; set; }
        public string motivo_cancelamento { get; set; }
        public string convenio { get; set; }

    }
}
