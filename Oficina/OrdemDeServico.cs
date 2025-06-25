namespace Oficina
{
    internal class OrdemDeServico : ILista
    {
        private static int proximoID = 1;
        public int Id { get; private set; }
        public Cliente Cliente { get; set; }
        public Mecanico Mecanico { get; set; }
        public List<Servico> Servicos { get; set; } = new();
        public decimal ValorTotal => Servicos.Sum(s => s.Valor);
        public OrdemDeServico(Cliente cliente, Mecanico mecanico, Servico servico)
        {
            Id = proximoID++;
            Cliente = cliente;
            Mecanico = mecanico;
            AdicionarServico(servico);
        }

        private void AdicionarServico(Servico servico)
        {
            Servicos.Add(servico);
        }
        public void ExibirLista()
        {
            Console.WriteLine($"[ID] - {Id}\n" +
                     $"[Cliente] - {Cliente.Nome}\n" +
                     $"[Telefone] - {Cliente.Telefone}\n" +
                     $"[Tipo do veículo] - {Cliente.Veiculo}\n" +
                     $"[Mecânico responsável] - {Mecanico.Nome}\n" +
                     $"[Especialidade do mecânico] - {Mecanico.Especialidade}\n");
            foreach (var servico in Servicos)
            {
                Console.Write($"[Serviço]\n" +
                    $"\t[Tipo do serviço] - {servico.TipoServico}\n" +
                    $"\t[Valor] - R$ {servico.Valor}\n");
            }
            Console.WriteLine($"[Valor Total] - R$ {ValorTotal}");
        }
    }
}