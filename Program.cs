string[] CreateUserArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input the {i + 1} string of {size}: ");
        array[i] = Console.ReadLine();
    }

    Console.WriteLine();
    return array;
}

string[] ThreeCharStringArray(string[] array)
{
    string[] newArray = new string[0];

    for (int i = 0, j = 0; i < array.Length; i++)
        if (array[i].Length < 4)
        {
            Array.Resize(ref newArray, j + 1);
            newArray[j] = array[i];
            j++;
        }

    return newArray;
}

void ShowArray(string[] array)
{
    Console.Write("| ");
    for (int index = 0; index < array.Length; index++)
        Console.Write($"{array[index]} | ");

    Console.WriteLine();
    Console.WriteLine();
}

int size = 5;
string[] array = CreateUserArray(size);

Console.WriteLine("Array elements will be separated from each other by the symbol \"|\" ");
Console.WriteLine();
Console.WriteLine("Catch your original string array: ");
ShowArray(array);
Console.WriteLine("Catch your result string array: ");
ShowArray(ThreeCharStringArray(array));