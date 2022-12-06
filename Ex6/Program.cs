Console.Clear();
Console.WriteLine("Введите число один");
int n =  int.Parse(Console.ReadLine());
while (n>999)
    n=n/10;
if (n<100)
Console.WriteLine("Третьей цифры нет в данном числе");
else
Console.WriteLine(n%10);