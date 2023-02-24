// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.

// массив размером 2 x 2 x 2
// int[,,]

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

using System;
using static System.Console;

Clear();

Write("Введите показатель 1: ");
int n = int.Parse(ReadLine()); // Convert.ToInt32(Console.ReadLine());
Write("Введите показатель 2: "); 
int m = int.Parse(ReadLine()); 
Write("Введите показатель 3: "); 
int l = int.Parse(ReadLine()); 
int[,,] array = Random3dArray(m, n, l); 
Show3dArray(array); 

int[,,] Random3dArray( int field, int rows, int columns) 
{ 
    int[,,] newArray = new int[field, rows, columns]; 
    for(int i = 0; i < field; i++) // прохождение по строкам 
    { 
        for(int j = 0; j < rows; j++) // прохождение по столбцам
     { 
        for(int k = 0; k < columns; k++) 
        { 
            newArray[i,j,k] = i + j + k; 
        } 
     } 
    } 
    return newArray; 
} 
void Show3dArray(int[,,] array) // показываем двумерный массив 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for(int j = 0; j < array.GetLength(1); j++) 
        { 
            for(int k = 0; k < array.GetLength(2); k++) 
            { 
                Console.Write("[" + i + "," + j + "]" + array[i, j, k] + " "); 
            } 
            Console.WriteLine(); 
        } 
        Console.WriteLine(); 
    } 
    Console.WriteLine(); 
}