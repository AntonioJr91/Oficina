namespace Oficina
{
    internal class OrdemDeServico : Servico, IConsultar
    {
        private static int proximoID = 1;
        public int Id { get; private set; }
        public Cliente Cliente { get; set; }
        public TipoDeVeiculo TipoVeiculo { get; set; }
        public Mecanico Mecanico { get; set; }
        public List<Servico> Servicos { get; set; } = new();
        public decimal ValorTotal => Servicos.Sum(s => s.Valor);

        public OrdemDeServico(Cliente cliente, TipoDeVeiculo tipoVeiculo, Mecanico mecanico, TipoDeServico tipoServico, string? descricao, decimal valor, decimal valorTotal)
        {
            Id = proximoID++;
            Cliente = cliente;
            TipoVeiculo = tipoVeiculo;
            Mecanico = mecanico;
            TipoServico = tipoServico;
            Descricao = descricao;
            Valor = valor;
        }

        public void Consultar()
        {
            Console.WriteLine($"[Cliente] - {Cliente.Nome}\t[Tipo do veículo] - {TipoVeiculo}\t[Mecânico] - {Mecanico.Nome}\t" +
                $"[Especialidade] - {Mecanico.Especialidade}\t[Descrição do serviço] - {Descricao}\t[Valor] - {Valor}\t" +
                $"[Valor Total] -  {ValorTotal}");
        }
    }
}