using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysConsultas.Model
{
    using System.Collections.Generic;
    public class PacienteDTO
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string email { get; set; }
            public string cpf { get; set; }
            public EnderecoDTO endereco { get; set; }
        }

        public class ListagemPacienteDTO
        {
            public List<PacienteDTO> content { get; set; }
            public PageableDTO pageable { get; set; }
            public bool last { get; set; }
            public int totalPages { get; set; }
            public int totalElements { get; set; }
            public int size { get; set; }
            public int number { get; set; }
            public SortDTO sort { get; set; }
            public bool first { get; set; }
            public int numberOfElements { get; set; }
            public bool empty { get; set; }
        }
    }

