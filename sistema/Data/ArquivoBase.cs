using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Data //AQUI EU ABRO O ARQUIVO DE TEXTO
{
    public class ArquivoBase
    {
        protected string? conteudo;
        public string AbrirArquivo(string diretorio)
        {
            if (File.Exists(diretorio))
            {
                conteudo = File.ReadAllText(diretorio);
                return conteudo;
            }
            else
            {
                return "";
            }
        }
    }
}