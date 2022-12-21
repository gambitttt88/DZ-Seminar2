/*Задача 1
Console.WriteLine("Введите любое трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if((number/1000 > 0) || (number/100 < 9))
{
    Console.WriteLine($"Вы ввели не верное число, введите число от 100 до 1000");
}
else
{
    Console.WriteLine($"Вторая цифра введенного числа {number/10%10}");
}*/

/*Задача 2
Console.WriteLine("Введите любое число до 100000: ");
int number = int.Parse(Console.ReadLine());
if(number < 100)
{
    Console.WriteLine($"В введенном числе нет 3-й цифры");
}
if(number > 100000)
{
    Console.WriteLine($"Введите число до 100000");
}
if((number > 99) && (number < 1000))
{
    Console.WriteLine($"3-я цифра {number%10}");
}
if((number > 999) && (number < 10000))
{
    Console.WriteLine($"3-я цифра {number%100/10}");
}
if((number > 9999) && (number < 100000))
{
    Console.WriteLine($"3-я цифра {number%1000/100}");
}
if(number == 100000)
{
    Console.WriteLine($"3-я цифра 0");
}*/

/*Задача 3*/
Console.WriteLine("Введите цифру дня недели, который хотите проверить: ");
int number = int.Parse(Console.ReadLine());
if((number < 1)||(number > 7))
{
    Console.WriteLine($"Нет такого дня недели, введите цифру от 1 до 7");
}
if((number >= 1) && (number <= 5))
{
    Console.WriteLine($"К сожалению этот день - рабочий");
}
if((number >= 6) && (number <= 7))
{
    Console.WriteLine($"Поздравляю - наконец-то выходной!!!");
}
