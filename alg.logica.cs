//^ Задание 1:
//^ Магазин хранит о клиентах следующую информацию:
//^ - Имя;
//^ - Возраст;
//^ - Количество заказов;
//^ - Суммы потраченных средств.
//^ Магазин предлагает постоянным клиентам и клиентам старше 60 лет скидку.
//^ Клиент считается постоянным, если он произвел 4 или более заказов общей суммой от 5000.
//^ Напишите программу, которая будет получать на вход данные о клиенте и возвращать на консоль информацию о том получает ли клиент скидку или нет.

/* Console.WriteLine("Ваше имя");
string name = Console.ReadLine();

Console.WriteLine("Ваш возраст");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество заказов");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Потраченная сумма за заказы");
int sum = Convert.ToInt32(Console.ReadLine());


if (age >= 60 && (number >= 4 || sum >= 5000))
{
	Console.WriteLine("Ваша скидка больше 95%");
}
else
{
	Console.WriteLine("Вы не подходите по акцию");
}
 */

// ^Задание 2:
//^ Курьерская служба принимает в работу в качестве малогабаритного отправления только заказы соответствующие следующим условиям:
//^ - Сумма длины, ширины и высоты отправления не превышает 150см;
//^ - Ни одно из измерений не превышает 100см;
//^ - Масса отправления не превышает 10кг;
//^ - Расстояние доставки находится в диапазоне от 3 до 10км.
//^ Напишите программу, которая будет получать от пользователя данные об отправлении и сообщать, является ли оно малогабаритным.
//^ length , width, height

/* Console.WriteLine("Введите длину в см");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ширину в см");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите высоту в см");
int height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите массу в кг");
int weight = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите расстояние");
int distance = Convert.ToInt32(Console.ReadLine());

int sum = length + width + height;

if (length <= 99 && width <= 99 && height <= 99 && weight <= 10 && 3 < distance && 10 > distance && sum < 150)
{
	Console.WriteLine("Да");
}
else
{
	Console.WriteLine("Нет");
} */


//^ Задание 3:
//^ Напишите программу, которая получает от пользователя 3 числа (среднегодовую температуру в различных странах) и выводит их на консоль в порядке убывания.

Console.WriteLine("Введите среднегодовую температуру 1");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите среднегодовую температуру 2");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите среднегодовую температуру 3");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && b > c)
{
	Console.WriteLine("{0}, {1}, {2}", a, b, c);
}

if (a < b && b < c)
{
	Console.WriteLine("{0}, {1}, {2}",  c, b, a);
}

if (c > a && a > b)
{
	Console.WriteLine("{0}, {1}, {2}", c, a, b);
}

if (b > a && a > c)
{
	Console.WriteLine("{0}, {1}, {2}", b, a, c);
}

if (b > c && c > a)
{
	Console.WriteLine("{0}, {1}, {2}", b, c, a);
}

if (a > c && c > b)
{
	Console.WriteLine("{0}, {1}, {2}", a, c, b);
}