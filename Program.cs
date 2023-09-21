//Напишите программу, которая
//1. на вход принимает число (N), а
//2. На выходе показывает все четные числа от 1 до N
//3. вывод результата

//Например
//5 -> 2,4
//8 -> 2,4,6,8

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int even = 2;
while (num >= even)
{
Console.Write(even + " ");
even = even + 2;
}
