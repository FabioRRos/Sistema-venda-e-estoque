using sistema.Data;
using sistema.Domain.Entities;

namespace sistema.Application.Services
{
    public class CadastrarGrupoProduto : CadastroBase<GrupoProduto>
    {
        protected override GrupoProduto CriarObjeto(int cod)
        {
            GrupoProduto grupoProduto = new();
            try
            {
                grupoProduto.CodGrupoProduto = cod;
                System.Console.WriteLine("Agora digite o nome do grupo que será criado");
                grupoProduto.NomeGrupoProduto = System.Console.ReadLine();
                RetornoErro = false;
            }
            catch
            {
                RetornoErro = true;
            }
            return grupoProduto;

        }

        protected override void Armazenar(GrupoProduto entidade, string caminho, bool retornoErro)
        {
            if (retornoErro)
            {
                System.Console.WriteLine("Sua ultima entrada foi invalida, vamos tentar novamente");
                Thread.Sleep(3800);
            }
            else if (!retornoErro)
            {
                var armazenamento = new Armazenamento();
                armazenamento.ArmazenamentoSalveGrupo(entidade, caminho);
            }
        }



    }
}