﻿int[] numbers = new int[10];
Random rnd = new Random();

int sum = 0;

for (int i = 0, i < numbers.Length + 1) ;
{
    numbers[i] = rnd.Next(1, numbers.Length + 1);
    sum = sum + numbers[i];
}

foreach (int numbers in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Total: {sum}");