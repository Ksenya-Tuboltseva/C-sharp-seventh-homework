int [,] table = new int[10,15];

for (int i = 0; i < table.GetLength(0); i++) //заполнение массива трехзначными числами
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        table [i,j] = new Random().Next(100, 1000);
    }
}

double average = 0.0; //среднее арифметическое
double [] arrayWithAverages = new double [table.GetLength(1)]; //массив для сред.арифметических

for (int j = 0; j < table.GetLength(1); j++)
{
    int sum = 0; //сумма палиндромов в столбце
    int count = 0; //счетчик палиндромов в столбце
    for (int i = 0; i < table.GetLength(0); i++)
    {
        if (table [i,j] / 100 == table [i,j] % 10)
        {
            count = count + 1;
            sum = sum + table[i,j];
        }
    }
    if (count > 0) {average = (double) sum / count;} //проверка деления на 0
    else {average = 0;}
    arrayWithAverages[j] = average; //запись значения в массив
}    

for (int n = 0; n < table.GetLength(1); n++) //вывод массива палидромов
{
    Console.Write(arrayWithAverages[n] + " ");
}