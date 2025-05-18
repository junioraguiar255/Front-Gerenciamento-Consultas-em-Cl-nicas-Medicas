using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysConsultas.Model
{
    public class Consulta
    {
        public long Id { get; set; }
        public string medico { get; set; }
        public string paciente { get; set; }
        public DateTime data { get; set; }
        public MotivoCancelamento motivoCancelamento { get; set; }

        public string observacoes { get; set; }

    }
}
