namespace Oficina
{
    internal class Oficina
    {
        private readonly List<Cliente> clientes = new();
        private readonly List<Mecanico> mecanicos = new();
        private readonly List<OrdemDeServico> ordens = new();

        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void ListarClientes()
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"[Nome do cliente] - {cliente.Nome}\n" +
                    $"[Telefone] - {cliente.Telefone}");
            }
        }

        public void AdicionarMecanica(Mecanico mecanico)
        {
            mecanicos.Add(mecanico);
        }

        public void ListarMecanicos()
        {
            foreach (var mecanico in mecanicos)
            {
                Console.WriteLine($"[Nome do mecanico] - {mecanico.Nome}\n" +
                   $"[Especialidade] - {mecanico.Especialidade}");
            }
        }

        public void AdicionarOrdemDeServico(OrdemDeServico ordem)
        {
            ordens.Add(ordem);
        }

        public void ListarOrdensDeServicos()
        {
            foreach (var ordem in ordens)
            {
                Console.WriteLine($"[ID] - {ordem.Id}\t[Cliente] - {ordem.Cliente.Nome}\t[Tipo do veículo] - {ordem.TipoVeiculo}\t" +
                    $"[Mecânico responsável] - {ordem.Mecanico.Nome}\t[Especialidade do mecânico] - {ordem.Mecanico.Especialidade}\t" +
                    $"[Tipo do serviço] - {ordem.TipoServico}\t[Descrição] - {ordem.Descricao}\t[Valor] - {ordem.Valor}\t" +
                    $"[Valor Total] - {ordem.ValorTotal}");
            }
        }
    }
}