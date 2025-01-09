namespace Kata8
{
    public class RemoveStringSpace
    {
        // https://www.codewars.com/kata/57eae20f5500ad98e50002c5/train/csharp

        public static string NoSpace(string input)
        {
            return string.Join("", input.Split(' '));
        }
    }
}
