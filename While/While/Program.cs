//Console.WriteLine("Joonistan sulle kolmnurga:");
//int kolmnurgasuurus = int.Parse(Console.ReadLine());

//int i = 1;
//while (i <= kolmnurgasuurus)
//{
//    Console.WriteLine();
//    int j = 1;
//    while (j <= i)
//    {
//        Console.Write("_O");
//        j++;
//    }
//    i++;
//}

Console.WriteLine("Tere tulemast MobiFix parandusautomaati! Kuidas saame aidata?");
Console.WriteLine("0 - headaega\n 1 -tahan telefoni parandada");
int kasutajavalik = int.Parse(Console.ReadLine());
while(kasutajavalik < 0 && kasutajavalik > 1)
{
    Console.WriteLine("Palun tee oma valik, kirjutades vastav arv,");
    kasutajavalik = int.Parse(Console.ReadLine());
}
if (kasutajavalik == 0)
{
    Console.WriteLine("Headaega, tulge jälle");
}
else
{
    Console.WriteLine("Palun sisesta oma telefonimudel, mida parandada soovid:");
    Console.WriteLine("1-iphone\n2-Xiaomi\n3-Huawei\n4-Samsung");
    int kasutajatelefon = int.Parse(Console.ReadLine());
    while (kasutajatelefon < 1 && kasutajatelefon > 4)
    {
        kasutajatelefon = int.Parse(Console.ReadLine());
        Console.WriteLine("Palun tee oma valik, kirjutades vastav arv,");

    }
    switch (kasutajatelefon)
    {
        case 1:
            Console.WriteLine("Aitäh, oma iPhone saad tagasi 1 nädala pärast");
            break;
        case 2:
            Console.WriteLine("Aitäh, oma Xiaomi saad tagasi 2 kuu pärast");
            break;
        case 3:
            Console.WriteLine("Kahjuks me huaweid ei teeninda");
            break;
        case 4:
            Console.WriteLine("Aitäh, oma Samsungi saad tagasi 2 päeva pärast");
            break;
        default:
            break;
    }
    //Console.WriteLine("Kas soovid mõnda muud mudelit parandada?");
    //Console.WriteLine("0 - Jah\n1 - ei");
    //int kasutajateinevalik = 0;
    //while (kasutajateinevalik < 0 && kasutajateinevalik > 1)
    //{
    //    Console.WriteLine("Palun tee oma valik, kirjutades vastav arv,");
    //    kasutajateinevalik = int.Parse(Console.ReadLine());
    //}
    //if (kasutajateinevalik == 0)
    //{
    //    kasutajatelefon = kasutajateinevalik;
    }

}