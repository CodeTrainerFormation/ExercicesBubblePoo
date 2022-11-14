int[] array = { 9, 2, 5, 7, 1, 3, 8, 6, 4 };


for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

//BubbleSort(array);

Array.Sort(array);

Console.WriteLine($"{Environment.NewLine}--------");

foreach (int item in array)
{
    Console.Write($"{item} ");
}



static void BubbleSort(int[] array)
{
    int swap, marker = array.Length - 1;
    bool hasSwapped;

    do
    {
        hasSwapped = false;

        for (int i = 0; i < marker; i++)
        {
            if (array[i] > array[i + 1])
            {
                swap = array[i + 1];
                array[i + 1] = array[i];
                array[i] = swap;

                hasSwapped = true;
            }

            //Console.WriteLine($"{Environment.NewLine}--------");

            //foreach (int item in array)
            //{
            //    Console.Write($"{item} ");
            //}
        }

        marker--;

    } while (hasSwapped);


}