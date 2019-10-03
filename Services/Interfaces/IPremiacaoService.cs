using SqImport.Domain.Interfaces;

namespace SqImport.Services.Interfaces
{
    public interface IPremiacaoService
    {
        int CalcularMedalhasOuro(ICliente cliente);
        int CalcularMedalhasPrata(ICliente cliente);
        int CalcularMedalhasBronze(ICliente cliente);
        double CalcularDesconto(ICliente cliente);
    }
}