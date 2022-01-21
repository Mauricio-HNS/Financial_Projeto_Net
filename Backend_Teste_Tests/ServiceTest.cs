using Backend_Teste_Domain.Exceptions;
using Backend_Teste_Domain.Interfaces;
using Backend_Teste_Domain.Models;
using Backend_Teste_Domain.Services;
using Moq;
using NUnit.Framework;
using System;

namespace Backend_Teste_Tests
{
    public class ServiceTest
    {
        private readonly Mock<IAcoesRepository> _repository;
        private readonly AcoesService _service;
        private readonly ComprarAcao _acaoCompra;
        private readonly VendaAcao _acaoVenda;

        public ServiceTest()
        {
            _repository = new Mock<IAcoesRepository>();
            _service = new AcoesService(_repository.Object);

            _acaoCompra = new ComprarAcao()
            {
                IdAcao = 1,
                Preco = 10.50,
                Quantidade = 5,
                DataCompra = DateTime.Now
            };

            _acaoVenda = new VendaAcao()
            {
                IdAcao = 1,
                Preco = 8.50,
                Quantidade = 2,
                DataVenda = DateTime.Now
            };
        }

        [Test]
        public void Should_Registrate_Buy()
        {
            _repository.Setup(s => s.VerificarSeAcaoExiste(It.IsAny<int>())).Returns(true);

            Assert.DoesNotThrow(() => _service.CompraAcao(_acaoCompra));
        }

        [Test]
        public void Invalid_Code_On_Buy()
        {
            _repository.Setup(s => s.VerificarSeAcaoExiste(It.IsAny<int>())).Returns(false);

            Assert.Throws<AcaoNaoEncontradaException>(() => _service.CompraAcao(_acaoCompra));
        }

        [Test]
        public void Should_Registrate_Sale()
        {
            _repository.Setup(s => s.VerificarSeAcaoExiste(It.IsAny<int>())).Returns(true);

            Assert.DoesNotThrow(() => _service.VendaAcao(_acaoVenda));
        }

        [Test]
        public void Invalid_Code_On_Sale()
        {
            _repository.Setup(s => s.VerificarSeAcaoExiste(It.IsAny<int>())).Returns(false);

            Assert.Throws<AcaoNaoEncontradaException>(() => _service.VendaAcao(_acaoVenda));
        }
    }
}
