using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Application.Processing;
using sistema.Data;

namespace sistema.Application.Services
{
    public class Buscar : ProcessadorLinha
    {
        public void RetornaBusca(string dir, string tipo)
        {
            bool loop = false;
            do
            {
                Console.Clear();
                try
                {
                    string retornoLinha;
                    System.Console.Write($"Digite o código do {tipo}: ");
                    var cod = int.Parse(Console.ReadLine()!);
                    retornoLinha = ObterLinha(cod, dir);

                    if (retornoLinha == "")
                    {
                        System.Console.WriteLine("Código não localizado, tente novamente");
                        Thread.Sleep(1800);
                        loop = false;
                    }
                    else
                    {
                        System.Console.WriteLine(retornoLinha);
                        System.Console.WriteLine("Gostaria de editar?");
                        System.Console.WriteLine("1 - sim");
                        System.Console.WriteLine("2 - Voltar ao menu anterior");
                        var editSim = int.Parse(Console.ReadLine()!);
                        if (editSim == 1)
                        {
                            var editar = new Editar();
                            editar.EditarItem(dir, tipo, cod);
                            loop = true;
                        }
                        else if (editSim == 2)
                        {
                            loop = true;
                        }
                        else
                        {
                            System.Console.WriteLine("Opção invalida, tente novamente");
                            Thread.Sleep(1500);
                            loop = false;
                        }
                    }
                }
                catch
                {
                    loop = false;
                    System.Console.WriteLine("Código invalido, tente novamente.");
                    Thread.Sleep(1800);
                }
            } while (loop == false);
        }
    }
}
