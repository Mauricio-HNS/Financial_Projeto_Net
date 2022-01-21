using System;

namespace Backend_Teste_Domain.Models
{
    public class VendaAcao
    {
        public int IdAcao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }

    }
}
