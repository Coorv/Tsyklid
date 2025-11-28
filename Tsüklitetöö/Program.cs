//1. ülesanne

string kasutajanimi = "";
if ( kasutajanimi == "")
{
    do
    {
        Console.WriteLine("Mis on sinu nimi?");
        kasutajanimi = Console.ReadLine();
    } while (kasutajanimi == "");
}

//2. ülesanne

Console.WriteLine("Mis on sinu parool?");
int parool = 0;
parool = int.Parse(Console.ReadLine());
while (parool < 1000 && parool < 9999)
{
    Console.WriteLine("parool peab olema neljakohaline");
    parool = int.Parse(Console.ReadLine());
}

//3. ülesanne

List<string> puuviljad = new List<string>{"Õun", "Apelsiin", "Banaan", "Lemon", "Pirn"}; 
for (int i = 0; i < puuviljad.Count; i++)
{
    Console.WriteLine($"{ i + 1 }. vili on: {puuviljad[i]}");
}

//4. ülesanne

int[] arvud = { 1, 2, 3, 5, 6 };
foreach (int arvudloendis in arvud)
{
    int korrutus = arvudloendis * arvudloendis;
    Console.WriteLine(korrutus);
}