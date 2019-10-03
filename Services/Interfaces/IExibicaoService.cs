using System.Collections.Generic;
using SqImport.Domain.Models;

namespace SqImport.Services.Interfaces
{
    public interface IExibicaoService
    {
        IEnumerable<RegioesExibicao> AgruparClientesExibicaoPorRegiao(IEnumerable<ClienteExibicao> clientes);
        void ExibirClientes(IEnumerable<ClienteExibicao> clientes);
        void ExibirSumarizadoPorRegiao(IEnumerable<RegioesExibicao> regioes);
    }
}