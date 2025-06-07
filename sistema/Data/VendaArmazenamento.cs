using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using sistema.Application.Services.Regras;

namespace sistema.Data
{
    public class VendaArmazenamento
    {

        protected int _codVenda { get; set; }
        protected int _valorTotal { get; set; }
        protected string _vendedor { get; set; }




        public void Venda()
        {

            List<string> listaDeItensDaVenda = new();

            var loop = false;
            do
            {

                System.Console.WriteLine("Digite o código do produto");
                _codVenda = int.Parse(Console.ReadLine());


            } while (!loop);

        }


    }
}