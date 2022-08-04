using System;
using System.Text;

namespace Basic_C_Sharp_Project_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string text1 = "Hello, ";
            string text2 = "my name is Damian, ";
            string text3 = "how are you?";
            string wholeSentence = text1 + text2 + text3;
            Console.WriteLine(wholeSentence);
            Console.WriteLine("\n");

            //2
            Console.WriteLine(wholeSentence.ToUpper());
            Console.WriteLine("\n");

            //3
            StringBuilder sb = new StringBuilder(); // need to use System.Text
            sb.Append("Hello, ");
            sb.Append("my ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Damian, ");
            sb.Append("how ");
            sb.Append("are ");
            sb.Append("you?");

            Console.WriteLine(sb);

        }
    }
}
