int [,] table = new int [3,4] {{100, 404, 504, 225}, 
                               {550, 478, 800, 363}, 
                               {505, 101, 410, 479}};

double average = 0.0; //среднее арифметическое
int sum = 0; //сумма палиндромов в столбце
int count = 0; //счетчик палиндромов в столбце
double [] arrayWithAverages = new double [table.GetLength(1)]; //массив для сред.арифметических

for (int j = 0; j < table.GetLength(1); j++)
{
    sum = 0;
    count = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        if (table [i,j] / 100 == table [i,j] % 10)
        {
            count = count + 1;
            sum = sum + table[i,j];
        }
    }
    if (count > 0) {average = sum / count;}
    else {average = 0;}
    arrayWithAverages[j] = average; //запись значения в массив
}    

for (int n = 0; n < table.GetLength(1); n++) //вывод массива палидромов
{
    Console.Write(arrayWithAverages[n] + " ");
}