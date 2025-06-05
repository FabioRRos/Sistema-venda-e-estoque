using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Application.Services;
using sistema.Data;

namespace sistema.Interface.Menu
{
    public class MenuGrupoProduto
    {
        public void MenuDeGrupoProduto()
        {
            bool loop = false;
            int opcao;
            string dir = @"C:\projetos\Sistema-venda-e-estoque\ArquivosSalvos\grupoProduto.txt";
            do
            {
                try
                {
                    Console.Clear();
                    System.Console.WriteLine("*****MENU DE PRODUTOS********");
                    System.Console.WriteLine("1 - Cadastrar Grupo de produto");
                    System.Console.WriteLine("2 - Buscar / Editar Grupo de produto");
                    System.Console.WriteLine("3 - Deletar Grupo de produto");
                    System.Console.WriteLine("4 - Listar Grupo de produtos");
                    System.Console.WriteLine("0 - Voltar ao menu inicial");

                    opcao = int.Parse(System.Console.ReadLine()!);
                    switch (opcao)
                    {
                        case 1:
                            {
                                var cadastrarGrupoProduto = new CadastrarGrupoProduto();
                                cadastrarGrupoProduto.CadastrarNovo(dir, "Grupo de produto");

                            }
                            break;
                        case 2:
                            {
                                var buscar = new Buscar();
                                buscar.RetornaBusca(dir, "grupo de produto");
                            }
                            break;
                        case 3:
                            {
                                var remover = new Remover();
                                remover.removerItem(dir, "grupo de produto");

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
                        case 0:
                            {
                                loop = true;
                            }
                            break;

                        default:
                            {
                                System.Console.WriteLine("Opção invalida, tente novamente");

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
