
// See https://aka.ms/new-console-template for more information
using CollectionsAndLinq;

//create an instance of a new blank list
List<int> listOfIntegers = new List<int>();

int n = 15;

//Add method
listOfIntegers.Add(1);
listOfIntegers.Add(n);
//listOfIntegers.Add("Halie"); CancellationToken only add things of the correct type

//Lists are iterable
foreach (int num in listOfIntegers)
{
    Console.WriteLine(num);
}

/**************TUPLES******************/

Tuple<string, int, double> product = Tuple.Create("Yo-yo", 1, 9.04);
Console.WriteLine($"{product.Item1} {product.Item2} {product.Item3} ");

/**************VALUE TUPLES************/
// dotnet add package System.ValueTuple

//(string name, int quantity, double price) product = ("Yo-yo", 1, 9.04);
//Console.WriteLine($"{product.name} {product.quantity} {product.price} ");

/***************Dictionary*************/

Dictionary<int, string> numberTable = new Dictionary<int, string>();

numberTable.Add(1, "One");
numberTable.Add(2, "Two");
numberTable.Add(3, "Three");
numberTable.Add(4, "Four");
numberTable.Add(5, "Five");

Console.WriteLine(numberTable[1]);

foreach (KeyValuePair<int, string> number in numberTable)
{
    Console.WriteLine($"{number.Key} equals {number.Value}");
}


////////////////////////////////////////

var cars = new List<Car>();
cars.Add(new Car("Toyota", "Camry", 2022));
cars.Add(new Car("Toyota", "Corolla", 1990));
cars.Add(new Car("Toyota", "4Runner", 2015));
cars.Add(new Car("Ford", "F150", 2020));
cars.Add(new Car("Ford", "Taurus", 2001));
cars.Add(new Car("Tesla", "X", 2022));

    var hash = new Dictionary<string, int>();
    var moreComplexHash = new Dictionary<string, List<Car>>();

foreach (Car car in cars)
{
    //hashmap
    if (hash.ContainsKey(car.Make))
    {
        hash[car.Make]++;
    }
    else
    {
        hash.Add(car.Make, 1);
    }

    if (moreComplexHash.ContainsKey(car.Make))
    {
        moreComplexHash[car.Make].Add(car);
    } 
    else
    {
        moreComplexHash.Add(car.Make, new List<Car> { car });
    }

    foreach (var item in hash)
    {
        Console.WriteLine($"{item.Key}, {item.Value}.");
    }

    foreach (var item in moreComplexHash)
    {
        Console.WriteLine(item.Key, item.Value.Count);
    }
}