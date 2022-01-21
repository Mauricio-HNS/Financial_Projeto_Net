using Backend_Teste_Domain.Exceptions;
using Backend_Teste_Domain.Interfaces;
using Backend_Teste_Domain.Models;
using System;

namespace Backend_Teste_Domain.Services
{
    public class AcoesService : IAcoesService
    {
        public readonly IAcoesRepository _repository;


        public AcoesService(IAcoesRepository repository)
        {
            _repository = repository;
        }

        public void CadastroAcoes(NovaAcao acao)
        {
            _repository.CadastrarAcao(acao);
        }

        public void CompraAcao(ComprarAcao request)
        {
            var acaoExiste = _repository.VerificarSeAcaoExiste(request.IdAcao);

            if (!acaoExiste)
            {
                throw new AcaoNaoEncontradaException();
            }

            var acao = new ComprarAcaoCompleta(request);

            _repository.CompraAcao(acao);
        }

        public void ComprarAcao(ComprarAcao request)
        {
            throw new NotImplementedException();
        }

        public Cotacao CotacaoAcao()
        {
            return new Cotacao();
        }

        public void VendaAcao(VendaAcao request)
        {
            var acaoExiste = _repository.VerificarSeAcaoExiste(request.IdAcao);

            if (!acaoExiste)
            {
                throw new AcaoNaoEncontradaException();
            }

            var acao = new VendaAcaoCompleta(request);

            _repository.VendaAcao(acao);
        }
    }
}
