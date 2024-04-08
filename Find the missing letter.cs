public class Kata
{
  public static char FindMissingLetter(char[] array)
  {
    char checked_letter = array[0];
    foreach(char element in array)
    {
      if(element-checked_letter==2) return (char)(checked_letter+1);
      checked_letter = element;
    }
    return 'o';
  }
}
