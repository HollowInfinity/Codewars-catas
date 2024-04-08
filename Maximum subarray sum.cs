public static class Kata
{
  public static int MaxSequence(int[] arr) 
  { 
    int sum = 0,prev_sum = 0,ans = 0;
    foreach(int element in arr)
    {
      sum+=element;
      prev_sum = (sum>prev_sum) ? prev_sum : sum;
      ans = (ans>sum-prev_sum) ? ans : sum-prev_sum;
      
    }
    return ans;
  }
}
