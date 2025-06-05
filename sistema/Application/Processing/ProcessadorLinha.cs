using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Data;

namespace sistema.Application.Processing
// AQUI EU PEGO O ARQUIVO DE TEXTO E RETORNO A LINHA DE ACORDO COM O CÓDIGO
{
    public class ProcessadorLinha : ArquivoBase
    {
        protected string? ValorLinha;
        public string ObterLinha(int cod, string dir)
        // Conteudo  a variavel onde tenho o arquivo de texto.
        {
            ValorLinha = "";
            conteudo = AbrirArquivo(dir);
            string stringCod = cod.ToString();
            // Aqui crio uma variavel inteiro para cereber a quantidade de linhas que tem o arquivo
            var numLinhas = (conteudo.Split('\n').Length) - 1;
            // Aqui crio um vetor para ler linha a linha
            string[] linhas = conteudo.Split('\n');
            int cont = 0;
            while (cont < numLinhas)
            {
                // Aqui eu crio um vetor pra salvar uma linha no arquivo separando por virgula.
                string[] vetorQuebraLinha = linhas[cont].Split(',');

                // Se o primeiro campo da coluna for igual ao código que foi digitado, salvo a linha na variavel ValorLinha
                if (vetorQuebraLinha[0] == stringCod)
                {
                    ValorLinha = linhas[cont];
                }
                cont++;
            }
            return ValorLinha;
        }
    }
}