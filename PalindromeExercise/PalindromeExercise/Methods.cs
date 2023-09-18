using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Methods
    {
        public string reversed(string word)
        {
            string ver = word.Replace(" ", "");
            char[] rev = ver.ToCharArray();
            Array.Reverse(rev);
            string isItPalindrome = new string(rev);
            return isItPalindrome;
        }
    }
}
