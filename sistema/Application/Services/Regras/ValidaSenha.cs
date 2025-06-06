using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
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
            bool loc = false;



            foreach (string linhaTemp in lista)
            {
                List<string> listaItens = linhaTemp.Split(',').ToList();


                if (listaItens[2] == login && listaItens[0] == "1")
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
                            loop = true;
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
                else if (listaItens[2] == login && listaItens[0] == "2") loc = true;
            }

            if (!loc)
            {
                System.Console.WriteLine("Login não localizado.");

            }
            else if (loc)
            {
                System.Console.WriteLine("Não possui acesso para esta opção.");
            }

            Thread.Sleep(2500);
            return false;
        }

        internal void Deconstruct(out object validaLogin, out object loc)
        {
            throw new NotImplementedException();
        }
    }
}