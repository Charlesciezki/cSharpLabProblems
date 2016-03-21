using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpProblems
{
    class ListAndStringCount
    {
        string input;
        public List<string> inputList = new List<string>{"t", "a", "t"};

        public int countInput()
        {
            input = "string";
            Console.WriteLine(input.Length);
            return input.Length;
        }

        public int countInputList()
        {
            Console.WriteLine(inputList.Count);
            return inputList.Count;
        }
    }
}
