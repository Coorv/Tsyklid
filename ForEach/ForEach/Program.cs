string[] konsoolid = { "ps1", "nes", "n64" };

List<string> mängud = new List<string>();

//foreach (string konsool in konsoolid)
//{
//    Console.WriteLine(konsool);
//}

//for  (int i = 0; i < konsoolid.Length; i++)
//{
//    Console.WriteLine(konsoolid[i]);
//}

string currentEntry = "";

while (currentEntry == "")
{
    Console.WriteLine("Sisesta mäng, või kirjuta \"ei taha\" kui soovid esitust lõpetada");
    currentEntry = Console.ReadLine();
    if (currentEntry == "ei taha")
    {
        break;
    }
    mängud.Add(currentEntry);
    currentEntry = "";
}

foreach (var mäng in mängud)
{
    Console.WriteLine(mäng);
}

//kasutades ühte muud tsüklit ja/või ainult foreachi. küsi kasutajalt tema lemmikvärve 
//kui kasutaja sisestab ei oska öelda, kuva konsoolil, musta tekstiga ja lemmikvärvi taustavärviga,
//igal real üks tema lemmikvärvidest.

Console.WriteLine("Mis on su lemmikvärvid? Sisesta palun ükshaaval \nKui rohkem värve ei ole kirjuta \"rohkem pole\"");
List<string> kasutajavärvid = new List<string>();

string sisestus = "";
do
{
    Console.WriteLine("Sisesta 1 värv korraga:");
    sisestus = Console.ReadLine();
    if (sisestus != "rohkem pole")
    {
        kasutajavärvid.Add(sisestus);
    }
    
} while (sisestus != "rohkem pole");

foreach(var värv in kasutajavärvid)
{
    switch (värv)
    {
        case "punane":
            Console.BackgroundColor = ConsoleColor.Red; 
            break;
        case "roheline":
            Console.BackgroundColor = ConsoleColor.Green;
            break;
        case "sinine":
            Console.BackgroundColor = ConsoleColor.Blue;
            break;
        case "kollane":
            Console.BackgroundColor= ConsoleColor.Yellow;
            break;
        default:
            break;
    }
}