using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tradutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradutor.Tests
{
    [TestClass()]
    public class TradutorTests
    {
        private Tradutor t;
        [TestInitialize]
        public void TradutorInit()
        {
            t = new Tradutor();
        }
        [TestMethod()]
        public void TradutorSemPalavras()
        {
            Assert.IsTrue(t.isEmpty());
        }
        [TestMethod()]
        public void UmaTraducao()
        {
            t.addTranslation("bom", "good");
            Assert.IsFalse(t.isEmpty());
            Assert.AreEqual("good", t.traduzir("bom"));
        }
        [TestMethod()]
        public void DuasTraducoes()
        {
            t.addTranslation("bom", "good");
            t.addTranslation("mau", "bad");
            Assert.AreEqual("good", t.traduzir("bom"));
            Assert.AreEqual("bad", t.traduzir("mau"));
        }
        [TestMethod()]
        public void DuasTraducoesMesmaPalavra()
        {
            t.addTranslation("bom", "good");
            t.addTranslation("bom", "nice");
            Assert.AreEqual("good, nice", t.traduzir("bom"));
        }
        [TestMethod()]
        public void TraduzirFrase()
        {
            t.addTranslation("Guerra", "War");
            t.addTranslation("é", "is");
            t.addTranslation("ruim", "bad");
            Assert.AreEqual("War is bad", t.traduzirFrase("Guerra é ruim"));
        }
        [TestMethod()]
        public void TraduzirFraseCom2TraducoesMesmaPalavra()
        {
            t.addTranslation("paz", "peace");
            t.addTranslation("é", "is");
            t.addTranslation("bom", "good");
            t.addTranslation("bom", "nice");
            Assert.AreEqual("peace is good", t.traduzirFrase("paz é bom"));
        }
    }
}

















