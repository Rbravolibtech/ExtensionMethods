namespace ExtensionMethods // Removed semicolon from here
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0");
            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            //the +"..."; on the code below makes it so what you consolelog wont all show but it willl
            //nofity you that you have more words

        return string.Join(" ",words.Take(numberOfWords)) + "...";
        }
    }
}
