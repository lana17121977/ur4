﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int ost = i % 10;
i = i / 10;
sum = sum + ost;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
