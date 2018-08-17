using Trabalho_ADA.FactoryMethod.Contato;

namespace Trabalho_ADA.FactoryMethod
{
    public abstract class ContatoFactory
    {
        public abstract ContatoIntF IniciarContato(string tipo);
    }
}