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


int[] array = {11,21,31,41,15,61,17,18,19};

int positivesum = 0;
int negativsum = 0;
foreach(int el in array)
{
    if(el > 0) positivesum += el;
    else negativsum += el;
}

// создание многомерного массива:

int [,] GetArray(int m, int n, int minvalue, int maxvalue)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i+=1)
    {
        for(int j=0, j<n, j+=1)
        {
            result[i,j] = new Random().Next(minvalue, maxvalue);
        }
    }
    return result;
}

// печать многомерных массивов

void PrintArray(int[,], inArray)
{
    for (int i=0; i<inArray.GetLenght(0); i+=1)
    {
        for (int j=0; j<inArray.GetLenght(1); j+=1)
        {
            Console.WriteLine($"{result[i,j]}");
        }
    }
}


