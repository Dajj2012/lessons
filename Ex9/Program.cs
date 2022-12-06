Console.Clear();
Console.WriteLine("Введите N ");
int n =  int.Parse(Console.ReadLine());
int i=1;
while (i<n+1)
{
    Console.WriteLine(Math.Pow(i,3));
    i++;
}