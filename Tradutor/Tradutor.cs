using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradutor
{
    public class Tradutor
    {
        private Dictionary<string, string> traducoes = new Dictionary<string, string>();

        public bool isEmpty()
        {
            return traducoes.Count == 0;
        }

        public void addTranslation(string palavra, string traducao)
        {
            if (traducoes.ContainsKey(palavra))
                traducoes[palavra] += $", {traducao}";
            else
                this.traducoes.Add(palavra, traducao);
        }

        public string traduzir(string palavra)
        {
            return traducoes[palavra];
        }

        public string traduzirFrase(string frase)
        {
            string[] palavras = frase.Split(' ');
            string fraseTraduzida = "";
            foreach (string palavra in palavras)
            {
                string traducao = primeiraTraducao(palavra);
                //string traducao = primeiraTraducao(palavra);
                fraseTraduzida += $" {traducao}";
            }
            return fraseTraduzida.Trim();
        }

        private string primeiraTraducao(string palavra)
        {
            return traducoes[palavra].Split(',')[0];
        }

        //private string primeiraTraducao(string palavra)
        //{
        //    string traducao = traducoes[palavra];
        //    if (traducao.Contains(','))
        //        traducao = traducao.Substring(0, traducao.IndexOf(','));
        //    return traducao;
        //}

    }
}
