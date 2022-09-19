/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 0)
        {
            count = count + 1;
        }
    }
    return count;
}

void PrintArray (int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return;
}

Console.WriteLine("Введите кол-во чисел, планируемых к вводу: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];
for(int i = 0; i < m; i++)
{
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = Count(array);
Console.WriteLine($"Количество положительных чисел = {count}");