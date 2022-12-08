using System;
using static System.Console;

Clear();

int [] arr={1, 2, 5, 7, 19, 6, 1, 33};

void PrintArray (int [] array)
{
    int count=array.Length;
    for(int i=0; i<count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}
PrintArray(arr);