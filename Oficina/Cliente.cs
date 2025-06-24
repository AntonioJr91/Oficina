namespace Oficina
{
    internal class Cliente : Pessoa, IConsultar
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
        public void Consultar()
        {
            Console.WriteLine($"[Nome do cliente] - {Nome}\t[Tel] - {Telefone}\t[Tipo de veículo] - {Veiculo}\t[Marca] - {Marca}\t[Modelo] - {Modelo}\n");
        }
    }
}

