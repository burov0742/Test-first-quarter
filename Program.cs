

string [] NewArray = {"Russia", "MSK", "USA", "France", "LA"};


void ShowArray (string[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

ShowArray(NewArray);