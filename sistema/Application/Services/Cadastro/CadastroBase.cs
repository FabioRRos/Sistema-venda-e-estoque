using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Data;

namespace sistema.Application.Services
{
    public abstract class CadastroBase<T>
    {
        protected ValidaCodigoExistente validador = new();
        protected abstract T CriarObjeto(int cod);
        protected bool RetornoErro { get; set; }
        protected abstract void Armazenar(T entidade, string caminho, bool retornoErro);
        public void CadastrarNovo(string caminho, string tipo)
        {
            bool loop = false;
            do
            {
                try
                {
                    Console.Clear();
                    System.Console.WriteLine($"Digite o código do {tipo}");
                    int codigo = int.Parse(Console.ReadLine()!);
                    if (validador.ValidaExistenciaCodigo(codigo, caminho))
                    {
                        T entidade = CriarObjeto(codigo); // metodo que utilizarei na classe filha
                        Armazenar(entidade, caminho, RetornoErro);// metodo que utilizarei na classe filha
                        loop = true;
                    }
                    else
                    {
                        Console.Clear();
                        System.Console.WriteLine("Código já cadastrado, favor tentar novamente.");
                        loop = false;
                        Thread.Sleep(1500);
                    }
                }
                catch
                {
                    System.Console.WriteLine("Opção invalida");
                    Thread.Sleep(1800);
                    loop = false;
                }
            } while (!loop);
        }
    }
}