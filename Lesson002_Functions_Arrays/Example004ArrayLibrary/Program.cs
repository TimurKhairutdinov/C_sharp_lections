void FillArray(int[] collection) // Метод, который заполняет массив случайными числами.
{
    int length = collection.Length; // Назначение переменной из размера массива.
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,99); // Заполнение массива случайным числом.
        index++;
        
    }
}

void PrintArray(int[]col)
{
    int size = col.Length;
    int position = 0;
    while (position < size)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}


int[] array = new int[10]; // Создать новый массив, в котором будет 10 элементов. По умолчанию он заполнится нулями (0).

FillArray(array);
PrintArray(array);

