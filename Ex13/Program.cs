Console.Clear();
Console.WriteLine("Введите число ");
int n =  int.Parse(Console.ReadLine());
int i=1;
int summ=0;
while (n>Math.Pow(10,i))
{
i++;
}
for (int j =1; j<= i; j++)
{
    summ=summ+n%10;
    n=n/10;
}
Console.WriteLine(summ);