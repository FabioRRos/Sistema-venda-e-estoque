using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Application.Processing;

namespace sistema.Data
{
    public class Remover : ProcessadorLinha
    {

        public void removerItem(string dir, string tipo)
        {
            string retornoLinha;
            System.Console.Write($"Digite o código do {tipo}: ");
            var cod = int.Parse(Console.ReadLine()!);
            retornoLinha = ObterLinha(cod, dir);

            if (retornoLinha == "")
            {
                System.Console.WriteLine("Código não localizado, tente novamente");
                Thread.Sleep(1800);
            }
            else
            {
                //cria uma lista com o valor do arquivo
                List<string> lista = File.ReadAllLines(dir).ToList();
                int linhas = (lista.Count);
                System.Console.WriteLine(linhas);
                for (int i = 0; i < linhas; i++)
                {
                    List<string> itensLista = lista[i].Split(',').ToList();
                    if (itensLista[0] == cod.ToString())
                    {
                        lista.RemoveAt(i);
                    }
                }
                File.WriteAllLines(dir, lista);

                System.Console.WriteLine("Deletado com sucesso!");
                System.Console.WriteLine("Pressione qualquer tecla para voltar");
                Console.ReadKey();
            }
        }
    }
}