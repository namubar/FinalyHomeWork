string[] array = sourceArray();                                                            //Создаем исходный массив, результат сохраняем в переменную
string[] newArray = finalArray(array, 3);                                                  //Создаем конечный массив по условию задачи (передаем соответствующие аргументы), сохраняем результат
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", newArray)}]");     //Вывод результатов по условию задачи

string[] finalArray(string[] input, int n)
{
    string[] result = new string[countArray(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)                                          //Используем цикл для перебора элементов
    {
        if (input[i].Length <= n)
        {
            result[j] = input[i];
            j++;
        }
    }

    return result;                                                                          //Возвращаем результат, для использования в стр. 2 с необходимыми аргументами
}

int countArray(string[] input, int n)                                                       //используем цикл для подсчета элементов
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }

    return count;                                                                          //Возвращаем результат для использования в теле предыдущего метода
}

string[] sourceArray()                                                                      // Пользователь вводит элементы исходного массива, в качестве разделителя выбран пробел. 
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine()!.Split(" ");                                                  //В качестве разделителя можно выбрать произвольный знак ("*", например)
}
