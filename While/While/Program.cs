Console.WriteLine("Joonistan sulle kolmnurga:");
int kolmnurgasuurus = int.Parse(Console.ReadLine());

int i = 1;
while (i <= kolmnurgasuurus)
{
    Console.WriteLine();
    int j = 1;
    while (j <= i)
    {
        Console.Write("_O");
        j++;
    }
    i++;
}