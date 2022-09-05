
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


