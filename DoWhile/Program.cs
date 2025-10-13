// See https://aka.ms/new-console-template for more information
string kasutajanimi = "";
do
{
    Console.WriteLine("Palun sisesta oma kasutajanimi");
    kasutajanimi = Console.ReadLine();
}
while (kasutajanimi != "user1");
if (kasutajanimi == "user1")
{
    int ruudusuurus = 0;
    
    do
    {
        Console.WriteLine("Kui suurt ruutu tahad?");
        ruudusuurus = int.Parse(Console.ReadLine());
    } while (ruudusuurus < 0 && ruudusuurus > 20);
    char reakujund = 'r';
    string üksrida = "";
    int tsüklimuutuja = ruudusuurus;
    do
    {
        üksrida += "_"+reakujund;
        tsüklimuutuja -= 1;
    } while (tsüklimuutuja != 0);
    tsüklimuutuja = ruudusuurus;
    do
    {
        Console.WriteLine(üksrida);
        tsüklimuutuja -= 1;
    } while (tsüklimuutuja != 0);
}