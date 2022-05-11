// Виды функций.
// Вид 1.
// Ничего не принимает, ничего не возвращает.
void Method1()
{
    Console.WriteLine("что-то");
}

Method1();

// Вид 2.
// Что-то принимает, ничего не возвращает.
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Что-то");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;  // инкримент - увеличение счётчика на 1.
    }               // i--; декримент - уменьшение на 1.
}

Method21(msg: "Что-то", count: 4);// Именованные аргументы.
Method21(count: 4, msg: "Что-то"); // То же что и на 28 строчке.
Method21("Что-то", 4); // То же что и на 28 строчке.

// Вид 3.
// Что-то возвращает, но ничего не принимает.
int Method3()
{
    return DateTime.Now.Year;
}
Console.WriteLine(Method3());
// или 
int year = Method3();
Console.WriteLine(year);

// Вид 4.
// Что-то принимает, что-то возвращает.

string Method4(int count, string c) // char - тип символ.
{
    int i = 0;
    string result = String.Empty; // Пустая строка  - ""; String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;

}

string res = Method4(5, " abc");
Console.WriteLine(res);


void Method5(int count, int a)
{
    for (int i = 0; i < count; i++) // цикл for, то же что и while, отличие лишь в компактности синтаксиса for.
    {
        Console.WriteLine(a);
        a--; // декримент.
    }
}
Method5(100, 100); 