using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo2
{
    public class Officer:Personel
    {
        private const int MaxWorkingHour = 180;
        private const double OvertimeCoefficient = 1.5;
        public override double HourlyRate { get; set; } = 500;
        public override double CalculateSalary()
        {
            double salary;
            if (WorkingHour <= MaxWorkingHour)
            {
                salary = WorkingHour * HourlyRate;
            }
            else
            {
                int overwork = WorkingHour - MaxWorkingHour;
                salary = (MaxWorkingHour * HourlyRate) + (overwork * HourlyRate * OvertimeCoefficient);
            }
            return salary;
        }
    }
}
