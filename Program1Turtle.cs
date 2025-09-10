using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.TurtleLib;

namespace Turtle22
{
    internal partial class Program
    {
        /// <summary>
        /// Turtle program
        /// </summary>
        static void Main1()
        {
            Turtle t1 = new Turtle();

            //t1.MoveBackward(200);
            t1.SetDelay(2);
            t1.TailUp();


            t1.MoveForward(180);
            t1.TurnLeft(90);
            t1.MoveBackward(135);
            t1.TailDown();
            t1.MoveForward(360);
            t1.TurnLeft(90);
            t1.MoveForward(360);
            t1.TurnLeft(90);
            t1.MoveForward(360);
            t1.TurnLeft(90);
            t1.MoveForward(360);
            t1.TailUp();
            t1.MoveBackward(255);
            t1.TurnLeft(90);
            t1.MoveForward(20);
            t1.TurnLeft(60.5);
            t1.TailDown();

            double step = 100 * 2 * Math.PI / 36;
            for (int i = 0; i < 73; i++)
            {

                t1.MoveForward(15.667);
                t1.TurnRight(5);

            }



        }
    }
}
