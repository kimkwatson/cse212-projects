using System.Diagnostics;

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

        // Create an array using 'length' as the capacity size
        // Use a for loop to iterate through the array length
        // Establish an index variable in for loop for counting iterations
        // Calculate the next multiple in array by multiplying index (+1 to offset 0) by 'number'
        // Add the new multiple to the array by assigning it to the current index
        // Return the created array

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
           multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
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

        // Remove the last values from the list up to 'amount'
        // Put the removed values into a new list
        // Insert those values (as a list) at the beginning of the list

        List<int> shifted = new List<int>(data.GetRange(data.Count-amount, amount));
        Debug.WriteLine(shifted);
        data.InsertRange(0, shifted);
        Debug.WriteLine(data);
    }
}
