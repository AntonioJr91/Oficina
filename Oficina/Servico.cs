namespace Oficina
{
    internal class Servico
    {
        public TipoDeServico TipoServico { get; set; }
        public decimal Valor { get; set; }

        public Servico(TipoDeServico tipo)
        {
            TipoServico = tipo;
            Valor = TipoDeServicosValoresPadrao.ObterValorPadrao(tipo);
        }
    }
}
