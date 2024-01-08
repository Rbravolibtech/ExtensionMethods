using System;
using System.Linq;
namespace ExtensionMethods 
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is a Post about Extension Methods";
            var shortendedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() {  1, 3, 5, 10, 18, 45};
            var max = numbers.Max();

            Console.WriteLine(max);

            //Console.WriteLine(shortendedPost);
        }
        
    }
}
