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
                        System.Console.WriteLine("Digite sua senha");
                        var senha = Console.ReadLine();

                        if (senha == listaItens[3])
                        {
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