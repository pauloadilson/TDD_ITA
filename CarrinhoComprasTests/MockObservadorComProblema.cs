using CarrinhoCompras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoComprasTests
{
    public class MockObservadorComProblema : IObservadorCarrinho
    {
        public void ProdutoAdicionado(string nome, int valor)
        {
            throw new Exception("Simulado pelo mock");
        }

                

    }
}
