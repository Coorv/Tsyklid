//1. ülesanne
string kasutajanimi = "";
int parool = 0;
if ( kasutajanimi == "")
{
    do
    {
        Console.WriteLine("Mis on sinu nimi?");
        kasutajanimi = Console.ReadLine();
    } while (kasutajanimi == "");
}


while (parool == 0)
{
    Console.WriteLine("Mis on sinu parool?");
    parool = int.Parse(Console.ReadLine());
    do
    {
        Console.WriteLine("parool peab olema neljakohaline");
    } while (parool < 1000 && parool > 9999);
}
string[] puuviljad = new string[5] {"a", "l", "p", "g", "f"}; 
for (int i = 0; i < puuviljad.Length; i++)
{
    Console.WriteLine("");
}