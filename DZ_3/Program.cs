// Задача 3: Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

void PrintReversedArray(int[] array)
{
    if (array == null || array.Length == 0) return;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(array[i]);
    }
}

// Пример использования функции
int[] numbers = new int[] { 1, 2, 5, 0, 10, 34 };
PrintReversedArray(numbers);

