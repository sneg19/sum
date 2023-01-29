// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


/* 
1. Получить данные
2. Просуммировать цифры
    2.1 Разложить число на цифры
    2.2 sum
3, Показать на экран
*/


int console_read()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine()!);
}



int summer(int number)
{
    int result = 0;
    while( 0 < number)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}



void print(int num, int res)
{
    Console.WriteLine($"{num} -> {res}");
}


void main()
{
    int read = console_read();
    int sum = summer(read);
    print(read, sum);
}

main();