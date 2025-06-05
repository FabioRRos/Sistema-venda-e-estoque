using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Application.Processing;
using sistema.Domain.Entities;

namespace sistema.Data
{
    public class Editar : ProcessadorLinha
    {
        /// <summary>
        /// Esta classe é destinada para editar valores dentro de uma linha
        /// </summary>
        /// <param name="dir"> Diretório do arquivo</param>
        /// <param name="tipo">Tipo, se é pessoa, se é grupo ou produto</param>
        /// <param name="cod">É o código do produto ou código do grupo</param>
        public void EditarItem(string dir, string tipo, int cod)
        {
            Console.Clear();
            string textoAtualizado = "";
            int posicaoDaLista = -1;
            //cria uma lista com o valor do arquivo
            List<string> lista = File.ReadAllLines(dir).ToList();// aqui tenho a lista com os valores (identido ao arquivo)
            int linhas = (lista.Count); // total de linhas do arquivo anterior
            for (int i = 0; i < linhas; i++)// enquanto i for menor que linhas
            {
                // crio valores individual e aqui eu consigo ver se o código = o digitado
                List<string> itensLista = lista[i].Split(',').ToList(); // aqui quebra os valores da linha 0 = cód, 1 = cod de barras 2 = nome etc..

                if (itensLista[0] == cod.ToString())
                {
                    posicaoDaLista = i;
                    for (int j = 0; j < itensLista.Count; j++)
                    {
                        System.Console.Write($"Digite o novo valor de [{itensLista[j]}]: ");
                        itensLista[j] = Console.ReadLine()!;

                        //Salvo em uma variavel o valor, separando por ",".
                        if (j == 0)
                        {
                            textoAtualizado += itensLista[j] + ",";
                        }
                        else if (j < itensLista.Count)
                        {
                            textoAtualizado += itensLista[j];
                        }
                    }
                }
            }
            Console.Clear();
            if (posicaoDaLista >= 0)
            {
                lista[posicaoDaLista] = textoAtualizado;
                File.WriteAllLines(dir, lista);
                System.Console.WriteLine($"Alterado com sucesso! para:\n{textoAtualizado}");
            }
            else
            {
                System.Console.WriteLine($"Não localizamos o {tipo}");
            }
            System.Console.WriteLine("Pressione qualquer tecla para voltar");
            Console.ReadKey();
        }
    }
}
