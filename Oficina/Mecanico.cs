namespace Oficina
{
    internal class Mecanico : Pessoa, ILista
    {
        public EspecialidadeMecanico Especialidade { get; set; }

        public Mecanico(string? nome, EspecialidadeMecanico especialidade, string? telefone = "Não cadastrado")
        {
            Nome = nome;
            Especialidade = especialidade;
            Telefone = telefone;
        }

        public void ExibirLista()
        {
            Console.WriteLine($"[Mecânico] - {Nome}\n" +
                $"[Especialidade] - {Especialidade}\n");
        }
    }
}
