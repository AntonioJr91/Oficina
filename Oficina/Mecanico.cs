namespace Oficina
{
    internal class Mecanico : Pessoa, IConsultar
    {
        public EspecialidadeMecanico Especialidade { get; set; }

        public void Consultar()
        {
            Console.WriteLine($"[Mecânico] - {Nome}\t[Especialidade] - {Especialidade}\n");
        }
    }
}
