namespace SysConsultas.Model
{
    public enum Especialidade
    {
        ORTOPEDIA,
        CARDIOLOGIA,
        GINECOLOGIA,
        DERMATOLOGIA
    }

    public static class EspecialidadeUtils
    {
        public static Especialidade CriarEspecialidade(int id)
        {
            switch (id)
            {
                case 0:
                    return Especialidade.ORTOPEDIA;
                case 1:
                    return Especialidade.CARDIOLOGIA;
                case 2:
                    return Especialidade.GINECOLOGIA;
                case 3:
                    return Especialidade.DERMATOLOGIA;
                default:
                    throw new ArgumentException("ID de especialidade inválido");
            }
        }
    }
}
