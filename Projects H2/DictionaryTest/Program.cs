using BasicPerson;
using System;
using System.Collections.Generic;

namespace Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> numDict = new Dictionary<string, int>
            {
                { "one", 1 },
                { "tow", 2 },
                { "three", 3 },
                { "four", 4 },
                { "five", 5 },
                { "six", 6 },
                { "seven", 7 },
                { "eight", 8 },
                { "nine", 9 },
                { "ten", 10 }
            };

            Dictionary<float, bool> boolDict = new Dictionary<float, bool>
            {
                { 1, true },
                { 2, true },
                { 3, false },
                { 4, true },
                { 5, false },
                { 6, false },
                { 7, false },
                { 8, true },
                { 9, true },
                { 10, false }
            };

            Dictionary<Basicperson, string> classDict = new Dictionary<Basicperson, string>
            {
                { new Basicperson("bob", 25), "test" }
            };
        }
    }
}
