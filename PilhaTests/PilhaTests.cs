using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pilha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha.Tests
{
    [TestClass()]
    public class PilhaTests
    {
        private Pilha p;
        [TestInitialize]
        public void TestInit()
        {
            p = new Pilha(10);
        }
        [TestMethod()]
        public void EstaVaziaTest()
        {
            Assert.IsTrue(p.estaVazia());
            Assert.AreEqual(0, p.tamanho());
        }
        [TestMethod()]
        public void EmpilhaUmElementoTest()
        {
            p.empilha("primeiro");
            Assert.IsFalse(p.estaVazia());
            Assert.AreEqual(1, p.tamanho());
            Assert.AreEqual("primeiro", p.topo());
        }
        [TestMethod()]
        public void EmpilhaDesempilhaElementosTest()
        {
            p.empilha("primeiro");
            p.empilha("segundo");
            Assert.IsFalse(p.estaVazia());
            Assert.AreEqual(2, p.tamanho());
            Assert.AreEqual("segundo", p.topo());
            Object desempilhado = p.desempilha();
            Assert.AreEqual(1, p.tamanho());
            Assert.AreEqual("primeiro", p.topo());
            Assert.AreEqual("segundo", desempilhado);
        }
        [TestMethod()]
        [ExpectedException(typeof(PilhaVaziaExceptions), "A pilha está vazia, não é possível desempilhar.")]
        public void RemoveDaPilhaVazia()
        {
            Object desempilhado = p.desempilha();
        }
        [TestMethod()]
        //[ExpectedException(typeof(PilhaCheiaException), "A pilha está cheia, não é possível empilhar.")]
        public void AdicionaNaPilhaCheia()
        {
            for (int i =0; i < 10; i++)
                p.empilha($"elemento{i}");
            try
            {
                p.empilha("boom");
                Assert.Fail();
            }
            catch (PilhaCheiaException e)
            {
            }

        }

    }
}