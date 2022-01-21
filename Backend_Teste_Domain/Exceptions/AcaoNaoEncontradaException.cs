using System;

namespace Backend_Teste_Domain.Exceptions
{
    public class AcaoNaoEncontradaException : Exception
    {
        public AcaoNaoEncontradaException() : base("Código de Ação Inválido!!") { }
    }
}
