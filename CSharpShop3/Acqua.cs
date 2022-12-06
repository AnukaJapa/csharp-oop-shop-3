using CSharpShop3.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class Acqua : Prodotto
    {
        private static double galloneLitriRatio = 3.785;
        protected double litri;
        protected int ph;
        protected string sorgente;
        public Acqua(int prezzo, int iva, double litri, int ph, string sorgente, string nome = "prodotto") : base(prezzo, iva, nome)
        {
            SetLitri(litri);
            verificaPh(ph);
            this.sorgente = sorgente;

        }

        static void ConvertInGalloni(double litri)
        {
        double galloneAcqua = litri / galloneLitriRatio;
        }

        // GETTERS

        public string GetSorgente()
        {
            return this.sorgente;
        }
        public double GetLitri()
        {
            return this.litri;
        }

        public int GetPhAcqua()
        {
            return this.ph;
        }
        //SETTERS

        public void SetLitri(double litri)
        {

            if (litri > 1.5 || litri <= 0)
            {
                throw new Exception("Il prodotto Acqua non può avere come contenuto meno di 0 litri di acqua o più di 1.5 litri");
            }
            else
            {
                this.litri = litri;
            }

        }

        public void Bevi(double litriDaBere)
        {
            if (this.litri - litriDaBere > 0)
            {
                this.litri = litri - litriDaBere;
                throw new AcquaFinita("Acqua è finita");
            }
            else
            {
                this.litri = 0;
            }
        }

        public void Riempi(double litriDaRiempire)
        {
            if (this.litri + litriDaRiempire > 1.5)
            {
                this.litri = 1.5;
                throw new Exception("hai superato la capienza massima dell'acqua riempendo");
            }
            else
            {
                this.litri = this.litri + litriDaRiempire;
            }
        }

        public void Svuota()
        {
            this.litri = 0;
        }

        private void verificaPh(int ph)
        {
            if (ph < 0)
            {
                throw new Exception("ph non può essere minore di zero");

            } else if (ph >10)
            {
                throw new Exception("ph di acqua non può essere maggiore di 10");
            }
            else
            {
                this.ph = ph;
            }
        }

        public override void StampaProdotto()
        {
            double prezzoSenzaIva = this.prezzo;
            double prezzoConIva = this.GetPrezzoConIva();


            this.descrizione = $@" 
-----------------------------------------------------
    nome del Prodotto: {this.nome + this.codice}
    codice: {this.codice}
    prezzo del Prodotto: {prezzoSenzaIva}
    prezzo con Iva: {prezzoConIva}
    iva: {this.iva}
    litri contenuti : {this.litri}
    ph : {this.ph}
    sorgente : {this.sorgente}
-----------------------------------------------------
";
            Console.WriteLine(descrizione);
        }
    }
}
