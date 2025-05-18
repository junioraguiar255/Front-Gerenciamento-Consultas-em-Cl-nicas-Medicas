using System.ComponentModel.DataAnnotations;

namespace SysConsultas.Model
{
    using System.Collections.Generic;

    public class MedicoDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string crm { get; set; }
        public string especialidade { get; set; }
        public EnderecoDTO endereco { get; set; }
    }

    public class PageableDTO
    {
        public SortDTO sort { get; set; }
        public int offset { get; set; }
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public bool paged { get; set; }
        public bool unpaged { get; set; }
    }

    public class SortDTO
    {
        public bool empty { get; set; }
        public bool sorted { get; set; }
        public bool unsorted { get; set; }
    }

    public class ListagemMedicoDTO
    {
        public List<MedicoDTO> content { get; set; }
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
