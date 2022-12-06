using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class Prodotto
    {
        protected int codice;
        protected string nome;
        protected string descrizione;
        protected double prezzo;
        protected int iva;

        public Prodotto(int prezzo, int iva, string nome = "prodotto")
        {
            this.nome = nome;
            this.codice = GeneraCodice();
            this.prezzo = prezzo;
            this.iva = iva;
        }
        
        public int GetCodice()
        {
            return this.codice;
        }

        public double GetPrezzoSenzaIva()
        {
            return this.prezzo;
        }

        public virtual void StampaProdotto()
        {
            double prezzoSenzaIva = this.prezzo;
            double prezzoConIva = this.GetPrezzoConIva();


            this.descrizione = $@" 
-----------------------------------------------------
    nome del Prodotto: {this.nome + PadMethod()}
    codice: {PadMethod()}
    prezzo del Prodotto: {prezzoSenzaIva}
    prezzo con Iva: {prezzoConIva}
    iva: {this.iva}
-----------------------------------------------------
";
            Console.WriteLine(descrizione);
        }

        public string GetNome()
        {
            return nome;
        }
        public int GetIva()
        {
            return iva;
        }

        public void SetNome(string nome)
        {

            this.nome = nome;
        }

        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }

        public void SetIva(int iva)
        {
            this.iva = iva;
        }

        public double GetPrezzoConIva()
        {
            double prezzoConIva = this.prezzo + (this.prezzo * this.iva / 100);
            return prezzoConIva;
        }

        public string GetNomeEsteso()
        {
            return nome + codice;
        }

        public string PadMethod()
        {
            string codiceStringaPad = this.codice.ToString();

            for (int i = codiceStringaPad.Length; i < 8; i++)
            {
                codiceStringaPad = "0" + codiceStringaPad;
            }
            return codiceStringaPad;
        }

        private int GeneraCodice()
        {
            Random numeroRandom = new Random();
            return numeroRandom.Next(1, 1000);
        }

    }
}

