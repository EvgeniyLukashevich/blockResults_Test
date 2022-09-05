
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
