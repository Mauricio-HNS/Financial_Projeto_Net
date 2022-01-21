using Backend_Teste_Domain.Models;

namespace Backend_Teste_Domain.Interfaces
{
    public interface IAcoesRepository
    {
        void CadastrarAcao(NovaAcao acao);
        void CompraAcao(ComprarAcaoCompleta acao);
        bool VerificarSeAcaoExiste(int idAcao);
        void VendaAcao(VendaAcaoCompleta acao);
    }
}
