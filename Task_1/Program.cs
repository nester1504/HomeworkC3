Console.WriteLine("Введите положительное пятизнаяное число");
bool check = false;
int number = 0;
while (check == false)
{
    string text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
        while (check == false)
        {

            if (number >= 10000 && number <= 99999)
            {
                check = true;

            }
            else
            {
                Console.WriteLine("Попробуйте ещё раз");
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
    }
}

string numberString = Convert.ToString(number);

if(numberString[0] == numberString[4] && numberString[1] == numberString[3])
{
    Console.WriteLine($"Число {number} - является палиндромом");
} else
{
    Console.WriteLine($"Число {number} - НЕ является палиндромом");
}