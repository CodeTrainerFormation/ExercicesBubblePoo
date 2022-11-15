using BubbleSort;

//int[] array = { 9, 2, 5, 7, 1, 3, 8, 6, 4 };


//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write(array[i] + " ");
//}

////BubbleSort(array);

//Array.Sort(array);

//Console.WriteLine($"{Environment.NewLine}--------");

//foreach (int item in array)
//{
//    Console.Write($"{item} ");
//}


Person[] persons = new Person[5]
{
    new Employee(),
    new Employee("Marshall", "Eriksen", 35, 5),
    new Manager()
    { 
        FirstName = "Barney", 
        LastName = "Stinson", 
        Age = 32, 
        Seniority = 3, 
        Zone = "Europe"
    },
    new Employee(){ FirstName = "Robin", LastName = "Scherbatsky", Age = 38, Seniority = 8 },
    new Employee(){ FirstName = "Lily", LastName = "Aldrin", Seniority = 3 }
};


foreach (Person person in persons)
{
    Console.WriteLine(person);
}

Array.Sort(persons);
Console.WriteLine($"{Environment.NewLine}--------");

foreach (Person person in persons)
{
    Console.WriteLine(person);
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