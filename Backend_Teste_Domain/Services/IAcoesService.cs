using Backend_Teste_Domain.Interfaces;
using Backend_Teste_Domain.Models;

namespace Backend_Teste_Domain.Services
{
    public interface IAcoesService
    {
        void CadastroAcoes(NovaAcao request);
        Cotacao CotacaoAcao();
        void ComprarAcao(ComprarAcao request);
        void VendaAcao(VendaAcao request);
    }
}
