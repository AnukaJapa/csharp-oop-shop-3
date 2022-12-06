// See https://aka.ms/new-console-template for more information

using CSharpShop2;
using CSharpShop3.Exceptions;

try
{
    Acqua acqua1 = new Acqua(2, 50, 1.3, 5, "italia");
    //CiboInScatola tonno = new CiboInScatola(3, 50, 100, "tonno");

    List<string> listaDellaFrutta = new List<string>()
{
    "Banana",
    "Mela",
    "kiwi",
    "Pera",
};

    SacchettoDiFrutta sacchettoFrutta1 = new SacchettoDiFrutta(2, 50, listaDellaFrutta);

    //sacchettoFrutta1.StampaProdotto();
    //acqua1.Bevi(100);
    //acqua1.Riempi(45);
    //acqua1.SetLitri(3);

    acqua1.StampaProdotto();
    //tonno.StampaProdotto();
    Console.WriteLine(Prodotto.contatoreProdottiInstanziati);

} catch(AcquaFinita e)
{
    Console.WriteLine(e.Message);

}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

