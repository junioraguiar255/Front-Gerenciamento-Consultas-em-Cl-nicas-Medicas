using System.ComponentModel.DataAnnotations;

namespace SysConsultas.Model
{
    public class CadastroPacienteDTO
    {
        public int id { get; set; }

        [Required]
        public string nome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string email { get; set; }

        [Required]
        public string cpf { get; set; }

        [Required]
        public EnderecoDTO endereco { get; set; }
    }
}
