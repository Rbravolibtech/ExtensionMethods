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

            Console.WriteLine(shortendedPost);
        }
        
    }
}
