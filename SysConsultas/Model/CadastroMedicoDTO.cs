using System.ComponentModel.DataAnnotations;

namespace SysConsultas.Model
{
    public class CadastroMedicoDTO
    {
        public int id { get; set; }

        [Required]
        public string nome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string email { get; set; }

        [Required]
        public string crm { get; set; }

        [Required]
        public Especialidade especialidade { get; set; }

        [Required]
        public EnderecoDTO endereco { get; set; }

        [Required]
        public string login { get; set; }

        [Required]
        public string senha { get; set; }

    }
}
