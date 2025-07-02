public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // -----------------Problem 1: MultiplesOf-------------------------------
        // 1. Create a new array of size 'length' to store the results.
        // 2. Use a for loop from 0 to length - 1.
        // 3. In each iteration, calculate the multiple by multiplying (index + 1) with the starting number.
        // 4. Store the result in the array at the current index.
        // 5. Return the completed array.
          // Step 1: Create the array
    double[] result = new double[length];

    // Step 2-4: Fill it with multiples
    for (int i = 0; i < length; i++)
    {
        result[i] = number * (i + 1);
    }

    // Step 5: Return it
    return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //------------------ Problem 2: RotateListRight------------------------------------
        // 1. Determine how many items will move from the end to the front: 'amount'.
        // 2. Use GetRange to copy the last 'amount' elements from the list.
        // 3. Use RemoveRange to remove those elements from the end.
        // 4. Use InsertRange to insert them at the beginning of the list.
        // 5. Done.
        //
        // Step 1-2: Get the last 'amount' items
        List<int> endPart = data.GetRange(data.Count - amount, amount);

    // Step 3: Remove them from the end
    data.RemoveRange(data.Count - amount, amount);

    // Step 4: Insert them at the beginning
    data.InsertRange(0, endPart);
    }
}
