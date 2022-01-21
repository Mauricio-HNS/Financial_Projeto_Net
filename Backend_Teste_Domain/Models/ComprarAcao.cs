using System;

namespace Backend_Teste_Domain.Models
{
    public class ComprarAcao
    {
        public int IdAcao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }

    }
}
