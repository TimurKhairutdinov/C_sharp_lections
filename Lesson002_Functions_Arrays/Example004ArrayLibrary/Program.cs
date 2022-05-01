void FillArray(int[] collection) // Метод, который заполняет массив случайными числами.
{
    int length = collection.Length; // Назначение переменной из размера массива.
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,5); // Заполнение массива случайным числом.
        index++;
        
    }
}

void PrintArray(int[]col) // Метод, который печатает массив.
{ 
    int size = col.Length;
    int position = 0;
    while (position < size)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}

int indexOf(int[] collec, int find) // Метод поиска позиции в массиве по заданному аргументу.
{
    int count = collec.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collec[index]==find)
        {
            position = index;  
            break; 
        }
        index++;
    }
    return position; 
   
}

int[] array = new int[10]; // Создать новый массив, в котором будет 10 элементов. По умолчанию он заполнится нулями (0).

Console.WriteLine("Введите число: ");
int find = Convert.ToInt32(Console.ReadLine()); // Переменная аргумент для поиска.

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = indexOf(array, find );
Console.WriteLine(pos);
