//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
{
System.Console.WriteLine("Четное");
}
else
{
System.Console.WriteLine("Нечетное");
}

