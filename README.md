# cse212-ww-student-template
This is the starting repository for student work for CSE 212 at BYU-Idaho. It should be used as a template repository for each student to start their own repo.

# Permissions to use
This code is used for class assignments for CSE 211 at Brigham Young University-Idaho. Copying this code is a violation of the BYU-Idaho Honor Code.

To ensure that you are learning the concepts of the course, any code that you add to this starter template should be your own work. If you have any questions about this, ask your teacher.

/// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>


    /* 
            (1). Normalize or wrap the amount parameter so that the amount supplied will always be within the length of the list
            (2). create a new empty list 
            (3). use GetRange() to get a specified items from the data list parameter and the items to the new empty list 
            (3). use RemoveRange() to remove the elements that have been added to the new empty list
            (4). insert specified range of items from the data parameter into a new collection
            (5). Convert and display the new list.
        */




        private static List<int> RotateListRight(List<int> data, int amount)
{
    // Validate input
    if (amount < 1 || amount > data.Count)
    {
        throw new ArgumentException("Amount must be between 1 and the count of the data list.");
    }

    // Normalize amount
    amount %= data.Count;

    // Extract the last 'amount' elements
    List<int> lastElements = data.GetRange(data.Count - amount, amount);

    // Remove the last 'amount' elements from the original list
    data.RemoveRange(data.Count - amount, amount);

    // Insert the extracted elements at the beginning of the list
    data.InsertRange(0, lastElements);

    return data;
}
