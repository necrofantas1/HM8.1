#region Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random

using System.Runtime.ExceptionServices;

int[] numbers = new int[10]; 

Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(-10, 11); // 
}

for (int i = 0; i< numbers.Length; i +=2)
{
    Console.WriteLine($"element[{i}] = {numbers[i]}");
}

#endregion

#region Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.

int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

if (sum >= 0)
{
    Console.WriteLine("\nСума елементів масиву є невід'ємним числом.");
}
else
{
    Console.WriteLine("\nСума елементів масиву є від'ємним числом.");
}

#endregion

#region Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення
Console.WriteLine();


const int cellSize = 9; // Розмір таблиці множення
const int cellWidth = 3; // Ширина кожної комірки таблиці

int[,] multiplicationTable = new int[cellSize, cellSize];

for (int i = 0; i < cellSize; i++)
{
    for (int j = 0; j < cellSize; j++)
    {
        multiplicationTable[i, j] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < cellSize; i++)
{
    for (int j = 0; j < cellSize; j++)
    {
        Console.Write($"{multiplicationTable[i, j],cellWidth} ");
    }
    Console.WriteLine();
}

#endregion