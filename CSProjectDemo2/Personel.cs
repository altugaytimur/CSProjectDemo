using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo2
{
    public abstract class Personel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{FirstName} {Surname}";
        public virtual int WorkingHour { get; set; }
        public virtual double HourlyRate { get; set; }
        public double Salary { get; set; }
        public virtual double CalculateSalary()
        {
            Salary = WorkingHour * HourlyRate;
            return Salary;
        }
    }
}
