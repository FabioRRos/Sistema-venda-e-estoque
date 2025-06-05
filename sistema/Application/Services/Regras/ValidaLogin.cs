using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace sistema.Application.Services.Regras
{
    public abstract class ValidaLogin
    {


        protected abstract bool Validacao(string login, string dir);

        // protected abstract bool RetornoValidado(bool entidade);

        public bool ValidacaoLogin(string dir)
        {
            System.Console.WriteLine("Digite o Login");
            var login = Console.ReadLine();

            return Validacao(login, dir);

        }

    }
}