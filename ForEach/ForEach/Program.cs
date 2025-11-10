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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" p   u   n   a   n   e   ");
            break;
        case "roheline":
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" r   o   h   e   l   i   n   e ");
            break;
        case "sinine":
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" s   i   n   i   n   e ");
            break;
        case "kollane":
            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine(" k   o   l   l   a   n   e ");
            break;
        case "helesinine":
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" h   e   l   e   s   i   n   i   n   e ");
            break;
        case "lilla":
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" l   i   l   l   a ");
            break;
        case "oranz":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Kahjuks pole oranz saadaval");
            break;
        case "roosa":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Kahjuks pole roosa saadaval");
            break;
        case "must":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" m   u   s   t ");
            break;
        case "valge":
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" v   a   l   g   e ");
            break;
        case "tumesinine":
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" t   u   m   e   s   i   n   i   n   e ");
            break;
        case "pruun":
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" p   r   u   u   n ");
            break;
        case "hall":
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" h   a   l   l ");
            break;
        default:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Sellist värvi ei tunne {värv}");
            break;
    }
}