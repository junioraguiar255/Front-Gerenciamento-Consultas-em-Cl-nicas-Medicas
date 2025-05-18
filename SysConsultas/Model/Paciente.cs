using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysConsultas.Model
{
    public class Paciente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nome} - {Cpf} - {Email}"; // Formato: "1 - Dr. João Silva"
        }
    }


}
