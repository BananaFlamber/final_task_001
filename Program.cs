// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

string[] array = new[] { "garry", "god", "spurs", "ball", "01", "02", "lol" };

string[] second_array = FindTheNecessary(array);

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", second_array)}]");

string[] FindTheNecessary(string[] array)
{
    string[] output = new string[ArrayLenght(array)];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            output[j] = array[i];
            j++;
        }
    }
    return output;
}

int ArrayLenght(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    return count;
}
