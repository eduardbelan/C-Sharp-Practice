//Erstelle ein int Array mit den Werten 4, 33, 7, 1, 23, 12 in genau dieser Reihenfolge.
//Schreibe dann einen Bubblesort um die zahlen aufsteigend, von der kleinsten bis zur größten Zahl zu Sortieren.
//Lass dir zur Kontrolle dann das sortierte Array in der Konsole ausgeben.


// Meine Lösung

// define int array
int[] array = { 4, 33, 7, 1, 23, 12 };

// get length of array
int lenArray = array.Length;

// view unsorted array
Console.Write("unsorted:\t");
foreach (int i in array)
{
    if (i <= 9)
    {
        Console.Write(" " + i + "\t");
    }
    else
    {
        Console.Write(i + "\t");
    }
}

// bubble sort algorithm
// lenArray loop
for (int i = 0; i < lenArray; i++)
{
    // lenArray - 1 loop (to avoid going out of bounds)
    for (int j = 0; j < lenArray - 1; j++)
    {
        
        // if item > next item, swap
        if (array[j] > array[j + 1])
        {
            // store value of item in temp variable
            int temp = array[j];
            // swap item and next item
            array[j] = array[j + 1];
            // assign temp variable value to next item, after swap
            array[j + 1] = temp;
        }
    }
    // add counter
    i++;
}

// view sorted array
Console.WriteLine();
Console.Write("sorted:\t\t");
foreach (int i in array)
{
    if (i <= 9)
    {
        Console.Write(" " + i + "\t");
    }
    else
    {
        Console.Write(i + "\t");
    }
}


//// Lösung Unterricht
////Initialisierung und Wertzuweisung des Arrays
//int[] bubbleArray = { 4, 33, 7, 1, 23, 12 };

////Ausgabe des Arrays vor der Sortierung
//Console.WriteLine("Unsortiert:");
//foreach (int zahl in bubbleArray)
//{
//    Console.Write($"{zahl} ");
//}

////Erstellung des Bubblesort mit einer inneren und äußeren for-Schleife
//for (int elementIndex = 0; elementIndex < bubbleArray.Length; elementIndex++)
//{
//    for (int sortierschleife = 0; sortierschleife < bubbleArray.Length - 1; sortierschleife++)
//    {
//        if (bubbleArray[sortierschleife] > bubbleArray[sortierschleife + 1])
//        {
//            int temp = bubbleArray[sortierschleife + 1];
//            bubbleArray[sortierschleife + 1] = bubbleArray[sortierschleife];
//            bubbleArray[sortierschleife] = temp;
//        }
//    }
//}

//////Erstellung des Bubblesort mit do-while-Schleife und for-Schleife
//bool komplettSortiert;

//do
//{
//    komplettSortiert = true;
//    for (int i = 0; i < bubbleArray.Length - 1; i++)
//    {
//        if (bubbleArray[i] > bubbleArray[i + 1])
//        {
//            int temp = bubbleArray[i];
//            bubbleArray[i] = bubbleArray[i + 1];
//            bubbleArray[i + 1] = temp;

//            komplettSortiert = false;
//        }
//    }
//}
//while (komplettSortiert == false);

//Console.WriteLine("\n\nSortiert:");
////Ausgabe des Arrays zur Überprüfung
//foreach (int zahl in bubbleArray)
//{
//    Console.Write($"{zahl} ");
//}