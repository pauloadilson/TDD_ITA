using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class Pilha
    {
        private Object[] elementos;
        
        private int quantidade = 0;

        public Pilha(int maximo)
        {
            elementos = new Object[maximo];
        }

        public bool estaVazia()
        {
            return this.quantidade == 0;
        }

        public int tamanho()
        {
            return quantidade;
        }

        public void empilha(Object elemento)
        {
            if (quantidade == elementos.Length)
                throw new PilhaCheiaException("A pilha está cheia, não é possível empilhar.");
            this.elementos[quantidade] = elemento;
            quantidade++;
        }

        public Object topo()
        {
            return elementos[quantidade - 1];
        }

        public object desempilha()
        {
            if (estaVazia())
                throw new PilhaVaziaExceptions("A pilha está vazia, não é possível desempilhar.");
            Object topo = this.topo();
            quantidade--;
            return topo;
        }
    }
}
