string[] InputArray(string text)
{
    System.Console.Write(text);
    return Console.ReadLine()!.Split(" ");
}

void PrintArray(string[] arr)
{
    System.Console.WriteLine("[\"" + string.Join("\",\"", arr) + "\"]");
}

int FindingLengthNewArray(string[] arr)
{
    int lengthNewArray = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            lengthNewArray++;
        }
    }
    return lengthNewArray;
}

string[] ArraySorting(string[] arr, int size)
{
    string[] sortedArray = new string[size];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            sortedArray[index] = arr[i];
            index++;
        }
    }
    return sortedArray;
}

System.Console.WriteLine();
string[] myArray = InputArray("Enter a space-separated string array: ");
System.Console.WriteLine();
System.Console.Write("Initial array: ");
PrintArray(myArray);
int lengthNewArray = FindingLengthNewArray(myArray);
System.Console.WriteLine();
System.Console.Write("Sorted array: ");
PrintArray(ArraySorting(myArray, lengthNewArray));
System.Console.WriteLine();