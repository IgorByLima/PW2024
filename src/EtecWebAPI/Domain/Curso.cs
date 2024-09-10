using EtecWebAPI.Enumerators;

namespace EtecWebAPI.Domain
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public EnumPeriodo Periodo { get; set; }
    }
}
