using System;
using System.Linq;

namespace ksnctf
{
    class Resolve
    {
        static void Main()
        {
            var str = System.IO.File.ReadAllText(".\\question.txt");
            var swap = System.IO.File.ReadAllText(".\\answer.txt").Replace(" ", "").Select(elem => Char.ToLower(elem)).ToArray();
            var newstr = new Char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if(Char.IsLetter(str[i]))
                {
                    if(Char.IsLower(str[i])) newstr[i] = Char.ToLower(swap[(int)str[i] - 'a']);
                    else if(Char.IsUpper(str[i])) newstr[i] = Char.ToUpper(swap[(int)str[i] - 'A']);
                }
                else newstr[i] = str[i];
            }
            Console.WriteLine(newstr);
        }
    }
}