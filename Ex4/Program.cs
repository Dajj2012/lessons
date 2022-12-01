Console.Clear();
Console.WriteLine("Введите число один");
int n =  int.Parse(Console.ReadLine());
int index=0;
while (index<=n)
{
    if (index % 2 == 0) Console.WriteLine(index);
    index++;

}
