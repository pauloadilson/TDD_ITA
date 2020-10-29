using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoCompras
{
    public interface IObservadorCarrinho
    {
        public void ProdutoAdicionado(string nome, int valor);
    }
}
