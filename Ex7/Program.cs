Console.Clear();
Console.WriteLine("Введите число дня недели");
int n =  int.Parse(Console.ReadLine());
if (n>7 || n<1)
Console.WriteLine("в неделе 7 дней только");
if (n==6 || n==7)
Console.WriteLine("Yes");
if (n<6 && n>0)
Console.WriteLine("No");