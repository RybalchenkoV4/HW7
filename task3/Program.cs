//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Random rnd = new Random();
int [] matrix = new int[10];

void FillingArray()
{
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[i] = rnd.Next(0,100);
    }
}

void PrintArray()
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]} ");
    }
    Console.WriteLine();
}

void RevArray(int [] array, int count)
{
    if(count < array.Length)
    {
        RevArray(array, count+1);
        Console.Write($"{array[count]} ");
    }
}

FillingArray();
PrintArray();
RevArray(matrix, 0);