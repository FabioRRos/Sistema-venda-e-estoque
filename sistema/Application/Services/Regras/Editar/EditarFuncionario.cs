using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Application.Services.Regras.Editar
{
    public class EditarFuncionario : ValidaSenha
    {
        public void EditarDadosFuncionario(string dir)
        {
            bool liberaAcesso = false;
            var validaLogin = new ValidaSenha();
            liberaAcesso = validaLogin.ValidacaoLogin(dir);

            if (liberaAcesso)
            {
                List<string> listaFunc = File.ReadAllLines(dir).ToList();
                System.Console.WriteLine("Selecione o Funcionário que deseja alterar.");

                for (int i = 1; i <= listaFunc.Count(); i++)
                {
                    List<string> listTemp = listaFunc[i].Split(',').ToList();
                    System.Console.WriteLine($"{i}1 - {listTemp[i]} ");

                }
                var opcao = int.Parse(Console.ReadLine());
                Console.ReadKey();
            }
            else
                return;

            Thread.Sleep(2500);
        }
    }
}