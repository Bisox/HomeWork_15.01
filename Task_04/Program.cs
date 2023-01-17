// Задача 4 * : Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.


int num = new Random().Next(100, 999);


int c = num / 10 % 10;
int b = num % 10;
int a = num / 10;

Console.WriteLine(num);
Console.WriteLine((a - c) + b);



