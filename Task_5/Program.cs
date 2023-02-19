int number;
string numberString;
int max = 0;
int min = 9;
int numberMax = 0;
int numberMin = 9;
int middle;
while (true)
{

    int rand = new Random().Next(1, 4);

    if (rand == 1)
    {
        number = new Random().Next(100, 999);
        Console.WriteLine(number);
        break;
    }
    else if (rand == 2)
    {
        number = new Random().Next(10000, 99999);
        Console.WriteLine(number);
        break;
    }
    else if (rand == 3)
    {
        number = new Random().Next(1000000, 9999999);
        Console.WriteLine(number);
        break;
    }

}

numberString = Convert.ToString(number);

for (int i = 0; i < numberString.Length; i++)
{
    numberMax = Convert.ToInt32(numberString[i].ToString());
    if (numberMax >= max)
    {
        max = numberMax;
    }
}
Console.WriteLine($"Максимальное число - {max}");

for (int i = 0; i < numberString.Length; i++)
{
    numberMin = Convert.ToInt32(numberString[i].ToString());
    if (numberMin <= min)
    {
        min = numberMin;
    }
}
Console.WriteLine($"Минимальное число - {min}");

middle = Convert.ToInt32(numberString[numberString.Length / 2].ToString());

if (max - min == middle)
{
    Console.WriteLine($"Число : {number} - интересное");
}
else
{
    Console.WriteLine($"Число : {number} - неинтересное");
}