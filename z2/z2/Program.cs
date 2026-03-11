// See https://aka.ms/new-console-template for more information

Console.WriteLine("first msg");

Console.WriteLine("second msg");

int CalculateAverage(int[] values)
{
    int fin = 0;
    foreach (int value in values)
    {
        fin += value;
    }
    return fin / values.Length;
}

int CalculateMax(int[] values)
{
    return values.Max();
}

int CalculateMin(int[] values)
{
    return values.Min();
}