// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Число равно " + number);

int GetSumNums(int arg)
{
    int sum = 0;
    while(arg > 0)
    {
        sum += arg;
        arg -= 1;
    }
    return sum;
}

Console.Write($"Sum numbers: {GetSumNums(number)}");