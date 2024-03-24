using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo2
{
    public  class PayRoll
    {
        public static void CreatePayroll(List<Personel> personnelList)
        {
            foreach (var personnel in personnelList)
            {
                double salary = personnel.CalculateSalary();
                string fileName = $"{personnel.FullName}_Payroll_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}.json";
                string json = JsonConvert.SerializeObject(new
                {
                    EmployeeName = personnel.FullName,
                    WorkingHour = personnel.WorkingHour,
                    Salary = salary,
                }, Formatting.Indented);
                File.WriteAllText(fileName, json);
            }
        }

        public static void WorkingLessEmployee(List<Personel> personnelList)
        {
            Console.WriteLine("Personel 150 saatten az çalışmıştır.");
            foreach (var personnel in personnelList)
            {
                if (personnel.WorkingHour < 150)
                {
                    Console.WriteLine($"{personnel.FullName} : {personnel.WorkingHour} ");
                }
            }
        }
    }
}
