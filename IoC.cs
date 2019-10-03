namespace SqImport
{
    public static class IoC
    {
        public static Container ObterContainer()
        {
            var container = Container.Inicializar();

            // Registre suas dependências aqui...

            //container.Registrar<IClienteService, ...>();
            //container.Registrar<ILogService, ...>();
            //container.Registrar<IExibicaoService, ...>();
            //container.Registrar<IPremiacaoService, ...>();
            //container.Registrar<IConfigService, ...>();
            container.Registrar<Sistema>();

            return container;
        }
    }
}
