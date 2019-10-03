namespace SqImport.Domain.Interfaces
{
    public interface ICliente
    {
        int IdentificadorERP { get; set; }
        string Nome { get; set; }
        string Regiao { get; set; }
    }
}