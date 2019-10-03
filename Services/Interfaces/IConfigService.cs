namespace SqImport.Services.Interfaces
{
    public interface IConfigService
    {
        string ObterConfiguracao<T>(string caminhoArquivoClientes);
    }
}