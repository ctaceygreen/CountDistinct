using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        //Hashset is longer than caterpillar method. Caterpillar should be used...
        //In essence, we had a head and tail of the caterpillar, and bring them each towards each other as we move through distinct abs values

        int currentMax = Math.Max(Math.Abs(A[0]), Math.Abs(A[A.Length - 1]));
        int totalAbsDistinct = 1;

        int head = 0;
        int tail = A.Length - 1;

        while(head <= tail)
        {
            int headVal = Math.Abs(A[head]);
            int tailVal = Math.Abs(A[tail]);

            if(headVal == currentMax)
            {
                head++;
                continue;
            }

            if(tailVal == currentMax)
            {
                tail--;
                continue;
            }

            //We now know neither of them are equal to the current max. So take the greatest of them, add 1 to distinct, move the corresponding end of the caterpillar 

            if(headVal >= tailVal)
            {
                currentMax = headVal;
                head++;
            }
            else
            {
                currentMax = tailVal;
                tail--;
            }
            totalAbsDistinct++;
        }
        return totalAbsDistinct;
    }
}