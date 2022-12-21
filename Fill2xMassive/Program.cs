int m = 5;
int n = 7;
double [,] table = new double[m,n];

for (m = 0; m < table.GetLength(0); m++)
{
    for (n = 0; n < table.GetLength(1); n++)
    {
        table [m,n] = new Random().NextDouble() * 100; //для получения чисел с целой частью больше 0
    }
}

for (m = 0; m < table.GetLength(0); m++)
{
    for (n = 0; n < table.GetLength(1); n++)
    {
        Console.Write(Math.Round(table[m,n], 2) + " "); //с преобразованием до 2 чисел после запятой
    }
    Console.WriteLine();
}