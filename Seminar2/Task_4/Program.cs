﻿// Напишите программу, на входе число любой разрядности, удаляет вторую цифру этого числа.
// Доделать!
int numA = new Random().Next(100, 1000);
Console.WriteLine($"Ваше число {numA}");
int d = numA % 10;
int n = numA / 100;
Console.WriteLine($"{n}{d}");
