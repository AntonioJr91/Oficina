namespace Oficina
{
    internal class TipoDeServicosValoresPadrao
    {
        public static decimal ObterValorPadrao(TipoDeServico tipo)
        {
            return tipo switch
            {
                TipoDeServico.TrocaDeOleo => 100.00m,
                TipoDeServico.AlinhamentoEbalanceamento => 150.00m,
                TipoDeServico.RevisaoDeFreios => 200.00m,
                TipoDeServico.AjusteDeCorrente => 50.00m,
                _ => 0.00m
            };
        }
    }
}
