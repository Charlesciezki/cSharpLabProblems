using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpProblems
{
    class DanceMan
    {
        public string danceMan;

            public string MoveArmUp()
            {
        danceMan = @"                     *  * 
                   *      * 
                     *  *        * 
                       *      * 
                   *  *  * 
                 *    *     
               *      *       
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      *

";
                return danceMan;
            }

        public string MoveArmDown()
        {
        danceMan = @"                     *  * 
                   *  :)    * 
                     *  *         
                       *      
                   *  *  * 
                 *    *     *
               *      *       *
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      *";
            return danceMan;
        }
        }
}
