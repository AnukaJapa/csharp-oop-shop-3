using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class SacchettoDiFrutta : Prodotto
    {
        private List<string> listaDellaFrutta;
        public SacchettoDiFrutta(int prezzo, int iva, List<string>listaDellaFrutta, string nome = "prodotto") : base(prezzo, iva, nome)
        {
            AggiungiListaDellaFrutta(listaDellaFrutta);
        }



        //GETTERS
        public List<string> GetFruttaLista()
        {
            return this.listaDellaFrutta;
        }

        //SETTERS
        public void AggiungiFruttaAllaLista(string frutta)
        {
            if(listaDellaFrutta.Count == 5)
            {
                Console.WriteLine("Non puoi aggiungere più frutta alla lista perchè sacchetto può contenere solo 5 frutta");
            } else
            {
                listaDellaFrutta.Add(frutta);
            }
        }

        private void AggiungiListaDellaFrutta(List<string>listaFrutta)
        {
            if (listaFrutta.Count > 5)
            {
                Console.WriteLine("non puoi aggiungere al sacchetto una lista della frutta contenente più dui 5 frutta!");

                for (int i = listaFrutta.Count -1; i>=5; i--)
                {
                    listaFrutta.RemoveAt(i);
                }

                this.listaDellaFrutta = listaFrutta;

            } else
            {
                this.listaDellaFrutta = listaFrutta;
            }
             

        }
        private string elencareListaFrutta()
        {
            string lista = "";
            foreach(string frutta in this.listaDellaFrutta)
            {
                lista += frutta + "\n              ";
            }
            return lista;
        }
        public override void StampaProdotto()
        {
            int prezzoSenzaIva = this.prezzo;
            int prezzoConIva = this.GetPrezzoConIva();


            this.descrizione = $@" 
-----------------------------------------------------
    nome del Prodotto: {this.nome + this.codice}
    codice: {this.codice}
    prezzo del Prodotto: {prezzoSenzaIva}
    prezzo con Iva: {prezzoConIva}
    iva: {this.iva}

            Frutta che Contiene il Sacchetto : 

              {elencareListaFrutta()}
-----------------------------------------------------
";
            Console.WriteLine(descrizione);
        }

}

}
