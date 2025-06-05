using sistema.Interface.Menu;
bool loop = false;
do
{
    try
    {
        Console.Clear();
        System.Console.WriteLine("*****CADASTRO DE PRODUTOS********");
        System.Console.WriteLine("1 - Menu Grupo de produtos");
        System.Console.WriteLine("2 - Menu Produtos");
        System.Console.WriteLine("3 - Menu Funcionários");
        System.Console.WriteLine("0 - Exit");
        int opcao = int.Parse(System.Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                {
                    var grupoProduto = new MenuGrupoProduto();
                    grupoProduto.MenuDeGrupoProduto();
                }
                break;
            case 2:
                {
                    var produto = new MenuProduto();
                    produto.MenuDeProdutos();
                }
                break;
            case 3:
                {
                    var cadFuncionario = new MenuFuncionario();
                    cadFuncionario.CadFuncionario();
                }
                break;

            case 0:
                {
                    loop = true;
                    Console.Clear();
                }
                break;
            default:
                {
                    System.Console.WriteLine("Opção não disponível, tente novamente");
                    Thread.Sleep(1800);
                }
                ; break;
        }
    }
    catch
    {
        System.Console.WriteLine("A entrada é numérica. Tente novamente");
        Thread.Sleep(1800);
        loop = false;
    }
} while (loop == false);