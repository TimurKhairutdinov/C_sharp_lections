int[] array = {1,3,4,5,2,5,66,2,4};

int size = array.Length; // Назначение переменной размер массива.
int find = 5;

int index = 0; // Переменная индекса массива.

while (index < size)
{
    if (array[index] == find) // 
    {
    Console.WriteLine("index " + index); // Вывод индекса совпадающего с искомым числом.
    Console.WriteLine("array[index] " + array[index]); // Вывод числа совпадающего с искомым числом.
    break; // Оператор прерывания. В случае совпадения искомого числа, оператор прервёт цикл.
    }
    index++;
}
