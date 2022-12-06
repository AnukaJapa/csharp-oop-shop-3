using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class Elettrodomestico : Prodotto
    {
        private int garantiaAnno;
        public Elettrodomestico(int prezzo,int iva, int garanziaAnno, string nome = "prodotto") : base(prezzo, iva, nome)
        {
            this.garantiaAnno = garanziaAnno;
        }

        public int GetGaranziaAnno()
        {
            return this.garantiaAnno;
        }
    }
}
