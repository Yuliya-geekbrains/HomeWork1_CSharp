// напишите программу, которая на вход принимает число и выдает, является ли число чётным 
//(делится ли она на 2 без остатка)

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{Console.WriteLine(a);}
else
{Console.WriteLine("Число нечетное");}


