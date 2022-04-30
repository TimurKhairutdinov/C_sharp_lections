// Поиск максимума из девяти чисел с помощью функции и массива.
int Max (int arg1,int arg2,int arg3) // Функция поиска максимального из трёх чисел чисел.
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }
//              0  1  2  3  4  5  6  7  8
int[] array = {1883,21,37,44,785,61,97,9,29};

int result = Max(
    Max( array[0],array[1],array[2]),
    Max( array[3],array[4],array[5]),
    Max( array[6],array[7],array[8]));

Console.Write(result);
