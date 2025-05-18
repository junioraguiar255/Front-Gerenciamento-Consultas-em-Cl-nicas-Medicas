using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace SysConsultas.Model
{
    public class EnderecoDTO
    {
        [Required]
        public string logradouro { get; set; }

        [Required]
        public string bairro { get; set; }

        [RegularExpression(@"\d{8}", ErrorMessage = "CEP deve conter 8 dígitos")]
        public string cep { get; set; }

        [Required]
        public string cidade { get; set; }

        [Required]
        public string uf { get; set; }

        public string complemento { get; set; }

        public string numero { get; set; }

        public override string ToString()
        {
            return $"Logradouro: {logradouro}, " +
                   $"Bairro: {bairro}, " +
                   $"CEP: {cep}, " +
                   $"Cidade: {cidade}, " +
                   $"UF: {uf}, " +
                   $"Complemento: {complemento ?? "N/A"}, " + // Usando operador de coalescência nula para lidar com valores nulos
                   $"Número: {numero ?? "N/A"}"; // Usando operador de coalescência nula para lidar com valores nulos
        }

    }
}
