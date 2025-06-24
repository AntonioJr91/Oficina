namespace Oficina
{
    internal class Cliente : Pessoa, IConsultar
    {
        public TipoDeVeiculo Veiculo { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public void Consultar()
        {
            Console.WriteLine($"[Nome do cliente] - {Nome}\t[Tel] - {Telefone}\t[Tipo de veículo] - {Veiculo}\t[Marca] - {Marca}\t[Modelo] - {Modelo}\n");
        }
    }
}

