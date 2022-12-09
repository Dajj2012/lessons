Console.Clear();
Console.WriteLine("Введите число ");
int n =  int.Parse(Console.ReadLine());
Console.WriteLine("Введите Степень ");
int m =  int.Parse(Console.ReadLine());
int res =n;
if (m==0)
{
    Console.WriteLine("1");
    return;
}
for (int i =2; i<= m; i++)
    {
     res=res*n;
    }
Console.WriteLine(res);
