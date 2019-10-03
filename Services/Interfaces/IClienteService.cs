
using System.Collections.Generic;
using SqImport.Domain.Interfaces;

namespace SqImport.Services.Interfaces
{
    public interface IClienteService
    {
        IEnumerable<ICliente> ObterClientesDeTxt(string caminhoTxt);
        void BeginTransaction();
        void Commit();
        void Rollback();
        void Inserir(ICliente cliente);
        void Atualizar(ICliente cliente);
        ICliente ObterPorId(int identificadorERP);
        IEnumerable<ICliente> Listar();
        int CalcularIdade(ICliente cliente);
    }
}