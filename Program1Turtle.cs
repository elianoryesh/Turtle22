using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Unit4.TurtleLib;

namespace Turtle22
{
    partial class Program
    {

        static Random rnd = new Random();
        /// <summary>
        /// Turtle program
        /// </summary>
        static void Main1()
        {

            double x = 0;
            double y = 0;
            Turtle t1 = new Turtle();

            //t1.MoveBackward(200);
            t1.SetDelay(10);
            t1.TailUp();


            t1.MoveForward(180);
            t1.TurnLeft(90);
            t1.MoveBackward(180);
            t1.TailDown();


            t1.MoveForward(360);

            //x = Math.Round(t1.GetXLocation(), 2);
            //y = Math.Round(t1.GetYLocation(), 2);
            //Console.WriteLine($"x1: {x}, y: {y}  ");

            t1.TurnLeft(90);
            t1.MoveForward(360);

            //x = Math.Round(t1.GetXLocation(), 2);
            //y = Math.Round(t1.GetYLocation(), 2);
            //Console.WriteLine($"x1: {x}, y: {y}  ");


            t1.TurnLeft(90);
            t1.MoveForward(360);

            //x = Math.Round(t1.GetXLocation(), 2);
            //y = Math.Round(t1.GetYLocation(), 2);
            //Console.WriteLine($"x1: {x}, y: {y}  ");
           
            
            t1.TurnLeft(90);
            t1.MoveForward(360);

            //x = Math.Round(t1.GetXLocation(), 2);
            //y = Math.Round(t1.GetYLocation(), 2);
            //Console.WriteLine($"x1: {x}, y: {y}  ");
           
            
            t1.TailUp();
            t1.MoveBackward(261);
            t1.TurnLeft(90);
            t1.MoveForward(20);
            t1.TurnLeft(60.5);
            t1.TailDown();

            //x =  Math.Round (t1.GetXLocation(),2);
            //y =  Math.Round (t1.GetYLocation(),2);
            //Console.WriteLine($"x1: {x}, y: {y}  "  );

            double step = 100 * 2 * Math.PI / 36;
            for (int i = 0; i < 73; i++)
            {

                t1.MoveForward(15.667);
                t1.TurnRight(5);

            }

            double x1, y1;

            for (int i = 0; i < 10; i++)
            {
                x1 = rnd.NextDouble() * 360 - 180;
                y1 = rnd.NextDouble() * 360 - 180;

                Console.WriteLine($"x1: {x1}, y: {y1}  ");
            }





        }
    }
}
