/// задать двумерный массив (4,4)из целых чисел
// заполнить по спирали
 

using System;
using static System.Console;

Clear();



const int n = 4;
 int[,] matrix = new int[n, n];
int row = 0;
int col = 0; 
int x = 1;
int y = 0;
int dirChanges = 0; 
int pred = n;
    for (int i = 0; i < matrix.Length; i++)
            {
                matrix[row, col] = i + 1;
                WriteLine(matrix);
                if (--pred == 0)
                {
                    pred = n * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = x;
                    x = -y;
                    y = temp;
                    dirChanges++;
                }
                col += x;
                row += y;
            }               
 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
                Console.ReadLine();
