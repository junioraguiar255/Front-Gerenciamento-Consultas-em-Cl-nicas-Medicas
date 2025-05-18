namespace SysConsultas.Model
{
    using System.Collections.Generic;
    public class AgendaDTO
    {
        public long id { get; set; }
        public string medico { get; set; }
        public string paciente { get; set; }

        public DateTime data { get; set; }
        public string motivo_cancelamento { get; set; }
        public string observacoes { get; set; }

    }

    public class ListagemConsultaDTO
    {
        public List<AgendaDTO> content { get; set; }
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
