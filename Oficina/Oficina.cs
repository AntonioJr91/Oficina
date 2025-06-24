namespace Oficina
{
    internal static class SistemaOficina
    {
        private static readonly List<Cliente> clientes = new();
        private static readonly List<Mecanico> mecanicos = new();
        private static readonly List<OrdemDeServico> ordens = new();

        public static void AdicionarCliente()
        {
            Console.Write("Nome: ");
            string? nomeCliente = Console.ReadLine();

            Console.Write("Telefone: ");
            string? tel = Console.ReadLine();

            TipoDeVeiculo tipo;

            while (true)
            {
                Console.Write("Tipo do veículo (0 - Carro / 1 - Moto): ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int valor) && Enum.IsDefined(typeof(TipoDeVeiculo), valor))
                {
                    tipo = (TipoDeVeiculo)valor;
                    break;
                }
                else
                {
                    Console.WriteLine("Tipo de veículo inválido! Tente novamente.");
                }
            }

            Console.Write("Marca: ");
            string? marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string? modelo = Console.ReadLine();

            Cliente cliente = new(nomeCliente!, tel!, tipo, marca!, modelo!);
            clientes.Add(cliente);

            Console.WriteLine("Cliente cadastrado com sucesso!");
            Utils.VoltarAoMenu();
        }

        public static void ListarClientes()
        {
            if (clientes.Count >= 1)
            {
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"[Nome do cliente] - {cliente.Nome}\n" +
                        $"[Telefone] - {cliente.Telefone}\n" +
                        $"[Veículo] - {cliente.Veiculo}\n" +
                        $"[Marca] - {cliente.Marca}\n" +
                        $"[Modelo] - {cliente.Modelo}");
                    Console.WriteLine(new string('-', 70));
                }
                Utils.VoltarAoMenu();
            }
            else
            {
                Console.WriteLine("Não há clientes cadastrados");
                Console.WriteLine(new string('-', 70));
                Utils.VoltarAoMenu();
            }
        }

        public static void AdicionarMecanico(Mecanico mecanico)
        {
            mecanicos.Add(mecanico);
        }

        public static void ListarMecanicos()
        {
            foreach (var mecanico in mecanicos)
            {
                Console.WriteLine($"[Nome do mecanico] - {mecanico.Nome}\n" +
                   $"[Especialidade] - {mecanico.Especialidade}");
            }
        }

        public static void AdicionarOrdemDeServico(OrdemDeServico ordem)
        {
            ordens.Add(ordem);
        }

        public static void ListarOrdensDeServicos()
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