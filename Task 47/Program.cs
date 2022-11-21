/* Задача 47. Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
Округлите значения, генерируемые Random до двух знаков после запятой.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.WriteLine("Введите размер строки");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер столбцов");
int stolbez = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[stroka, stolbez];
RandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);



void RandomNumbers(int[,] numbers)
{
    for(int i = 0; i < stroka; i++)
        {
            for(int j = 0; j < stolbez; j++)
            {
                numbers[i,j] = new Random().Next(0,10);
            }
            
        }
}
void PrintArray(int[,] numbers)
{
    
    for(int i = 0; i < stroka; i++)
        {
            for(int j = 0; j < stolbez; j++)
            {
                Console.Write(numbers[i,j] + " ");
            }
           Console.WriteLine();
        }
    Console.Write(" ");
    Console.WriteLine();
}
