using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employees
    {
        public string Name { get; set; }
        public static int MaxId { get; set; }

        private string id;

        private int baseSalary;

        private int benifit;

        public int Benifit
        {
            get => benifit;
            set
            {
                if (value > 5000)
                {
                    benifit = 5000;
                }
                else if (value < 1000)
                {
                    benifit = 1000;
                }
                else
                {
                    benifit = value;
                }
            }
        }

        public int BaseSalary
        {
            get => baseSalary;
            set
            {
                if (value > 43000)
                {
                    baseSalary = 43000;
                }
                else if (value < 22000)
                {
                    baseSalary = 22000;
                }
                else
                {
                    baseSalary = value;
                }
            }
        }

        public int getSalary()
        {
            return this.BaseSalary + this.Benifit;
        }

        public string Id
        {
            get => id;
        }

        public Employees(string name, int baseSalary, int benifit)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.Benifit = benifit;
            this.id = "NTU" + (++Employees.MaxId);
        }

        public override string ToString()
        {
            return string.Format("員工姓名:{0},BaseSalary:{1},Benifit:{2},員工新水:{3}",
                 this.Name,
                 this.BaseSalary,
                 this.Benifit,
                 this.getSalary());
        }
    }
}