// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string GenerationString()
{
    string result = String.Empty;
    int length = new Random().Next(1, 11);
    int randomValue;
    char msg;
    for (int i = 0; i < length; i++)
    {
        randomValue = new Random().Next(0, 26);
        msg = Convert.ToChar(randomValue + 65);
        result += msg;
    }
    return result;
}

string[] InputArray()
{
    Console.WriteLine("Введите количество элементов массива: ");
    Console.WriteLine("(число должно быть не меньше 1, но не больше 100)");
    int size = 0;
    while (size < 1 || size > 100)
    {
        while (!int.TryParse(Console.ReadLine(), out size));
    }
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GenerationString();
    }
    return array;
}

string[] ReleaseArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];

    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}

Console.Clear();
string[] FirstArray = InputArray();
Console.WriteLine($"\n[{string.Join("\t", FirstArray)}]");
string[] SecondArray = ReleaseArray(FirstArray);
Console.WriteLine($"\n[{string.Join("\t", ReleaseArray(SecondArray))}]");


