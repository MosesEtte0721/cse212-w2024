public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}
        
        double[] multiplesOfTwentyOne = MultiplesOf(21, 12);
        double[] multiplesOfNine = MultiplesOf(9, 19);
       

        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("This is my multiplesOf methood");
         
        Console.WriteLine(string.Join(" ",multiplesOfNine));
        Console.WriteLine("This is my multiplesOf methood");
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("RotateListRight(numbers, 1)");
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        RotateListRight(numbers, 1);
        Console.WriteLine();
        
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("RotateListRight(numbers, 5)");
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}} "); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        RotateListRight(numbers, 5); 
        Console.WriteLine();

        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("RotateListRight(numbers, 3)");
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}} "); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        RotateListRight(numbers, 3);
        Console.WriteLine();

        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("RotateListRight(numbers, 9)");
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}} "); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
        RotateListRight(numbers, 9);
        Console.WriteLine();


    }
    
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {      
        // Add the multiples variable to the empty
        // double multiples = number;
        // create a double type empty array that accept the length parameter as a default capacity
        // loop through the multiples array
        /* inside the loop, the indeces should be made elements of the array and 
            assign each index to the number parameter and 
        */
        // return the array
        double[] multiples = new double[length];
        // iterate on the length parameter
        for(var xn = 0; xn < length; xn++)
            {
                multiples[xn] = number * (xn + 1); 
            }        
            return multiples; 
    }

    private static void RotateListRight(List<int> data, int amount)
    { 
        List<int> copyOfData =  new List<int>(data);
        // normailze the amount so that it always stay within the range of the list
        int len = copyOfData.Count();
        amount %= len;
        
        // create an empty list
        var list =  new List<int>();
        // use AddRange() and GetRange() to get the specified range of items from the data parameter to the end of the new new list
        list.AddRange(copyOfData.GetRange(len - amount, amount));

        // remove the added items from the data parameter
        copyOfData.RemoveRange(len - amount, amount);
        // insert 
        list.InsertRange(amount, copyOfData);
        // return list;
        Console.WriteLine(String.Join("", list));

    }
}
