﻿// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {num} равна {Summa(num)}");

int Summa(int num)
{
    int sum=0;
    for (int i = 1; i <= num; i++) sum += i;
    return sum;
}