int [,] table = new int[10,15];

for (int i = 0; i < table.GetLength(0); i++) //заполнение массива трехзначными числами
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        table [i,j] = new Random().Next(100, 1000);
    }
}

double average = 0; //среднее арифметическое
int count = 0; //счетчик палиндромов в столбце
double [] arrayWithAverages = new double [count]; //массив для сред.арифметических

for (int j = 0; j < table.GetLength(1); j++)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        if (table [i,j] / 100 == table [i,j] % 10)
        {
            count = count + 1;
            average = (average + table[i,j]) / count;
        }
        else {average = 0;}
    }
}