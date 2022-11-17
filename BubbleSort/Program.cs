using BubbleSort;
using System;


int a = 5;
int b = a; // COPIE DE LA VALEUR
a++;

Console.WriteLine(a);
Console.WriteLine(b);

Manager manager = new Manager()
{
    FirstName = "Barney",
    LastName = "Stinson",
    Age = 32,
    Seniority = 3,
    Zone = "Europe"
};

Manager man = manager; // COPIE DE (LA VALEUR de la pile) de l'adresse mémoire
manager.FirstName = "Robin";
manager.Age = 34;

Console.WriteLine(manager);
Console.WriteLine(man);

static void Test(Manager m) // COPIE DE (LA VALEUR de la pile) de l'adresse mémoire
{
    m.Age = 35;
}






//Manager manager = new Manager()
//{
//    FirstName = "Barney",
//    LastName = "Stinson",
//    Age = 32,
//    Seniority = 3,
//    Zone = "Europe"
//};

//Manager barney = new Manager()
//{
//    FirstName = "Barney",
//    LastName = "Stinson",
//    Age = 32,
//    Seniority = 3,
//    Zone = "Europe"
//};

//if (manager == barney)
//    Console.WriteLine("OUI");
//else
//    Console.WriteLine("NON");


//if (manager.Equals(barney))
//    Console.WriteLine("OUI");
//else
//    Console.WriteLine("NON");









//int mySeed = 8;
//int myMaxValue = 20;

//int value1 = IntExtension.NextRand(mySeed, myMaxValue);

//int value2 = mySeed.NextRand();

//string str = "hell-O-world";

////MyExtensions.ReplaceDashes(str);

//Console.WriteLine(str.ReplaceDashes());

//Manager manager = new Manager();
//Person p = manager;

//p.DisplayPerson();
//manager.DisplayPerson();


//Person[] persons = new Person[5]
//{
//    new Employee(),
//    new Employee("Marshall", "Eriksen", 35, 5),
//    new Manager()
//    {
//        FirstName = "Barney",
//        LastName = "Stinson",
//        Age = 32,
//        Seniority = 3,
//        Zone = "Europe"
//    },
//    new Employee(){ FirstName = "Robin", LastName = "Scherbatsky", Age = 38, Seniority = 8 },
//    new Employee(){ FirstName = "Lily", LastName = "Aldrin", Seniority = 3 }
//};

//persons.DisplayPeople();




//Manager manager = new Manager(zone: "Océanie", seniority: 30, age: 55);











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


//Person[] persons = new Person[5]
//{
//    new Employee(),
//    new Employee("Marshall", "Eriksen", 35, 5),
//    new Manager()
//    { 
//        FirstName = "Barney", 
//        LastName = "Stinson", 
//        Age = 32, 
//        Seniority = 3, 
//        Zone = "Europe"
//    },
//    new Employee(){ FirstName = "Robin", LastName = "Scherbatsky", Age = 38, Seniority = 8 },
//    new Employee(){ FirstName = "Lily", LastName = "Aldrin", Seniority = 3 }
//};


//foreach (Person person in persons)
//{
//    Console.WriteLine(person);
//}

////Array.Sort(persons); // IComparable
//Array.Sort(persons, new PersonComparer(false));
//Console.WriteLine($"{Environment.NewLine}--------");

//foreach (Person person in persons)
//{
//    Console.WriteLine(person);
//}

// ---- collections ----

//var people = new List<Person>();

//var people = new List<Person>(persons);

//people.Add(new Employee() { FirstName = "Lily", LastName = "Aldrin", Seniority = 3 });

//people.AddRange(persons);

//var people = new List<Person>()
//{
//    new Employee(),
//    new Employee("Marshall", "Eriksen", 35, 5),
//    new Manager()
//    {
//        FirstName = "Barney",
//        LastName = "Stinson",
//        Age = 32,
//        Seniority = 3,
//        Zone = "Europe"
//    },
//    new Employee(){ FirstName = "Robin", LastName = "Stinson", Age = 38, Seniority = 8 },
//    new Employee(){ FirstName = "Lily", LastName = "Aldrin", Seniority = 3 }
//};

//// Filtrer et afficher les personnes ayant un âge supérieur ou égal à 35 de la liste

//var people35 = people.Where(p => p.Age >= 35);

//foreach (Person person in people35)
//{
//    Console.WriteLine(person);
//}

//// Sélectionner et afficher le prénom des personnes de la liste

//var peopleFirstNames = people.Select(p => p.FirstName);

//foreach (string name in peopleFirstNames)
//{
//    Console.WriteLine(name);
//}

//// Sélectionner et afficher le prénom et le nom des personnes de la liste

////var test = new { FirstName = "", LastName = "" }; // AnonymousTyped_0

//var peopleFullNames = people.Select(p => new { p.FirstName, p.LastName } );

//foreach (var fullname in peopleFullNames)
//{
//    Console.WriteLine($"{fullname.FirstName} {fullname.LastName}");
//}

//// Récupérer et afficher le premier élément qui a un âge supérieur ou égal à 35 dans la liste

//var firstPerson35 = people.First(p => p.Age >= 35);

//Console.WriteLine(firstPerson35);

//// Récupérer et afficher le dernier élément qui a un âge supérieur ou égal à 35 dans la liste

//var lastPerson35 = people.LastOrDefault(p => p.Age >= 35);

//if(lastPerson35 != null)
//    Console.WriteLine(lastPerson35.FirstName);

//// Afficher la liste triée par prénoms

//var sortedPeople = people.OrderBy(p => p.FirstName);

//foreach (Person person in sortedPeople)
//{
//    Console.WriteLine(person);
//}

//// Filtrer les personnes dont le nom commence par … (lettre de votre choix,
//// vérifier avec plusieurs valeurs), puis trier les données par âge,
//// puis sélectionner uniquement l'âge

//var filteredPeople = people.Where(p => p.LastName.StartsWith('M'))
//                           .OrderBy(p => p.Age)
//                           .Select(p => p.Age)
//                           .ToList();

//foreach (int age in filteredPeople)
//{
//    Console.WriteLine(age);
//}


//// --- ternaires && null

//string? message = null;


//// si c'est null alors valeur par défaut (içi 'hello world')

//message ??= "hello world";

//message = message ?? "hello world";

//message = message != null ? message : "hello world";
//Console.WriteLine(message.ToUpper());

//if (message == null)
//    message = "hello world";

//// si c'est pas null alors j'execute

//if (message != null)
//    Console.WriteLine(message.ToUpper());


//Console.WriteLine(message?.ToUpper());

// --- optionals & named parameters

//TestOptional("hello", 123);
//TestOptional("hello"); // 100
//TestOptional(); // bye, 100
//TestOptional(value: 110, message: "hello world");
//TestOptional(value: 142); // bye


//Employee employee = null;
//bool isWritten = false;

//do
//{
//    try
//    {
//        Console.WriteLine("Prénom ?");
//        string firstName = Console.ReadLine();

//        if (firstName == null || firstName.Length == 0)
//            throw new ArgumentException("prénom invalide");



//        Console.WriteLine("Nom ?");
//        string lastName = Console.ReadLine();

//        if (string.IsNullOrWhiteSpace(lastName)) // vérifie null ou "" ou "   "
//            throw new ArgumentException("nom invalide");



//        Console.WriteLine("Age ?");
//        string input = Console.ReadLine();

//        if (!int.TryParse(input, out int age))
//            throw new IntegerValueException();
//            //throw new ArgumentException("valeur de type incorrect");


//        employee = new Employee(firstName, lastName, age, 1);

//        //if (!File.Exists("myfile.txt"))
//        //    File.Create("myfile.txt");

//        using (FileStream fs = new FileStream("myfile.txt", FileMode.Create, FileAccess.Write))
//        using (StreamWriter sw = new StreamWriter(fs))
//        {
//            sw.WriteLine(employee);
//        } // sw.Dispose() puis fs.Dispose()

//        isWritten = true;
//    }
//    catch (FileNotFoundException)
//    {
//        Console.WriteLine("fichier non trouvé");
//    }
//    catch (IOException)
//    {
//        Console.WriteLine("pb d'écriture");
//    }
//    catch (IntegerValueException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Erreur inconnue");
//    }

//} while (!isWritten);



// delegate

//MyDelegate del = null;

//del += (int op1, int op2) =>
//{
//    return op1 * op2;
//};

//del += (op1, op2) => op1 + op2;






//if (del != null)
//{
//    int result = del(2, 3);
//    Console.WriteLine(result);
//}


//public delegate int MyDelegate(int op1, int op2);




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


static void TestOptional(string message = "bye", int value = 100)
{

}