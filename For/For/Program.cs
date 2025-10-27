//Console.WriteLine("For tsükkel");

//int kogus = 5;

//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("0");
//    Console.Beep();
//}

string[] objectArray = new string[5];
int objectCount = 0;
string temp = "no name";
while (objectCount < 5)
{
    Console.WriteLine("Sisesta järgmine lemmikloomanimi:");
    temp = Console.ReadLine();
    objectArray[objectCount] =temp;
    objectCount++;
}
Console.WriteLine("Oled sisestanud järgmised objektid");
for (int i = 0; i < objectArray.Length; i++)
{
    Console.WriteLine($"{i+1}. element on: {objectArray[i]}");
}
Console.ReadLine();