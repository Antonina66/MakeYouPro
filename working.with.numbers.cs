﻿// // Работа с числами
// Задание 1:
// Курьерская служба выполняет доставки по единому тарифу: 150р. фиксировано + 70р. за каждый километр дороги.
// Напишите программу, которая будет запрашивать у пользователе длину пути в км и выводить на консоль цену доставки.

Console.WriteLine("Введите киллометраж");
int km = Convert.ToInt32(Console.ReadLine());
int prise = 150 + 70 * km;

Console.WriteLine(prise);

// Задание 2:
// Банк предоставляет 3 акционных вклада:
// - под 8% годовых длительностью в 9 месяцев; 6,1155
// - под 9.5% годовых длительностью в 12 месяцев;
// - под 10% годовых длительностью в 18 месяцев. 15,2874
// Напишите программу, которая запросит у пользователя сумму вклада и выведет на консоль его прибыль для каждого из трех вариантов вклада.

Console.WriteLine("Введите сумму");
int sum = Convert.ToInt32(Console.ReadLine());

double priseOne = (sum * 6.1155 / 100) + sum;

double priseTow = (sum * 9.5 / 100) + sum;

double priseThree = (sum * 15.2874 / 100) + sum;

Console.WriteLine("под 8% годовых длительностью в 9 месяцев: ваш доход - " + priseOne + Environment.NewLine + "под 9.5% годовых длительностью в 12 месяцев: ваш доход - " + priseTow + Environment.NewLine + "под 10% годовых длительностью в 18 месяцев - " + priseThree);

(сумма вложения * ставка * (дни / 365))/100 П = (С / 100) × % × (Д / 365)
