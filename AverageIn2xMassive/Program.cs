﻿int [,] table = new int[10,15];

for (int i = 0; i < table.GetLength(0); i++) //заполнение массива трехзначными числами
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        table [i,j] = new Random().Next(100, 1000);
    }
}

double average = 0.0; //среднее арифметическое
int sum = 0; //сумма палиндромов в столбце
int count = 0; //счетчик палиндромов в столбце
double [] arrayWithAverages = new double [4]; //массив для сред.арифметических

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
    if (count > 0) {average = sum / count;} //проверка деления на 0
    else {average = 0;}
    Console.WriteLine(average);
}    