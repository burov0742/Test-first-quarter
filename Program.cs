

string [] NewArray = {"Russia", "MSK", "USA", "France", "LA"};


void ShowArray (string[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

ShowArray(NewArray);

string [] FindShortWords (string [] array)
{
    string [] ShortWords =  new string [array.Length];
    for(int i = 0; i < array.Length; i++ )
    {
        if ( array[i].Length <= 3)
        ShortWords[i] = array[i];

    }

    return ShortWords;
}

ShowArray(FindShortWords(NewArray));