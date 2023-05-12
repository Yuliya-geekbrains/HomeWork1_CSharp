// Напишите программу которая на вход принимает два числа и выдает какое число больше какое меньше

Console.WriteLine("Введите число а");
Console.WriteLine("Введите число b");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write("max = ");
    Console.Write(a);
}
else 
{Console.Write("max = ");
Console.Write(b);}

