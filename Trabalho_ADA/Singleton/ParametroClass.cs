namespace Trabalho_ADA.Singleton
{
    public class ParametroClass
    {
        public static ParametroClass parametroInstance;

        private ParametroClass()
        {

        }

        public static ParametroClass GetInstance()
        {
            if (parametroInstance == null)
                parametroInstance = new ParametroClass();

            return parametroInstance;
        }
    }
}
