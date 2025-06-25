namespace Oficina
{
    internal class Cliente : Pessoa, ILista
    {
        public TipoDeVeiculo Veiculo { get; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

        public Cliente(string nome, string telefone, TipoDeVeiculo tipoVeiculo, string marca, string modelo)
        {
            Nome = nome;
            Telefone = telefone;
            Veiculo = tipoVeiculo;
            Marca = marca;
            Modelo = modelo;
        }
        public void ExibirLista()
        {
            Console.WriteLine($"[Nome do cliente] - {Nome}\n" +
                $"[Tel] - {Telefone}\n" +
                $"[Tipo de veículo] - {Veiculo}\n" +
                $"[Marca] - {Marca}\n" +
                $"[Modelo] - {Modelo}");
        }
    }
}

