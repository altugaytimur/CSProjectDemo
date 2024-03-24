using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo2
{
    public class Manager:Personel
    {
        private const double MinSalary = 500;
        private double Prim { get; set; }
        public override double CalculateSalary()
        {
            double salary = WorkingHour * HourlyRate;
            if (salary < MinSalary)
            {
                salary = MinSalary;
            }
            salary += Prim;
            return salary;
        }
    }
}
