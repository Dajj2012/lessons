Console.Clear();
Console.WriteLine("Введите число один");
int n =  int.Parse(Console.ReadLine());

if (n>999 || n<100)
    Console.WriteLine("ВВеденное число не трехзначное");
else
{
   Console.WriteLine((n/10)%10);
   
}