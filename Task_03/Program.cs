//  Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет



int InputInt(string enjoy)
{
    Console.WriteLine(enjoy);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int DayOfWeek = InputInt("Введите число от 1 до 7:");


if (DayOfWeek == 6 || DayOfWeek == 7)
{
    Console.WriteLine($"'{DayOfWeek}'  является выходным днём");
}
else
{
    Console.WriteLine($"'{DayOfWeek}' не является выходным днём");
}
