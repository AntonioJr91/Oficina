namespace Oficina
{
    internal static class Utils
    {
        public static void VoltarAoMenu()
        {
            Console.Write("\nPressione qualquer tecla para voltar ao menu. . .");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ExibirSeparadorItens()
        {
            Console.WriteLine(new string('-', 70));
        }

        public static string LeitorDeEntradaTexto(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine() ?? string.Empty;
        }

        public static decimal LeitorDeEntradaDecimal(string msg)
        {
            decimal valor;
            while (true)
            {
                Console.Write(msg);
                Console.Write(msg);
                if (decimal.TryParse(Console.ReadLine(), out valor))
                    return valor;
                Console.WriteLine("Valor inválido. Digite um número decimal.");
            }
        }

        public static TEnum LeitorDeEntradaEnum<TEnum>(string msg) where TEnum : struct, Enum 
        {
            while (true)
            {
                Console.Write(msg);
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int valorInt) && Enum.IsDefined(typeof(TEnum), valorInt))
                {
                    return (TEnum)(object)valorInt;
                }
                Console.WriteLine("Valor inválido. Tente novamente.");
            }

        }
    }
}
