
string[] CreateArray(int size)
{
    string[] array = new string [size];
    Console.WriteLine("Creating array here: ");
    for(int i = 0; i< array.Length; i++)
    {
         Console.Write($"Введите {i + 1} элемент: ");
         array[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return array;
}


string[] NewArray(string[] array)
{
    string[] newArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
    }

    return newArray;
}


void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


string[] array = CreateArray(5);
string[] newArray = NewArray(array);
ShowArray(newArray);

