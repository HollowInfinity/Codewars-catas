using System;

public class Kata
{
        public static string Rgb(int r, int g, int b)
        {
            return FindValue(r) + FindValue(g) + FindValue(b);
        }

        public static string FindValue(int n)
        {
            if (n < 0) n = 0;
            if (n > 255) n = 255;
            return n.ToString("X2");
        }
}
