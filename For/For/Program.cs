//Console.WriteLine("For tsükkel");

//int kogus = 5;

//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("0");
//    Console.Beep();
//}

//string[] objectArray = new string[5]; // array, massiiv mitmest elemendist
//int objectCount = 0; // loed kui palju kordi küsida
//string temp = "no name"; // muutuja mis hetkel on "tühi"
//while (objectCount < 5) // while tsükkel mis küsib nimesid
//{
//    Console.WriteLine("Sisesta järgmine lemmikloomanimi:");
//    temp = Console.ReadLine(); // temp muutujasse väärtuse (mida me tahame) sisestamine
//    objectArray[objectCount] = temp; // massiivi, asukohal objectCount asetame ajutisest muutujast väärtuse
//    objectCount++; // tsükli inkrementatsioon
//}
//Console.WriteLine("Oled sisestanud järgmised objektid"); // sõnum
//for (int i = 0; i < objectArray.Length; i++)
//{
//    Console.WriteLine($"{i + 1}. element on: {objectArray[i]}");
//    // kuvame välja reanumbri koos vastava elemendiga, muutuja i abil
//}
//Console.ReadLine(); // peatame programmi klahvisisestuse taha

// kirjuta programm mis küsib kasutajalt tema nime ja parooli
// kui parool on vale, anna nimeline teavitus
// kui nimi on vale, ütle et isik pole registreerunud
// tekita massiiv suurusega 3
// kui mõtlemad on õiged, siis while tsüklis küsi kasutajalt tema 3 lemmikloomanime
// kuva talle sisestuste arv (mitu ta sisestas)
// ning küsi milline on ta lemmikuim
// tagasta kasutajale lause koos selle lemmiknimega adresseerides seda järjendist[]


Console.WriteLine("Mis on sinu kasutaja nimi?");
string kasutajanimi = Console.ReadLine();

if (kasutajanimi != "kris")
{
    do
    {
        Console.WriteLine("Sa ei ole registreeritud");
        kasutajanimi = Console.ReadLine();
    } while (kasutajanimi != "kris");
}
Console.WriteLine("Mis on sinu Parool?");

string parool = Console.ReadLine(); ;
if (parool != "1234")
{
    do
    {
        Console.WriteLine("See on vale parool");
        parool = Console.ReadLine();
    } while (parool != "1234");
}

string[] nimed = new string[3];
int sisestustearv = 0;
while (sisestustearv < 3)
{
    Console.WriteLine("Palun sisesta oma lemmikloomade nimed");
    nimed[sisestustearv] = Console.ReadLine();
    sisestustearv++;
}
Console.WriteLine($"Sa oled sisestanud {sisestustearv} nime");
Console.WriteLine("Milline on sinu lemmikuim?");
string lemmiknimi = Console.ReadLine();
for (int valik = 0; valik < nimed.Length; valik++)
{
    if (lemmiknimi == nimed[valik])
    {
        Console.WriteLine($"Sinu lemmikuim on {lemmiknimi}, see oli {valik + 1}. looma nimi");
    }
    
}