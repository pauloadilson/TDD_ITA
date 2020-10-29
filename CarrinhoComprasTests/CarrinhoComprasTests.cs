using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarrinhoCompras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrinhoComprasTests;

namespace CarrinhoCompras.Tests
{
    [TestClass()]
    public class CarrinhoComprasTests
    {
        /*
        [TestMethod()]
        public void adicionaProdutoTest()
        {
            throw new NotImplementedException();
        } */

        [TestMethod()]
        public void totalCarrinhoTest()
        {
            CarrinhoCompras c = new CarrinhoCompras();
            c.adicionaProduto(new Produto("tenis", 100));
            c.adicionaProduto(new Produto("camiseta", 50));
            c.adicionaProduto(new Produto("bermuda", 70));
            Assert.AreEqual(220, c.total());
        }
        [TestMethod()]
        public void escutaAdicaoDeProduto()
        {
            CarrinhoCompras c = new CarrinhoCompras();
            MockObservadorCarrinho mock = new MockObservadorCarrinho();
            c.adicionarObservador(mock);
            c.adicionaProduto(new Produto("tenis", 100));
            mock.verificaRecebimentoProduto("tenis", 100);
        }
        [TestMethod()]
        public void AdicionarDoisObservadores()
        {
            CarrinhoCompras c = new CarrinhoCompras();
            MockObservadorCarrinho mock1 = new MockObservadorCarrinho();
            MockObservadorCarrinho mock2 = new MockObservadorCarrinho();
            c.adicionarObservador(mock1);
            c.adicionarObservador(mock2);
            c.adicionaProduto(new Produto("tenis", 100));
            mock1.verificaRecebimentoProduto("tenis", 100);
            mock2.verificaRecebimentoProduto("tenis", 100);

        }
        [TestMethod()]
        public void ContinuaNotificandoComErroEmObservador()
        {
            CarrinhoCompras c = new CarrinhoCompras();
            MockObservadorCarrinho mock1 = new MockObservadorCarrinho();
            IObservadorCarrinho mock2 = new MockObservadorComProblema();
            MockObservadorCarrinho mock3 = new MockObservadorCarrinho();
            c.adicionarObservador(mock1);
            c.adicionarObservador(mock2);
            c.adicionarObservador(mock3);
            c.adicionaProduto(new Produto("tenis", 100));
            mock1.verificaRecebimentoProduto("tenis", 100);
            mock3.verificaRecebimentoProduto("tenis", 100);

        }
    }
}