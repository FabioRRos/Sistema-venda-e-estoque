using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Application.Services
{
    public class EstoqueProduto
    {
        public void EstoquedoProduto(string dir)
        {
            bool loop = false;
            string cod;
            do
            {

                Console.Clear();
                System.Console.WriteLine($"Digite o código do produto");
                cod = Console.ReadLine()!;

                List<string> lista = File.ReadAllLines(dir).ToList();
                int linhas = (lista.Count);
                System.Console.WriteLine(linhas);
                for (int i = 0; i < linhas; i++)
                {
                    List<string> itensLista = lista[i].Split(',').ToList();
                    if (itensLista[0] == cod.ToString())
                    {
                        Console.Clear();
                        System.Console.WriteLine($"Item: {itensLista[2]}\nQuantidade: {itensLista[3]} unidades");
                        System.Console.WriteLine("Digite qualquer tecla para sair...");
                        Console.ReadKey();
                        loop = true;
                    }
                }
                if (!loop)
                {
                    Console.Clear();
                    System.Console.WriteLine("Produto não localizado, gostaria de tentar novamente?");
                    System.Console.WriteLine("1 - Sim");
                    System.Console.WriteLine("2 - Não");
                    var opcao = Console.ReadLine();
                    if (opcao != "1")
                    {
                        loop = true;
                    }
                }
            } while (!loop);
        }
    }
}