using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ListAndStringCount Problem1 = new ListAndStringCount();
            int stringCount = Problem1.countInput();
            int listCount = Problem1.countInputList();
            
            ThePiProblem piProblem = new ThePiProblem();
            string PI = piProblem.pi();
           
            BMOProblem BMO = new BMOProblem();
            BMO.BMOMoves();
            
            MoveTheList theList = new MoveTheList();
            theList.MoveListRight();

            DanceMan daDanceMan = new DanceMan();
            for (int i = 0; i < 5; i++)
            {
                Console.ReadLine();
                if (i%2 == 0)
                {
                    string DaDanceMan = daDanceMan.MoveArmDown();
                    Console.WriteLine(DaDanceMan);
                }
                else
                {
                    string theDanceMan = daDanceMan.MoveArmUp();
                    Console.WriteLine(theDanceMan);
                }


            }
            
            
            //Console.ReadLine();
        }
    }
}
