using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoCompras
{
    public class CarrinhoCompras
    {
        public List<Produto> itens = new List<Produto>();
        private List<IObservadorCarrinho> observadores = new List<IObservadorCarrinho>();

        public void adicionaProduto(Produto p)
        {
            itens.Add(p);
            foreach (IObservadorCarrinho observador in observadores) { 
                try
                {
                    observador.ProdutoAdicionado(p.Nome, p.Valor);
                } catch (Exception) { }
            }
        }
        public int total()
        {
            int total = 0;
            foreach (Produto p in itens)
                total += p.Valor;
            return total;
        }

        public void adicionarObservador(IObservadorCarrinho observador)
        {
            observadores.Add(observador);
        }
    }
}
