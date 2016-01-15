using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount {
    class Counter {

        //Counting Words in a String
        public static int CountWords(string sentence) {
            return sentence.Split(' ').Length;
        }

    }

    static class MyUtilities {

        public static int WordCount (this string sentence) {
            return sentence.Split(' ').Length;
        }

        public static string[] GetFirstWords(this string sentence, int numWords) {
            //.take is an extension method
            return sentence.Split(' ').Take(numWords).ToArray();
        }
    }
}
