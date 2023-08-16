// Задание 1:
// Напишите часть программы регистрации аккаунта.
// Пользователь вводит пароль и затем повторяет его.
// Если пароли совпадают выведите на консоль сообщение о успешной регистрации. Если нет - сообщение об ошибке.

        Console.WriteLine("Введите пароль");
        int firstPassword = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Повторите пароль");
        int secondPassword = Convert.ToInt32(Console.ReadLine());

        if (firstPassword==secondPassword)
        {
            Console.WriteLine("Пароль верный");
        }
        else 
        {
            Console.WriteLine("Пароли не совпадают");
        }


// Задание 2:
// В ресторане находится несколько видов посадочных мест:
// 1. Маленький стол - до 2-х человек;
// 2. Средний стол - до 4-х человек;
// 3. Большой стол - до 8-и человек.
// Компанию более 8-и человек ресторан разместить не сможет(
// Напишите программу, которая будет получать от пользователя количество гостей и предлагать наиболее подходящий стол.

Console.WriteLine("Введите количесство гостей");
int numberGuests = Convert.ToInt32(Console.ReadLine());

if (numberGuests <=2)
{
    Console.WriteLine("Маленький стол - до 2-х человек");
}

else if (numberGuests <=4)
{
    Console.WriteLine("Средний стол - до 4-х человек");
}

else if (numberGuests <=8)
{
    Console.WriteLine("Большой стол - до 8-и человек");
}


// Задание 3:
// Напишите программу, которая получает от пользователя 3 числа (среднегодовую температуру в различных странах) и выводит их на консоль в порядке убывания.

Console.WriteLine("Среднегодовой температура вашей страны");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Среднегодовой температура вашей страны");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Среднегодовой температура вашей страны");
int c = Convert.ToInt32(Console.ReadLine());


if (a<b)
{
    if (b<c)
    Console.WriteLine("{0}, {1}, {2}", c, b, a);
    else 
    {
        if (a<c)
            Console.WriteLine("{0}, {1}, {2}", b, c, a);
        else
             Console.WriteLine("{0}, {1}, {2}", b, a, c);
    }
}
else
{
     if (c < b)
        Console.WriteLine("{0}, {1}, {2}", a, b, c);
     else
    {
        if(a < c)
             Console.WriteLine("{0}, {1}, {2}", c, a, b);
        else
             Console.WriteLine("{0}, {1}, {2}", a, c, b);
    }
}
