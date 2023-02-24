class test {
    public static void helloFromTest() {
        Console.WriteLine("Hello world from IfStatementsAndLoops!");
    }

    public static void testConditionals() {
        int age = 17;
        if (age >= 5 && age <= 7) Console.WriteLine("Go to elementary school!");
        else if (age > 7 && age < 13) Console.WriteLine("Go to middle school!");
        else Console.WriteLine("Go to high school!");

        if (age < 14 || age > 67) Console.WriteLine("You're not allowed to work!");
        Console.WriteLine("!true: " + !true);

        // ternary
        int canDrive = age >= 16 ? 1 : 0;

        // switch
        switch (age) {
            case 0:
                Console.WriteLine("Infant");
                break;
            // stack conditionals to let the same values get ran for each one
            case 1:
            case 2:
                Console.WriteLine("Toddler");
                // goto a label and run that
                goto Cute;
            default:
                Console.WriteLine("Child");
                break;
        }

        // labels in C#
        Cute:
            Console.WriteLine("Toddlers are cute!");
    }

    public static void testLooping() {
        // while loops (Regular)
        int n = 0;
        while (n < 10) {
            if (n == 7) {
                n++;
                continue;
            }
            if (n == 9) {
                break;
            }
            if (n%2 > 0) Console.WriteLine(n);
            n++;
        }

        // do while
        string guess;
        do {
            Console.WriteLine("Guess a number: ");
            guess = Console.ReadLine();
        }
        // while portion of do loop gets here
        while (!(guess == "15"));

        // for loop
        for (int i = 0; i < 10; i++) {
            if (i % 2 > 0) Console.WriteLine(i);
        }

        // foreach loop
        string randStr = "The quick brown fox jumped over the lazy cow.";

        foreach (char c in randStr) {
            Console.WriteLine(c);
        }
    }
}