public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {

        // Use the length of the 'select' parameter to set the capacity of a new list 
        int[] newList = new int[select.Length];
        // loop through the length of 'select' parameter
        for(var i = 0; i < select.Length; i++)
        {
            // check if the index of select is within bound
            if(select[i] >= 0 && select[i] < list1.Length)
            {
                newList[i] = list1[select[i]];
            }
            else if(select[i] >= list1.Length && select[i] < list1.Length + list2.Length)
            {
                newList[i] = list2[select[i] - list1.Length];
            }
            else{
                newList[i] = -1;
            }
        }
        return newList;
    }
}