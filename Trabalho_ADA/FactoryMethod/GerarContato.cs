using Trabalho_ADA.FactoryMethod.Contato;

namespace Trabalho_ADA.FactoryMethod
{
    public class GerarContato : ContatoFactory
    {
        public override ContatoIntF IniciarContato(string tipo)
        {
            if (tipo.ToLower().Equals("telefone"))
                return new ContatoTelefone();

            if (tipo.ToLower().Equals("email"))
                return new ContatoEmail();

            if (tipo.ToLower().Equals("sms"))
                return new ContatoSMS();

            return null;
        }
    }
}
