// See https://aka.ms/new-console-template for more information

using CSharpShop2;
Acqua acqua1 = new Acqua(2, 50, 0.6, 10, "italia");
CiboInScatola tonno = new CiboInScatola(3, 50, 200, "tonno");

List<string> listaDellaFrutta = new List<string>()
{
    "Banana",
    "Mela",
    "kiwi",
    "Pera",
    "Papaya",
    "Mirtilli",
    "banana",
    "Mela",
    "Ananas",
    "Pesca"
};

SacchettoDiFrutta sacchettoFrutta1 = new SacchettoDiFrutta(2, 50, listaDellaFrutta);

//sacchettoFrutta1.StampaProdotto();
acqua1.Bevi(1);
acqua1.Riempi(2);
acqua1.SetLitri(3);

//acqua1.StampaProdotto();
tonno.StampaProdotto();
Console.WriteLine();
