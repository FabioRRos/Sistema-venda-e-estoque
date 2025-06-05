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
                System.Console.WriteLine("Deu bom");
            }
            else
                return;

            Thread.Sleep(2500);
        }
    }
}