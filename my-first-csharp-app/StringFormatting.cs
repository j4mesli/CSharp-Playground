class StringFormatting {
    public static void StringEvaluation() {

        string SampleString = "The quick brown fox jumped over the lazy dog.";

        // if string is undef or null (like truthy evaluation !SamepleString)
        Console.WriteLine("Is undef or null: " + String.IsNullOrEmpty(SampleString));

        // if string is null or blank
        Console.WriteLine("Is null or blank: " + String.IsNullOrWhiteSpace(SampleString));

        // String length
        Console.WriteLine("Length: " + SampleString.Length);

        // index of substring (what it starts it is returned)
        Console.WriteLine("Index of: " + SampleString.IndexOf("dog"));

        // pull a sliced substring
        Console.WriteLine("Second word: " + SampleString.Substring(2, 7));

        string SampleString2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

        // String equality
        Console.WriteLine("Equal strings: " + SampleString.Equals(SampleString2));

        // String starts with ...
        Console.WriteLine("Starts with \"A Bunch\" " + SampleString2.StartsWith("A Bunch"));

        // String ends with ...
        Console.WriteLine("Ends with \"elit.\" " + SampleString2.EndsWith("elit."));

        // Trims all whitespace from ENTIRE STRING
        Console.WriteLine(SampleString.Trim());

        // Trims all whitespace from START OF STRING
        Console.WriteLine(SampleString.TrimStart());

        // Trims all whitespace from END OF STRING
        Console.WriteLine(SampleString.TrimEnd());

        // Replaces all particular words from a string
        Console.WriteLine(SampleString.Replace("dog", "cat"));

        // Removes characters from string (INCLUSIVE, NOT INCLUSIVE)
        Console.WriteLine(SampleString2.Remove(0,2));

        // new String Array
        string[] names = new string[3] { "Matt", "Joe", "Tim" };

        // Print an array
        Console.WriteLine("Name List: " + String.Join(", ", names));

    }

    public static void FormatString() {
        string SampleString = "The quick brown fox jumped over the lazy dog.";
        string SampleString2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

        // format a string
        //// TURN INTO A CURRENCY, REQUIRE INTO FORMAT 00.00, REQUIRE ONLY BACK PORTION INTO ZEROES, WITH WHATEVER SIGNIFIED BY POUND, OR REQUIRE THOUSANDS PLACE
        string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.667, .56, 1000);
        Console.WriteLine(fmtStr);
    }

    public static void StringBuilderFunctions() {
        // use case is because when editing a string, we're actually creating a copy of said string in memory
        // this prevents the double creation of said string.

        // WE CAN REDUCE THIS BY INCLUDING "using System.Text" at the top
        // init StringBuilder object
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        // add strings to the StringBuilder
        sb.Append("This is the first sentence. ");
        
        // add strings to the stringbuilder with format
        sb.AppendFormat("My name is {0} and I live in {1}.", "Derek", "Pennsylvania");

        // clear the stringbuilder
        // sb.Clear();

        // replace the letter "A" with "E" in stringbuilder FOR ALL STRINGS WITHIN IT
        sb.Replace("a", "e"); 

        // remove INDICES FOR ALL STRINGS IN SB
        sb.Remove(5,7);

        // to print/use, you must execute the "toString" method
        Console.WriteLine(sb.ToString());
    }
}