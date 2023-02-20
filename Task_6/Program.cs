int Interesting(int n)
{
    int mult = 1;
    int sum = 0;
    string numberSting;
    int numberOne;
    numberSting = Convert.ToString(n);
    int size = Convert.ToInt32(numberSting.Length);
    for (int i = 0; i < size; i++)
    {
        numberOne = Convert.ToInt32(numberSting[i].ToString());
        mult = mult * numberOne;
        sum = sum + numberOne;
    }

    if (mult % sum == 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

int[] array = new int [10];
int number = 0;
int i = 0;
while (i < 10)
{
    array[i] = new Random().Next(10, 1000);
    number = array[i];
    if (Interesting(number) == 1)
    {
        Console.Write(number + "\t");
        i++;
    }
    else
    {

    }
}