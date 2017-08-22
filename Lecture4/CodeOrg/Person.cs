using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Org
{
    public class Person
    {
        public string Name;
        public Position Pos;
        public double Theta;

        public void MoveForward(double d)
        {
            Pos.x = Pos.x + d * Math.Cos(Theta * Math.PI / 180.0);
            Pos.y = Pos.y + d * Math.Sin(Theta * Math.PI / 180.0);
        }

        public void TurnRight(double theta)
        {
            Theta += theta;
            //弧度運算Bug解決方式
            Theta %= 360.0;
        }

        public void WriteLine()
        {
            Console.WriteLine("{0}的位置在({1},{2}) 方位角:{3}",
                Name,
                Pos.x,
                Pos.y,
                Theta);
        }

        public bool isHappy()
        {
            if (Pos.x >= 100 && Pos.y > 100)
                return true;
            else
                return false;
        }
    }
}