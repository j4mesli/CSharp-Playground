// tutorial: https://www.youtube.com/watch?v=lisiwUZJXqQ

// import statement (import another class)
//// MUST BE STATIC TO AVOID INSTANTIATING A NEW 'OBJECT' AND USING THAT
using static test;
using static StringFormatting;
using static ArraysAndLists;
using static ExceptionHandling;

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

// Exception Handling (TryCatch class)
ExceptionHandling.TryCatch();
