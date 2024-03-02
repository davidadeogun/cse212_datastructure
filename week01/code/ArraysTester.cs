public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {  
        // TODO Problem 1
        /*Plan for MultiplesOf Function
        Initialize an array of doubles with the size equal to the length parameter. This array will store the multiples of the given number.
        Loop through from 0 to length - 1. For each iteration, calculate the multiple of the given number by multiplying the number by the current iteration index plus 1 (since we want to start from the first multiple, not zero).
        Assign the calculated multiple to the respective index in the array.
        Return the array containing the multiples.*/

        //Step 1 for solving the problem
        //Create a new array of doubles with the length of the input
        double[] multiples = new double[length];

        //Step 2
        //Loop through to calculate each multiple
        for (int i=0; i<length; i++)
        {
            //Step 3
            //The first multiple is number itself, so it starts from one and multiplies by the number
            multiples[i] = number * (i+1);
        }
        //Step 4
        return multiples;
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        /*Plan for RotateListRight Function
        1....Handle Cases Where No Rotation Is Needed: If the amount to rotate by is zero or equal to the list size, there's no need to perform any operations, as the list will remain the same.
        2....Normalize the Rotation Amount: If the amount is greater than the list size, reduce it to a meaningful equivalent within the list size range. This can be done by taking the remainder of the amount divided by the list size (amount % data.Count).
        3....Split and Reorder the List:
                 Calculate Split Point: Determine the index at which to split the list. This will be the list's length minus the normalized rotation amount.
                Split the List: Divide the list into two parts at the split point: one from the beginning to the split point (exclusive) and the other from the split point to the end.
                Recombine the List: Append the first part to the end of the second part. This results in the rotated list.
        4....Modify the Original List: Since the requirement is to modify the original list rather than returning a new one, clear the original list and add all elements from the recombined list back into it.
        */
       //Step 1
       //Normalize the amount of rotation to avoid unnecessary rotation
       amount = amount % data.Count;

       //Step 2
       //if no rotation is needed, return
       if (amount == 0) return;

       //Step 3
       //calculate the split index
       int splitPoint = data.Count - amount;

       //Step 4
       //Perform the actual rotation and create a new list to hold the rotated data
       List<int> rotatedData = new List<int>();

       //Step 5
       //Add the data from the split point to the end of the original list
       rotatedData.AddRange(data.GetRange(splitPoint, amount));

       //Step 6
       rotatedData.AddRange(data.GetRange(0, splitPoint));

       //Step 7
       //Copy the rotated data back to the original list
         for (int i=0; i<data.Count; i++)
         {
              data[i] = rotatedData[i];
         }

    }
}
