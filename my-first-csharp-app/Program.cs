// tutorial: https://www.youtube.com/watch?v=lisiwUZJXqQ

// import statement (import another class)
//// MUST BE STATIC TO AVOID INSTANTIATING A NEW 'OBJECT', otherwise you need to initalize a new instance of the item
//// you don't need to do this in this ASP.NET CORE environment
// using static test;
// using static StringFormatting;
// using static ArraysAndLists;
// using static ExceptionHandling;
// using static Animal;
// using static KeyValue<string, string>;

// using import's fields
test.helloFromTest();

/* syntax, casting, and operators */

// print "Hello World!"
Console.WriteLine("Hello World!");

// intake input/output
Console.WriteLine("What's your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name);

// implicit variable declaration, like JS/Python
var anotherName = "Tom";


// get type of variable & string interpolation
Console.WriteLine("anotherName is of type {0}.", anotherName.GetTypeCode());

/* explicit variable declaration */
// boolean
bool canVote = true;

// char
char grade = 'A';

// biggest integer, like Integer.MAX_VALUE in Java
int maxInteger = int.MaxValue;

// biggest long, like Long.MAX_VALUE in Java
long maxLong = long.MaxValue;

// biggest decimal, like Integer.MAX_VALUE in Java (NOT A NATIVE DATA TYPE IN JAVA)
decimal maxDecimal = decimal.MaxValue;

// biggest float, like Float.MAX_VALUE in Java
float maxFloat = float.MaxValue;

// biggest double, like Double.MAX_VALUE in Java
double maxDouble = double.MaxValue;

Console.WriteLine("Values: {0}, {1}, {2}, {3}, {4}, {5}, {6}.", canVote, grade, maxInteger, maxLong, maxDecimal, maxFloat, maxDouble);

// type casting
double pi = 3.14;
int intPi = (int) pi;
Console.WriteLine(pi.ToString() + " and " + intPi.ToString());

// random number (lower, upper) LOWER IS INCLUSIVE, UPPER IS NOT
Random random = new Random(); // declare it like python
Console.WriteLine("Random number between 1 and 10: " + random.Next(1,11));

// conditionals (test class)
test.testConditionals();
test.testLooping();

// string methods (StringFormatting class)
StringFormatting.StringEvaluation();
StringFormatting.FormatString();
StringFormatting.StringBuilderFunctions();

// Array methods (ArrayFunctionality class)
ArraysAndLists.ArrayBasics();
ArraysAndLists.ListBasics();

// ENCAPSULATION OOP (Animal class)
Animal noArgsAnimal = new Animal();
Animal ArgsAnimal = new Animal(15, 10, "Spot", "Woof!");
// you can also init a new Animal instance like this
Animal ObjectInit = new Animal {
    Name = "Grover",
    sound = "Grrr",
    height = 10,
    weight = 10,
};

Console.WriteLine("Number of animals: " + Animal.numOfAnimals);
Console.WriteLine("{0} says {1}", ArgsAnimal.Name, ArgsAnimal.sound);
Console.WriteLine(ArgsAnimal.toString());
Console.WriteLine(ArgsAnimal.getSum(1,2));
Console.WriteLine(ArgsAnimal.getSum(3.1,4.2));

// INHERITANCE OOP (Dog class)
Dog Spike = new Dog();
Console.WriteLine(Spike.toString());

Spike = new Dog(20, 15, "Spike", "Woof!", "Chicken Thighs");
Console.WriteLine(Spike.toString());

// Abstraction (Shape abstract class) & Polymorphism (ShapeItem interface)
// polymorphism by parent abstract class
Shape rect = new Rectangle(5,5);
Shape tri = new Triangle(5,5);

Console.WriteLine("Rectangle Area: " + rect.area());
Console.WriteLine("Triangle Area: " + tri.area());

// Overloading
Rectangle combRect = (Rectangle) rect + (Rectangle) rect;

Console.WriteLine("Combined Rectangle Area: " + combRect.area());

// Generics (KeyValue Class)
KeyValue<string, string> Superman = new KeyValue<string, string>("", "");
Superman.key = "Superman";
Superman.value = "Clark Kent";

KeyValue<int, string> SamsungTV = new KeyValue<int, string>(0, "");
SamsungTV.key = 12345;
SamsungTV.value = "a 50 in SamsungTV";

Superman.showData();
SamsungTV.showData();

// Enums (TemperatureEnum class)
Temperature micTemp = Temperature.Low;
switch(micTemp) {
    case Temperature.Freeze:
        Console.WriteLine("Temp on freezing.");
        break;
    case Temperature.Low:
        Console.WriteLine("Temp on low.");
        break;
    case Temperature.Warm:
        Console.WriteLine("Temp on warm.");
        break;
    case Temperature.Boil:
        Console.WriteLine("Temp on boil.");
        break;
}
// Structs (CustomersStruct class)
Customers Bob = new Customers();
Bob.createCustomer("Bob", 15.50, 12345);
Bob.showCustomer();

// Delegate (GetSumDelegateAnonymousMethod class)
Getsum sum = delegate(double num1, double num2) {
    return num1 + num2;
};
Console.WriteLine("5 + 10 = " + sum(5,10));

// Lambda Function
Func<int, int, int> getSum = (x,y) => x + y;
Console.WriteLine("5 + 3 = " + getSum(5,3));

List<int> numberList = new List<int> { 5, 10, 15, 20, 25 };

// This is basically numberList.filter(num => num % 2 === 1); to return a list of odd numbers from a list of all numbers
List<int> oddNums = numberList.Where(n => n % 2 == 1).ToList();
foreach(int num in oddNums) {
    Console.WriteLine(num);
}

// Exception Handling (TryCatch class)
ExceptionHandling.TryCatch();