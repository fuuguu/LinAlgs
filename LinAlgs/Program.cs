//Голубихин Данила 22-ИСП-2/2 Вариант: Пользователь вводит количество недель, месяцев, лет и получает количество дней
//за это время. Считать, что в месяце 30 дней.
using System;

try
{
    Console.WriteLine("Введите кол-во недель:");
    string ned = Console.ReadLine(); //Вводим понятие недели
    double ned1 = double.Parse(ned);
    double dn = ned1 * 7; //Подсчёт дней в неделе
    Console.WriteLine("Введите кол-во месяцев:");
    string mes = Console.ReadLine(); //Вводим понятие месяца
    double mes1 = double.Parse(mes);
    double md = mes1 * 30; //Подсчёт дней в месяце
    Console.WriteLine("Введите кол-во лет:");
    string yr = Console.ReadLine(); //Вводим понятие года
    double yr1 = double.Parse(yr);
    double yd = yr1 * 365; //Подсчёт дней в году
    int res = (int)Math.Round(dn + md + yd); //Подсчитываем все дни и округляем до целого числа
    Console.WriteLine("Всего дней:" + res);
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
