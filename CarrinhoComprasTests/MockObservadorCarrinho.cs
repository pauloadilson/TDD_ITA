using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarrinhoCompras;
using System;

namespace CarrinhoCompras.Tests
{
    public class MockObservadorCarrinho : IObservadorCarrinho
    {
        private string nomeRecebido;
        private int valorRecebido;
        public void ProdutoAdicionado(string nome, int valor)
        {
            nomeRecebido = nome;
            valorRecebido = valor;
        }

        internal void verificaRecebimentoProduto(string nomeEsperado, int valorEsperado)
        {
            Assert.AreEqual(nomeEsperado, nomeRecebido);
            Assert.AreEqual(valorEsperado, valorRecebido);
        }
    }
}