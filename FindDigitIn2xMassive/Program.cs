Console.WriteLine("Введите номер строки");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int j = Convert.ToInt32(Console.ReadLine());

int [,] table = new int [3,6]; //заданный массив для проверки

void FillArray (int [,] array)  //заполняем массив числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
}
FillArray(table);

for (int n = 0; n < table.GetLength(0); n++)  //вывод нашего массива для наглядности
    {
        for (int m = 0; m < table.GetLength(1); m++)
        {
            Console.Write(table[n,m] + " ");
        }
        Console.WriteLine();
    }

if (i < table.GetLength(0) && j < table.GetLength(1))
{
    Console.WriteLine(table[i,j]);
}
else {Console.WriteLine("Числа в массиве не существует");}