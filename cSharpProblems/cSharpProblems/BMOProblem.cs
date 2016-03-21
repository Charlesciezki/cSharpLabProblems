using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpProblems
{
    class BMOProblem
    {
        List<string> BMOmoveList = new List<string>();

        public void BMOMoves()
        {
            BMOmoveList.Add("Up");
            BMOmoveList.Add("Down");
            BMOmoveList.Add("Left");
            BMOmoveList.Add("Left");
            BMOmoveList.Add("Right");
            BMOmoveList.Add("Right");
            BMOmoveList.Add("Down");
            BMOmoveList.Add("Spin");
            BMOmoveList.Add("Down");
            BMOmoveList.Add("Up");
            BMOmoveList.Add("Left");
            BMOmoveList.Add("Right");
            BMOmoveList.Add("Left");
            BMOmoveList.Add("Down");
            BMOmoveList.Add("Spin");
            BMOmoveList.Add("Up");
            BMOmoveList.Add("Down");
            BMOmoveList.Add("Jump");

            for (int i = 0; i < BMOmoveList.Count; i++)
            {
                Console.WriteLine(BMOmoveList[i]);
            }
        }
    }
}
