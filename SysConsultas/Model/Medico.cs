namespace SysConsultas.Model
{
    public class Medico
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Crm { get; set; }
        public string Especialidade { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nome}"; // Formato: "1 - Dr. João Silva"
        }

    }

}
