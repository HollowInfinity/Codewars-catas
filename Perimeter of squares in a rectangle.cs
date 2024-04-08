using System;
using System.Numerics;

public class SumFct
{
    public static BigInteger perimeter(BigInteger n)
  {
    BigInteger[] ans = new BigInteger[(int)(n + 1)]; // array to hold square lengths
    BigInteger sum = 0;
    ans[0] = 1; // initial value to meet for loop requirement
    sum += ans[0];
    if (n == 0) return sum;
    ans[1] = 1;
    sum += ans[1]; // initial value to meet for loop requirement
    if (n == 1) return sum;
    for (BigInteger i = 2; i <= n;i++)
    {
        ans[(int)i] =  (ans[(int)(i - 1)] + ans[(int)(i - 2)]); //find all square lengths
        sum+= ans[(int)i]; // sum them
    }
    return 4*sum; // 4 is the number of square sides
  }

    
}
