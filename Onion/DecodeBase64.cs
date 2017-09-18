using System;

namespace ksnctf.Onion
{
    class Resolve
    {
        static void Main ()
        {
            var str = System.IO.File.ReadAllText (".\\OnionOriginal.txt");
            do
            {
                var converted = Convert.FromBase64String (str);
                var newstr = System.Text.Encoding.UTF8.GetString (converted);
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine (newstr);
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                Console.WriteLine("Press Enter to exit.");
                str = newstr;
            }while (Console.ReadKey ().Key != ConsoleKey.Enter);
        }
    }
}