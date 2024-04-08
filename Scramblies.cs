using System;
using System.Linq;
public class Scramblies 
{
    
    public static bool Scramble(string str1, string str2)
  {
    str2 = str2.Trim();
    if (!str2.Any()) return true;
    bool[] ans = new bool[str2.Length];
    for (int i = 0; i < str2.Length; i++)
    {
        if (!str1.Contains(str2[i])) return false;
        str1 = str1.Remove(str1.IndexOf(str2[i]),1);
    }
        
    return true;

  }

}
