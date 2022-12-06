using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    internal class CiboInScatola : Prodotto
    {
        private int pesoInGrammi;
        public CiboInScatola(int prezzo, int iva, int pesoInGrami, string nome = "prodotto") : base(prezzo, iva, nome)
        {
            setPeso(pesoInGrammi);
        }
        //GETTERS
        public int getPeso() { 

            return pesoInGrammi;
        }

        //SETTERS
        public void setPeso(int pesoInGrammi)
        {
            if(pesoInGrammi <= 300 && pesoInGrammi >0)
            {
                this.pesoInGrammi = pesoInGrammi;

            }else
            {
                Console.WriteLine("Peso non può essere inferiore a 0 grammo o superiore a 300 grammi");
            }
        }
    }
}
