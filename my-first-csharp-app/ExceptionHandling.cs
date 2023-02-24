class ExceptionHandling {
    public static void TryCatch() {
        // try catch block
        try {
            Console.WriteLine("Divide by zero: enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("HEre's error: " + 10/num);
        }

        // catch specific exception
        catch(DivideByZeroException ex) {
            Console.WriteLine("Can't divide by zero!");

            // get name of error
            Console.WriteLine(ex.GetType().Name);

            // throw a new error
            throw new InvalidOperationException("Operation failed!", ex);
        }

        // catch all exceptions
        catch(Exception ex) {
            // get name of error
            Console.WriteLine(ex.GetType().Name);

            // get error message
            Console.WriteLine(ex.Message);
        }
    }
}