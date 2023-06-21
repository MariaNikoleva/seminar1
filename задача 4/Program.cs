//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
{
System.Console.WriteLine($"Максимальное число: {numberA}");
}
if (numberB > numberA && numberB > numberC)
{
System.Console.WriteLine($"Максимальное число: {numberB}");
}
if (numberC > numberA && numberC > numberB)
{
System.Console.WriteLine($"Максимальное число: {numberC}");
}