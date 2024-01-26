//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите положительное число: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число: ");
int numM = Convert.ToInt32(Console.ReadLine());

int funcAkkermana(int n, int m)
{
    if(n == 0)
    {
        return m+1;
    }
    else if(m == 0)
    {
        return funcAkkermana(n-1, 1);
    }
    else
    {
        return funcAkkermana(n-1, funcAkkermana(n, m-1));
    }
}

Console.WriteLine(funcAkkermana(numN,numM));