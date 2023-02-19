Console.Write("Введите число N: ");
bool check = false;
int number = 0;

while (check == false)
{
    string text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
        while (check == false)
        {
        
            for (int i = 1; i <= number; i++)
            {
                Console.Write(Math.Pow(i, 3) + "\t");
            }
            check = true;
        }
    }
    else
    {
        Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
    }
}
