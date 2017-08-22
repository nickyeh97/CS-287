using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath.NET
{
    public class Vector
    {
        public static int MaxId { get; set; }
        public string Name { get; set; }
        private int id;

        private double x;
        private double y;

        public double Lenght
        {
            get => Math.Sqrt(x * x + y * y);
        }

        public double X
        {
            get => x;
            set
            {
                if (value > 1000)
                    x = 1000;
                else if (value < -1000)
                    x = -1000;
                else
                    x = value;
            }
        }

        public double Y { get => y; set => y = value; }

        public int Id
        {
            get => id;
            set
            {
                id = value >= 0 ? value : 0;
            }
        }

        public Vector(double x, double y)
        {
            this.Name = "Vector-" + this.id;
            this.X = x;
            this.Y = y;
            this.Id = ++Vector.MaxId;
        }

        public Vector(Vector v)
            : this(v.x, v.y)
        {
        }

        public Vector()
            : this(0.0, 0.0)
        {
        }

        public Vector Clone()
        {
            return new Vector(this);
        }

        public override string ToString()
        {
            return string.Format("{0},{{1 }{2 }}, Lenght = {3}",
                 this.Name,
                 this.X,
                 this.Y,
                 this.Id);
        }
    }
}