namespace Trabalho_ADA.Singleton
{
    public class EmpresaClass
    {
        public static EmpresaClass empresaInstance;

        private EmpresaClass()
        {

        }

        public static EmpresaClass GetInstance()
        {
            if (empresaInstance == null)
                empresaInstance = new EmpresaClass();

            return empresaInstance;
        }
    }
}
