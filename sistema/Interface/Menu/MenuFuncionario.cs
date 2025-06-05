using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Application.Services.Cadastro;
using sistema.Application.Services.Regras;
using sistema.Application.Services.Regras.Editar;

namespace sistema.Interface.Menu
{
    public class MenuFuncionario
    {
        public void CadFuncionario()
        {
            bool loop = false;
            int opcao;
            string dir = @"C:\projetos\Sistema-venda-e-estoque\ArquivosSalvos\funcionarios.txt";
            do
            {
                try
                {
                    Console.Clear();
                    System.Console.WriteLine("*****MENU DO FUNCIONARIO********");
                    System.Console.WriteLine("1 - Cadastrar funcionario");
                    System.Console.WriteLine("2 - Editar funcionario");
                    System.Console.WriteLine("3 - Deletar funcionario");
                    System.Console.WriteLine("4 - Listar funcionarios");
                    System.Console.WriteLine("0 - Voltar ao menu inicial");

                    opcao = int.Parse(System.Console.ReadLine()!);
                    switch (opcao)
                    {
                        case 1:
                            {
                                var cadNovoFuncionario = new CadastrarFuncionario();
                                cadNovoFuncionario.CadNovoFuncionario(dir);
                            }
                            break;
                        case 2:
                            {
                                var editarFuncionario = new EditarFuncionario();
                                editarFuncionario.EditarDadosFuncionario(dir);

                            }
                            break;
                        case 3:
                            {


                            }
                            break;
                        case 4:
                            {


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