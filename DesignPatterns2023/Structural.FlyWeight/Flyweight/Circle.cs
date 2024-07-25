using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.FlyWeight
{
    public class Circle : IShape
    {
        //the Circle class has both intrinsic and extrinsic state objects
        public string Color { get; set; }
        private int XCor = 10;  //intrinsic values. add storage 
        private int YCor = 20;
        private int Radius = 30;

        //set color for the circle
        public void SetColor(string Color) //take in the extrinsic value at runtime.
        {
            this.Color = Color;
        }
        //draw the circle
        public void Draw() // extrinsic 
        {
            Console.WriteLine(" Circle: Draw() [Color : " + Color + ", X Cor : " + XCor + ", YCor :" + YCor + ", Radius :" + Radius);
        }
    }
}
