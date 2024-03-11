public class DuplicateCounter
{
    //Count how many duplicates are in a collection of data.

    public static void Run()
    {
        // var harsh = new HashSet<int>;
        int[] data = {
            50, 9, 24, 100, 7, 75, 93, 24, 17, 16, 97, 6, 18, 81, 48, 37, 49, 33, 60, 3, 99, 32, 88, 29, 65, 20, 35, 33,
            15, 81, 31, 93, 17, 5, 5, 79, 12, 91, 18, 31, 12, 94, 39, 98, 10, 72, 20, 79, 100, 27, 46, 28, 50, 1, 7, 14,
            78, 100, 55, 26, 48, 33, 96, 77, 69, 8, 33, 36, 42, 98, 42, 32, 49, 65, 1, 82, 30, 74, 73, 89, 23, 76, 25,
            4, 76, 7, 72, 86, 71, 29, 18, 98, 84, 20, 24, 18, 11, 33, 39, 96, 1, 97, 65, 41, 62, 48, 59, 51, 17, 89, 6,
            29, 98, 49, 37, 72, 63, 49, 12, 79, 27, 23, 23, 13, 90, 47, 11, 66, 41, 97, 2, 60, 1, 21, 38, 100, 98, 2,
            18, 75, 86, 52, 63, 58, 26, 80, 62, 82, 63, 94, 33, 76, 7, 11, 49, 2, 34, 3, 10, 27, 71, 60, 4, 94, 100, 95,
            46, 15, 21, 40, 35, 98, 89, 25, 46, 54, 24, 75, 92, 69, 37, 63, 71, 70, 90, 91, 82, 81, 4, 10, 82, 1, 32, 8,
            13, 47, 8, 52, 30, 54, 4, 79, 7, 90, 81, 33, 65, 89, 84, 83, 46, 95, 82, 6, 93, 5, 22, 67, 8, 79, 3, 55, 79,
            6, 54, 10, 22, 16, 40, 67, 50, 58, 37, 35, 7, 44, 10, 31, 45, 93, 12, 55, 67, 48, 32, 43, 57, 58, 37, 76,
            85, 47, 80, 18, 32, 59, 98, 92, 53, 98, 29, 61, 82, 42, 78, 97, 23, 94, 38, 20, 73, 11, 99, 94, 92, 82, 82,
            65
        };


        Console.WriteLine($"Number of items in the collection: {data.Length}");
        Console.WriteLine($"Number of duplicates : {CountDuplicates(data)}");
    }

    private static int CountDuplicates(int[] data)
    {
        // number of times items are repeatd
        int numOfTimes = 0;
        
        // create new and empty dictionary
        // var duplicates =  new Dictionary<int, int>();

        // loop through the array
        // foreach(var x in data)
        // {
        //     // increase the item if the item already exist in the dictionary
        //     if(duplicates.ContainsKey(x))
        //     {
        //         ++duplicates[x] ;
        //     }
        //     else {
        //         // assign  the value items to 1, if they are not already in the array
        //         duplicates[x] = 1;
        //     }
        // }

    //     var duplicates1 = duplicates.Where(xn => xn.Value > 1);
    //     Console.WriteLine($"\n duplicated number of duplications: \n{String.Join(", ", duplicates1)}");


    // //   checks for items that are duplicated in the array and count how many items are duplicated
    //     foreach(var xn in duplicates)
    //     {
    //         if(xn.Value > 1)
    //         {
    //              numOfTimes++;
                
    //              //Console.WriteLine($"{xn.Key} repeats {xn.Value} times");

    //         }
            
    //     }

    var set = new HashSet<int>();
    

        foreach(var xn in data)
        {
            if(set.Contains(xn))
            {
                numOfTimes++;
            }
            else {
                set.Add(xn);

            }
        }

        Console.WriteLine("\n"+ String.Join(",", set) + "\n");
        // Console.WriteLine($"\nNUMBER OF DUPLICATES: {data.Count() - set.Count()}");

        return data.Count() - set.Count();
    }
}