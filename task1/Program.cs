//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите начальное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNumbers(M,N);

void PrintNumbers(int firstNum, int lastNum)
{
    if(firstNum > lastNum)
    {
        return;
    }

    Console.Write($"{firstNum} ");

    PrintNumbers(firstNum+1, lastNum);
}