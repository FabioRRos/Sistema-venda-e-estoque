using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Application.Services;
using sistema.Data;

namespace sistema.Interface.Menu
{
    public class MenuProduto
    {
        public void MenuDeProdutos()
        {
            bool loop = false;
            int opcao;
            string dir = @"C:\projetos\Sistema-venda-e-estoque\ArquivosSalvos\produto.txt";

            do
            {
                try
                {
                    Console.Clear();
                    System.Console.WriteLine("*****MENU DE PRODUTOS********");
                    System.Console.WriteLine("1 - Cadastrar produto");
                    System.Console.WriteLine("2 - Buscar / Editar produto");
                    System.Console.WriteLine("3 - Deletar produto");
                    System.Console.WriteLine("4 - Listar produtos");
                    System.Console.WriteLine("5 - Estoque do produto");
                    System.Console.WriteLine("0 - Voltar ao menu inicial");

                    opcao = int.Parse(System.Console.ReadLine()!);
                    switch (opcao)
                    {
                        case 1:
                            {
                                var cadastrarProduto = new CadastrarProduto();
                                cadastrarProduto.CadastrarNovo(dir, "produto");
                            }
                            break;
                        case 2:
                            {
                                var buscar = new Buscar();
                                buscar.RetornaBusca(dir, "produto");
                            }
                            break;
                        case 3:
                            {
                                var remover = new Remover();
                                remover.removerItem(dir, "produto");

                            }
                            break;
                        case 4:
                            {
                                Console.Clear();
                                var arquivoBase = new ArquivoBase();
                                Console.WriteLine(arquivoBase.AbrirArquivo(dir));
                                System.Console.WriteLine("**** Pressione qualquer tecla pra sair ****");
                                Console.ReadKey();

                            }
                            break;
                        case 5:
                            {
                                var estoqueProduto = new EstoqueProduto();
                                estoqueProduto.EstoquedoProduto(dir);

                            }
                            ; break;
                        case 0:
                            {
                                loop = true;
                            }
                            break;
                        default:
                            {
                                System.Console.WriteLine("Opção invalida, tente novamente");
                                Thread.Sleep(1800);
                                loop = false;
                            }
                                ; break;
                    }
                }
                catch
                {
                    System.Console.WriteLine("A entrada é numérica, tente novamente");
                    loop = false;
                    Thread.Sleep(1800);
                }
            } while (loop == false);
        }
    }
}