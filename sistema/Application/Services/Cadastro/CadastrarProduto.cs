using sistema.Data;
using sistema.Domain.Entities;

namespace sistema.Application.Services
{
    public class CadastrarProduto : CadastroBase<Produto>
    {
        protected override Produto CriarObjeto(int cod)
        {

            Produto produto = new();
            try
            {
                produto.CodProduto = cod;
                System.Console.WriteLine("Digite o nome do produto");
                produto.NomeProduto = Console.ReadLine();
                System.Console.WriteLine("Digite o código de barras");
                produto.CodBarrasProduto = int.Parse(Console.ReadLine()!);
                System.Console.WriteLine("Digite a quantidade do produto");
                produto.QuantidadeProduto = int.Parse(Console.ReadLine()!);
                System.Console.WriteLine("Digite o preço (formato 20.00) com ponto");
                produto.PrecoProduto = double.Parse(Console.ReadLine()!);
                System.Console.WriteLine("Digite o nome do grupo que ele pertence pertence");
                produto.NomeGrupoProduto = Console.ReadLine();
                System.Console.WriteLine("Digite o código desse grupo");
                produto.CodGrupoProduto = int.Parse(Console.ReadLine()!);
                System.Console.WriteLine("Digite observação do produto");
                RetornoErro = false;
            }
            catch
            {
                RetornoErro = true;
            }
            return produto;
        }

        protected override void Armazenar(Produto entidade, string caminho, bool retornoErro)
        {
            if (retornoErro)
            {
                System.Console.WriteLine("Sua ultima entrada foi invalida, vamos tentar novamente");
                Thread.Sleep(3800);
            }
            else if (!retornoErro)
            {
                var armazenamento = new Armazenamento();
                armazenamento.ArmazenamentoSalveProduto(entidade, caminho);
            }
        }
    }
}