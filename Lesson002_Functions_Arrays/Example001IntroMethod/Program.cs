// Поиск максимума из девяти чисел с помощью функции.
int Max (int arg1,int arg2,int arg3) // Функция поиска максимального из трёх чисел чисел.
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }

int a1 = 84;
int b1 = 484;
int c1 = 3;

int a2 = 23;
int b2 = 94;
int c2 = 31;

int a3 = 1449;
int b3 = 237;
int c3 = 909;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.Write(max);
