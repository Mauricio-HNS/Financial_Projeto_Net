namespace Backend_Teste_Domain.Models
{
    public class VendaAcaoCompleta : VendaAcao
    {
        public double ValorTotal { get; set; }
        private readonly double CustosCorretagem = 5.00;
        private readonly double Emolumentos = 0.0325;
        public VendaAcaoCompleta(VendaAcao acao)
        {
            this.IdAcao = acao.IdAcao;
            this.Preco = acao.Preco;
            this.Quantidade = acao.Quantidade;
            this.DataVenda = acao.DataVenda;
            this.ValorTotal = (this.Quantidade * this.Preco) + CustosCorretagem + (Emolumentos / 100 * (this.Quantidade * this.Preco));
        }
    }
}

