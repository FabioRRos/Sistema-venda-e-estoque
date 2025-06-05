using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Application.Services.Regras
{
    public class ValidaSenha : ValidaLogin
    {
        protected override bool Validacao(string login, string dir)
        {
            Console.Clear();
            List<string> lista = File.ReadAllLines(dir).ToList();

            int numLista = lista.Count;



            foreach (string linhaTemp in lista)
            {
                List<string> listaItens = linhaTemp.Split(',').ToList();


                if (listaItens[2] == login)
                {
                    bool loop = false;
                    int cont = 3;
                    do
                    {
                        string senha = "";
                        System.Console.WriteLine("Digite sua senha");
                        // senha = Console.ReadLine();
                        while (true)
                        {
                            var tecla = Console.ReadKey(true);
                            if (tecla.Key == ConsoleKey.Enter) break;
                            senha += tecla.KeyChar;
                            Console.Write("*");
                        }

                        if (senha == listaItens[3])
                        {
                            Console.Clear();
                            return true;
                        }
                        else
                        {
                            if (cont > 0)
                            {
                                cont--;
                                Console.Clear();
                                System.Console.WriteLine($"Senha invalida, tente novamente (tentativa restante {cont + 1})");
                                Thread.Sleep(1800);
                                Console.Clear();
                                loop = false;
                            }
                            else
                            {
                                Console.Clear();
                                System.Console.WriteLine("Senha invalida, contate o administrador");
                                Thread.Sleep(1800);
                                Console.Clear();
                                loop = true;
                                return false;
                            }

                        }

                    } while (!loop);

                }
                else
                {
                    System.Console.WriteLine("Login não encontrado, tente novamente");
                    Thread.Sleep(2500);
                    return false;
                }
            }
            System.Console.WriteLine("Não devia estar aqui");
            Thread.Sleep(2500);
            return false;

        }


    }


}