using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Teste_Domain.Models
{
    public class ComprarAcaoCompleta : ComprarAcao
    {
        public double ValorTotal { get; set; }
        private readonly double CustosCorretagem = 5.00;
        private readonly double Emolumentos = 0.0325;

        public ComprarAcaoCompleta(ComprarAcao acao)
        {
            this.IdAcao = acao.IdAcao;
            this.Preco = acao.Preco;
            this.Quantidade = acao.Quantidade;
            this.DataCompra = acao.DataCompra;
            this.ValorTotal = (this.Quantidade * this.Preco) + CustosCorretagem + (Emolumentos / 100 * (this.Quantidade * this.Preco));
        }
    }
}
