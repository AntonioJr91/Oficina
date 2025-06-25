namespace Oficina
{
    internal static class SistemaOficina
    {
        private static readonly List<Cliente> clientes = new();
        private static readonly List<Mecanico> mecanicos = new();
        private static readonly List<OrdemDeServico> ordensServico = new();

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

            Console.WriteLine("\nCliente cadastrado com sucesso!");
            Utils.VoltarAoMenu();
        }

        public static void ListarClientes()
        {
            if (clientes.Count >= 1)
            {

                foreach (var cliente in clientes)
                {
                    cliente.ExibirLista();
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

        public static void AdicionarMecanico()
        {
            Console.Write("Nome: ");
            string? nome = Console.ReadLine();

            EspecialidadeMecanico especialidade;

            while (true)
            {
                Console.Write("Especialidade (0 - Carro / 1 - Moto): ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int valor) && Enum.IsDefined(typeof(TipoDeVeiculo), valor))
                {
                    especialidade = (EspecialidadeMecanico)valor;
                    break;
                }
                else
                {
                    Console.WriteLine("Especialidade inválida! Tente novamente.");
                }

            }

            Mecanico novoMecanico = new(nome, especialidade);
            mecanicos.Add(novoMecanico);
            Console.WriteLine("\nMecânico adicionado com sucesso!");
            Utils.VoltarAoMenu();
        }

        public static void ListarMecanicos()
        {
            if (mecanicos.Count >= 1)
            {
                foreach (var mecanico in mecanicos)
                {
                    mecanico.ExibirLista();
                    Utils.ExibirSeparadorItens();
                }
                Utils.VoltarAoMenu();
            }
            else
            {
                Console.WriteLine("Não há mecânicos cadastrados");
                Utils.ExibirSeparadorItens();
                Utils.VoltarAoMenu();
            }
        }

        public static void AdicionarOrdemDeServico()
        {
            string? nome = Utils.LeitorDeEntradaTexto("Nome do cliente: ");

            string? telefone = Utils.LeitorDeEntradaTexto("Telefone: ");

            string? marca = Utils.LeitorDeEntradaTexto("Marca do veículo: ");

            string? modelo = Utils.LeitorDeEntradaTexto("Modelo do veículo: ");

            TipoDeVeiculo tipoVeiculo = Utils.LeitorDeEntradaEnum<TipoDeVeiculo>("Tipo do veículo (0 - Carro / 1 - Moto): ");

            Cliente cliente = new(nome, telefone, tipoVeiculo, marca, modelo);

            string? nomeMecanico = Utils.LeitorDeEntradaTexto("Nome do mecânico: ");

            EspecialidadeMecanico especialidade = Utils.LeitorDeEntradaEnum<EspecialidadeMecanico>("Especialidade do mecânico (0 - Carro / 1 - Moto): ");

            Mecanico mecanico = new(nomeMecanico, especialidade);

            TipoDeServico tipoServico = Utils.LeitorDeEntradaEnum<TipoDeServico>("Tipo de serviço (0 - Troca de oléo / 1 - Ajuste de corrente / 2 - Alinhamento&Balanceamento / 3 - Revisão dos freios): ");

            Servico novoServico = new(tipoServico);

            OrdemDeServico novaOrdem = new(cliente, mecanico, novoServico);

            ordensServico.Add(novaOrdem);

            Console.WriteLine("Ordem de serviço adicionada com sucesso!");
            Utils.VoltarAoMenu();
        }

        public static void ListarOrdensDeServicos()
        {
            if (ordensServico.Count >= 1)
            {
                foreach (var ordem in ordensServico)
                {
                    ordem.ExibirLista();
                    Utils.ExibirSeparadorItens();
                }
                Utils.VoltarAoMenu();
            }
            else
            {
                Console.WriteLine("Não há ordem de serviço cadastradas!");
                Utils.ExibirSeparadorItens();
                Utils.VoltarAoMenu();
            }
        }
    }
}