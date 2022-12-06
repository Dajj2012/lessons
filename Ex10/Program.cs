Console.Clear();
Console.WriteLine("Введите N ");
string n =  Console.ReadLine();
if (n.Length != 5) 
{
    Console.WriteLine("Введите пятизначное число ");
    n =  Console.ReadLine();
}
if (n[0]==n[4] && n[1]==n[3] )
    Console.WriteLine("Палиндром ");
else
    Console.WriteLine("Непалиндром ");
