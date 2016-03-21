using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpProblems
{
    class MoveTheList
    {
        public List<int> ListA = new List<int> {1, 2, 3};
        public List<int> ListB = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        public List<int> temp = new List<int>(); 

        public void MoveListRight()
        {
            temp.Add(ListA[1]);
            temp.Add(ListA[2]);
            temp.Add(ListA[0]);

            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine(temp[i] + 5);
            }
        }
    }
}
