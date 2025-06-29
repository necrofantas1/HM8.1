#region Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random
Console.WriteLine("Масив з 10 елементів типу int з випадковими значеннями від -10 до 10");
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
Console.WriteLine("Таблиця множення 9х9:");

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

#region Створити двовимірний масив 5х5. Заповнити його будь-якими числами.
Console.WriteLine();    
Console.WriteLine("Двовимірний масив 5х5:");

const int rows = 5;
const int cols = 5;
const int cellWidth2 = 4;

int[,] array2D = new int[rows, cols];

random = new Random();

// Заповнюємо масив випадковими числами від 0 до 999
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array2D[i, j] = random.Next(0, 999); 
    }
}


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{array2D[i, j],cellWidth2} "); 
    }

// пошук мінімального та максимального значення в масиві
    Console.WriteLine();
}
int minValue = array2D[0, 0];
int maxValue = array2D[0, 0];
int minRow = 0, minCol = 0;
int maxRow = 0, maxCol = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if (array2D[i, j] < minValue)
        {
            minValue = array2D[i, j];
            minRow = i;  
            minCol = j;   
        }
        if (array2D[i, j] > maxValue)
        {
            maxValue = array2D[i, j];
            maxRow = i;  
            maxCol = j;   
        }
    }
}

Console.WriteLine($"\nМинимальное значение: {minValue} (столбец {minCol+1}, строка {minRow+1})");
Console.WriteLine($"Максимальное значение: {maxValue} (столбец {maxCol+1}, строка {maxRow+1})");

#endregion

#region За допомогою enum створити програму,
bool isValid = true;

Console.WriteLine();
Console.WriteLine("Використання enum для визначення днів тижня:");

while (isValid)
{
    Console.WriteLine("Будь ласка, введіть кількість днів: ");

    if (int.TryParse(Console.ReadLine(), out int daysCount))
    {
        int currentDay = (int)DayOfWeek.Monday; // Починаємо з понеділка
        int resultDay = (currentDay + daysCount) % 7;
        DayOfWeek result = (DayOfWeek)resultDay;

        Console.WriteLine($"День тижня через {daysCount} днів буде: {result}");
    }
    else
    {
        Console.WriteLine("Будь ласка, введіть коректне число.");
    }

    Console.WriteLine("бажаєте продовжити? (Y/N): ");
    string userInput = Console.ReadLine()?.Trim().ToUpperInvariant();

    if (userInput == "Y")
    {
        isValid = true;
    }
    else if (userInput == "N")
    {
        isValid = false;
        Console.WriteLine("Дякуємо за використання програми!");
    }
    else
    {
        Console.WriteLine("Невірний ввід, спробуйте ще раз.");
    }
}
#endregion