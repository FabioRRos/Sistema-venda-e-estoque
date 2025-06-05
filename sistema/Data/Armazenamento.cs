using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Domain.Entities;

namespace sistema.Data
{
    public class Armazenamento
    {
        /// <summary>
        /// Armazena valores no arquivo de texto.
        /// </summary>
        /// <param name="grupoProduto"></param>
        /// <param name="dir"></param>
        public void ArmazenamentoSalveGrupo(GrupoProduto grupoProduto, string dir)
        {
            string objGrupoProdutoString = ($"{grupoProduto.CodGrupoProduto.ToString() + "," +
             grupoProduto.NomeGrupoProduto}");
            List<string> lista = File.ReadAllLines(dir).ToList();
            lista.Add(objGrupoProdutoString);
            File.WriteAllLines(dir, lista);
            System.Console.WriteLine("Grupo cadastrado com sucesso!");
            Thread.Sleep(2500);
        }

        public void ArmazenamentoSalveProduto(Produto produto, string dir)
        {
            string objProdutoString = ($"{produto.CodProduto.ToString() + "," +
                produto.CodBarrasProduto.ToString() + "," +
                produto.NomeProduto + "," +
                produto.QuantidadeProduto.ToString() + "," +
                produto.PrecoProduto.ToString() + "," +
                produto.CodGrupoProduto.ToString() + "," +
                produto.NomeGrupoProduto + "," +
                produto.DescricaoProduto}");

            List<string> lista = File.ReadAllLines(dir).ToList();
            lista.Add(objProdutoString);
            File.WriteAllLines(dir, lista);
            System.Console.WriteLine("Produto cadastrado com sucesso!");
            Thread.Sleep(2500);
        }

        public void ArmazenamentoSalveFuncionario(Funcionario funcionario, string dir)
        {
            List<string> lista = File.ReadAllLines(dir).ToList();
            lista.Add(funcionario.master + "," + funcionario.Nome + "," + funcionario.login + "," + funcionario.senha);
            File.WriteAllLines(dir, lista);
            System.Console.WriteLine("Funcionário cadastrado com sucesso");
            Thread.Sleep(2500);
        }
    }
}