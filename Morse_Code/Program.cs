using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Code
{
    public  class Program
    {

        public static string MorseToLetter(string morseCode)
        {
            Dictionary<string, char> morse_Dict = new Dictionary<string, char>()
        {
                {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'}, {"..-.", 'F'},
                {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'}, {"-.-", 'K'}, {".-..", 'L'},
                {"--", 'M'}, {"-.", 'N'}, {"---", 'O'}, {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'},
                {"...", 'S'}, {"-", 'T'}, {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'},
                {"-.--", 'Y'}, {"--..", 'Z'}
        };

            return morse_Dict[morseCode].ToString();
        }

        static void Main(string[] args)
        {

            string inPut = string.Empty;
            Console.WriteLine("Please enter your input");
            inPut = Console.ReadLine();

            Console.WriteLine(MorseToLetter(inPut));


        }
    }
}
