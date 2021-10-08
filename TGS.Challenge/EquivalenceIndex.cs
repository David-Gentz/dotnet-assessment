namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
      public int Find(int[] numbers)
      {
            if (numbers.Length == 0)
                return -1;

            int leftSum;
            int rightSum;
            int i;
            int j;

            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] <= 0 || numbers[i] >= 100000)
                    return -1;

                leftSum = 0;
                rightSum = 0;

                for (j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                    return i;
            }

            return -1;
      }
    }
}
