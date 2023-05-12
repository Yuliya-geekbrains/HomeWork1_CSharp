// Напишите программу, которая на вход принимает три числа и выдает max из этих чисел 

Console.WriteLine("Введите число а");
Console.WriteLine("Введите число b");
Console.WriteLine("Введите число c");


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;


if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
