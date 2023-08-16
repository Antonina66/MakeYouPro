// Задание 1:
// Напишите часть программы регистрации аккаунта.
// Пользователь вводит пароль и затем повторяет его.
// Если пароли совпадают выведите на консоль сообщение о успешной регистрации. Если нет - сообщение об ошибке.

// Console.WriteLine("Введите пароль");
// int firstPassword = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Повторите пароль");
// int secondPassword = Convert.ToInt32(Console.ReadLine());

if (firstPassword == secondPassword)
{
	Console.WriteLine("Пароли совпадают");
}
if (firstPassword != secondPassword)
{
	Console.WriteLine("Пароли не совпадают");
}

// Задание 2:
// Позиция товара в чеке интернет магазина описывается следующими значениями:
// - Название;
// - Цена за единицу;
// - Количество;
// - Участвует в акции (да/нет).
// Напишите программу, которая получает перечисленные значения и вычисляет сумму по следующему правилу:
// Если количество товара в чеке больше либо равно 5, то к товару применяется скидка в 10%. Если товар учувствует в акции - применяется скидка в 15%. Скидки могут суммироваться.
string productName;
Console.WriteLine("Введите название продукта");
productName = Console.ReadLine();

Console.WriteLine("Введите цену продукта");
int productCost = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите количество продуктов");
int productQuantity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите участвует ли продукт в акции, если да введите - 1, если нет введите - 0");
int productStock = Convert.ToInt32(Console.ReadLine());


double discount = productCost % 90;
double sum = productCost - discount;

if (productQuantity >= 5)
{
	Console.WriteLine("Ваш товар: " + productName + Environment.NewLine + "Количество товаров: " + productQuantity + Environment.NewLine + "Сумма вашего товара с учетом скидки: " + sum);
}

double discountTow = productCost % 85;
double sumTow = productCost - discountTow;

if (productStock == 1)
{
	Console.WriteLine("Ваш товар: " + productName + Environment.NewLine + "Количество товаров: " + productQuantity + Environment.NewLine + "Сумма вашего товара с учетом скидки: " + sumTow);
}
