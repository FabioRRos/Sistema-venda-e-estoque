using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Data
{
    public class ValidaCodigoExistente
    {
        public bool ValidaExistenciaCodigo(int cod, string diretorioArquivoAberto)
        {
            int numLinhas;
            int cont = 0;
            string stringCod = cod.ToString();

            // ABRE O ARQUIVO E SALVA O VALOR DA VARIAVEL + A QUANTIDADE DE LINHAS
            var arquivoBase = new ArquivoBase();


            string text = arquivoBase.AbrirArquivo(diretorioArquivoAberto);
            numLinhas = (text.Split('\n').Length) - 1;

            // Aqui crio um vetor para ler linha a linha
            string[] linhas = text.Split('\n');

            // Aqui será o vetor com os valores das linhas separados.
            string[] vetorQuebraLinha;
            while (cont < numLinhas)
            {
                vetorQuebraLinha = linhas[cont].Split(',');
                if (vetorQuebraLinha[0] == stringCod) return false;
                cont++;
            }
            return true;
        }

    }
}