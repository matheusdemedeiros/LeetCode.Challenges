namespace LeetCode.ConsoleApp.Extensions
{
    public static class TextExtensions
    {
        public static bool IsDiferent(this string main, string secondary)
        {
            return !main.Equals(secondary);
        }

        public static bool IsDiferent(this char main, char secondary)
        {
            return !main.Equals(secondary);
        }
    }
}
