//  Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6



int InputInt(string enjoy)
{
    Console.WriteLine(enjoy);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int num = InputInt("Введите произвольное число:");

int count = 0;
if (num >= 100 && num <= 999)
{
    int a = num % 10;
    Console.WriteLine($"Третья цифра числа: цифра {a}");
}
if (num >= 0 && num <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}

if (num >= 1000)
{
    while (num > 999)
    {
        num = num / 10;
    }
    count = num % 10;
    Console.WriteLine($"Третья цифра числа: цифра {count}");
}






