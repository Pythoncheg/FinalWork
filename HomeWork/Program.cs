


void PrintArray(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length || arr.Length <= 1)
            Console.Write($"[{arr[i]}] ");
        else if (i == 0)

            Console.Write($"[{arr[i]}, ");

        else if (i != arr.Length - 1)

            Console.Write($"{arr[i]}, ");

        else
            Console.Write($"{arr[i]}] ");

    }
    Console.WriteLine();
}

int FindLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++;
    }
    return count;
}