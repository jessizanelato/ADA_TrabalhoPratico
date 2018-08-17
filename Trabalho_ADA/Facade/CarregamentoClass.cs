namespace Trabalho_ADA.Facade
{
    public class CarregamentoClass
    {
        private SistemaGravacao gravacao;
        private SistemaTemporizador temporizador;
        private SistemaFilasAtendimento filasAtendimento;

        public CarregamentoClass()
        {
            gravacao = new SistemaGravacao();
            gravacao.CarregarSistema();
            gravacao.ChecarGravadores();
            gravacao.ChecarPortas();

            temporizador = new SistemaTemporizador();
            temporizador.ChecarContadores();
            temporizador.IniciarContadores();

            filasAtendimento = new SistemaFilasAtendimento();
            filasAtendimento.SelecionarAtendimentos();
            filasAtendimento.OrdenarAtendimentos();
            filasAtendimento.DisponibilizarAtendimentos();
        }
    }
}