// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
for (int I = 1; I<=num; I++)
{
    if (I==num){Console.Write($"{Math.Pow(I, 3)}");}
    else Console.Write($"{Math.Pow(I, 3)}, ");
}
