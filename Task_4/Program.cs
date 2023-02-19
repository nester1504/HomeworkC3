Console.Write("Введите первоночальный вклад = ");

int number;
double rez;

while (true)
{
    string text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
        if (number <= 0)
        {
            Console.WriteLine("Первоночальный вклад не может быть отрицательным");
        }
        else
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
    }
}

if (number <= 99)
{
    rez = (number / 100.00 * 5.00) + number;
    Console.WriteLine(rez);
    Console.WriteLine($"Общая сумма с начисленным процентам = {rez}");
}
else if (number >= 100 && number <= 199)
{
    rez = (number / 100.00 * 7.00) + number;
    Console.WriteLine($"Общая сумма с начисленным процентам = {rez}");
}
else
{
    rez = (number / 100.00 * 10.00) + number;
    Console.WriteLine($"Общая сумма с начисленным процентам = {rez}");
}
