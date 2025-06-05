using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using sistema.Data;
using sistema.Domain.Entities;

namespace sistema.Application.Services.Cadastro
{
    public class CadastrarFuncionario
    {
        public void CadNovoFuncionario(string dir)
        {
            var funcionario = new Funcionario();
            Console.Clear();

            try
            {
                System.Console.WriteLine("Digite o nome completo do funcionário");
                funcionario.Nome = Console.ReadLine();
                System.Console.WriteLine($"Digite a senha do funcionário {funcionario.Nome}:");
                funcionario.senha = Console.ReadLine();
                System.Console.WriteLine("Funcionário master?");
                System.Console.WriteLine("1 - Sim");
                System.Console.WriteLine("2 - Não");
                funcionario.master = int.Parse(Console.ReadLine());
                if (funcionario.master <= 2 && funcionario.master >= 1)
                {
                    List<string> criaLogin = funcionario.Nome.Split(' ').ToList();
                    int qtdeNomes = criaLogin.Count();

                    string tempLogin = "";

                    for (var i = 0; i < qtdeNomes; i++)
                    {
                        if (i == 0)
                        {
                            tempLogin = criaLogin[i] + '.';
                        }

                        if (i == qtdeNomes - 1)
                        {
                            tempLogin = tempLogin + criaLogin[i];
                        }
                    }
                    funcionario.login = tempLogin;
                    System.Console.WriteLine($"O Login de {funcionario.Nome} é : {funcionario.login}");
                    var armazenamento = new Armazenamento();
                    armazenamento.ArmazenamentoSalveFuncionario(funcionario, dir);
                }
                else
                {
                    System.Console.WriteLine("Os valores precisam ser 1 e 2. Tente novamente");
                    Thread.Sleep(2000);
                }

            }
            catch
            {
                System.Console.WriteLine("A entrada precisa ser numérica. Tente novamente");
                Thread.Sleep(2000);
            }

        }

    }
}