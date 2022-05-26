// Двумерные массивы.

string[,] table = new string [2,5];
table[1,2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"- {table[rows,columns]} -");
    }
}

int[,] matrix = new int[3, 4];
RandomFillArray(matrix);
WriteArray(matrix);

void RandomFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // цикл отвечающий за строки
    {
        for (int j = 0; j < array.GetLength(1); j++) // цикл отвечающий за столбцы
        {
            array[i,j] = new Random().Next(1,10); // 1 - включительно, 10 исключительно.
        }
    }
}
void WriteArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}