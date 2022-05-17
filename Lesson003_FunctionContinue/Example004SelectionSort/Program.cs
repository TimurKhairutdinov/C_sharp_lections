// Сортировка выбором. 
// Инициализация пустого массива размером 10
int[] arr = new int[10];
// Заполнение массива случайными числами
void RandomArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
}
// Вывод массива в консоль
void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// Сортировка массива по минимальному значениию (слева на право)
void SelectionSortMin(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) // Поиск минимального значения 
            {
                minPosition = j;            
            }
        }
        int temporary = array[i]; // Свап
        array[i] = array[minPosition]; // Свап
        array[minPosition] = temporary;// Свап
    }
}
// Сортировка массива по максимальному значениию (справа на лево)
void SelectionSortMax(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) // Поиск максимального значения 
            {
                maxPosition = j;            
            }
        }
        int temporary = array[i]; // Свап
        array[i] = array[maxPosition]; // Свап
        array[maxPosition] = temporary;// Свап
    }
}
// Применение методов к массиву.
RandomArray(arr,0,99);
PrintArray(arr);
SelectionSortMin(arr);
PrintArray(arr);
SelectionSortMax(arr);
PrintArray(arr);