class ArraysAndLists {
    // Array methods
    public static void ArrayBasics() {
        // init array 3 ways
        int[] randomNums;
        int[] randArray = new int[5];
        int[] randArray2 = { 1,2,3,4,5 };
        Console.WriteLine("Array length: " + randArray2.Length);
        Console.WriteLine("Array Item 0: " + randArray2[0]);

        for (int i = 0; i < randArray2.Length; i++) {
            Console.WriteLine("{0}: {1}", i, randArray2[i]);
        }

        foreach (int i in randArray2) {
            Console.WriteLine(i);
        }

        // get index of element in array
        Console.WriteLine("Get Index of elem \"1\": " + Array.IndexOf(randArray2, 1));

        string[] names = { "Tom", "Jerry", "Butch" };

        // Join a string array together
        string nameStr = String.Join(", ", names);

        // Split a string into an array
        string[] nameArray = nameStr.Split(',');

        // 2D Arrays
        int[,] matrix = new int[5,3];
        int[,] A = { { 0,1 }, { 2,3 }, { 4,5 } };

        // get length of outer array of A
        int len = A.GetLength(0);

        // Loop through a matrix and output results
        for (int i = 0; i < A.GetLength(0); i++) {
            for (int j = 0; j < A.GetLength(1); j++) {
                Console.WriteLine("{0} | {1} : {2}", i, j, A[i,j]);
            }
        }
    }

    // List methods
    public static void ListBasics() {
        List<int> numList = new List<int>();

        // add items to a list
        numList.Add(5);
        numList.Add(25);
        numList.Add(54);

        int[] randArray = { 1,2,3,4,5 };

        // take an array and add it to a list
        numList.AddRange(randArray);

        // clear a list
        // numList.Clear();

        // create a list from an array
        List<int> numList2 = new List<int>(randArray); // predefined array
        List<int> numList3 = new List<int>(new int[] { 1,2,3,4,5 }); // anonymous array

        // insert an item into a specific index in (index, value) format
        numList.Insert(1, 10);

        // removes the first instance of an item from a list
        numList.Remove(5);

        // removes a specific index from a list
        numList.RemoveAt(2);

        // removes a specific range from a list
        numList.RemoveRange(0,1);

        // length of a list
        int listLength = numList.Count();

        // get index of a specific value
        Console.WriteLine("Index of 5 in List3: " + numList3.IndexOf(5));

        // see if list contains item or not
        Console.WriteLine("Is 5 in list3? " + numList3.Contains(5));

        List<string> strList = new List<string>(new string[] { "Tom", "Jerry", "Butch" });

        // ADD BELOW TO HAVE A CASE INSENSITIVE SEARCH WITHIN A LIST/ARRAY
        Console.WriteLine("Is Tom in the list? " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

        // sorts a list of strings alphabetically
        strList.Sort();

        // sorts a list of numbers in ascending order (no anonymous function like JS/TS needed)
        numList2.Sort();
    }
}