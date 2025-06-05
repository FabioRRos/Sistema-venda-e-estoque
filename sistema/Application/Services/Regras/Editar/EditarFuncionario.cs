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

            if (ValidacaoLogin(dir)) System.Console.WriteLine("deu bom");
            else System.Console.WriteLine("Deu ruim");
            Thread.Sleep(2500);


        }
    }

}