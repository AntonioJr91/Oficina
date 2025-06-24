using Oficina;

Console.WriteLine("### Oficina Sto Antônio ###\n");

bool continuar = true;
while (continuar)
{
    Console.WriteLine("1. Cadastrar cliente");
    Console.WriteLine("2. Listar clientes");
    Console.WriteLine("3. Cadastrar mecânico");
    Console.WriteLine("4. Listar mecânico");
    Console.WriteLine("5. Adicionar uma ordem de serviço");
    Console.WriteLine("0. Sair");
    Console.Write("\nEscolha uma opção: ");
    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "0":
            continuar = false;
            Console.WriteLine("Programa encerrado!");
            break;

        case "1":
            Console.Clear();
            SistemaOficina.AdicionarCliente();
            break;

        case "2":
            Console.Clear();
            SistemaOficina.ListarClientes();
            break;
    }
}