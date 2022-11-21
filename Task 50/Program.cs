/* Задача 50. Напишите программу, которая будет принимать от пользователя позицию (M, N) 
двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
Если такой позиции в массиве нет, то сообщить об этом пользователю. 
Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
Использование методов для заполнения массива обязательно. 
Остальное можно реализовать в главной программе.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.*/

int stroka = ReadInt("Введите индекс строки: ");
int stolbez = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[new Random().Next(1, 10),new Random().Next(1, 10)];
FillArray(numbers);
PrintArray(numbers);

if (stroka < numbers.GetLength(0) && stolbez < numbers.GetLength(1))
{
    Console.WriteLine(numbers[stroka, stolbez]);
}
 
else 
{
    Console.WriteLine($"{stroka},{stolbez} -> такого элемента в массиве нет");
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
