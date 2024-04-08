using System;
using System.Collections.Generic;

public class IntersectionUnion
{
    public void Intersection(HashSet<int> set1, HashSet<int>set2)
    {
        

        var intersection = new HashSet<int>(); // create an empty hash table

        foreach(var x in set1) // loop through set1
        {
            if(set2.Contains(x)) // check to see if set2 contains same element as in set
            {
                intersection.Add(x); // if true, add the element to the intersection
            }
        }

        // foreach(var x in intersection) // loop through the intersection
        // {
            
        // }
        Console.WriteLine($"The SET is: {String.Join(", ", intersection)}"); // print all elements that are present in the both sets
    }


    public void Union(HashSet<int> set1, HashSet<int> set2)
    {
        //create an empty hash
        var union = new HashSet<int>(); 
        
        // loop through set1
        foreach(var x in set1) 
        {
            // add each item in set1 to union
            union.Add(x); 
        }

        // loop through set
        foreach(var x in set2)
        {
            // filter elements that are not in union
            if(!union.Contains(x))
            {
                // add the filtered elements in set2 that do not exist in union
                union.Add(x);
            }
        }

//      loop through the  union
        // foreach(var x in union)
        // {
            
            
        // }
        Console.WriteLine($"The UNION is: {String.Join(", ", union)}");// print each item in the union

    }

    public void RunIntersectUnion()
    {
        var set1 = new HashSet<int>{1,3,5,7,8,9,11};
        var set2 = new HashSet<int>{3,19,10,7,13,5,};

        var intersectUnion = new IntersectionUnion();

        intersectUnion.Intersection(set1, set2);

        intersectUnion.Union(set1, set2);
    }
}