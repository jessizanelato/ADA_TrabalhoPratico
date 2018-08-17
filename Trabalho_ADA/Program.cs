using Trabalho_ADA.Facade;
using Trabalho_ADA.FactoryMethod;
using Trabalho_ADA.Singleton;

namespace Trabalho_ADA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Padrão - Singleton
            var empresa = EmpresaClass.GetInstance();
            var parametro = ParametroClass.GetInstance();

            // Padrão - Factory Method
            var gerarContato = new GerarContato();
            var contato = gerarContato.IniciarContato("telefone");

            // Padrão - Facade
            var carregarFacade = new CarregamentoClass();
        }
    }
}
