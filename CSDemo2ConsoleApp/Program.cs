using CSProjectDemo2;
using Newtonsoft.Json;
using System.Xml;

Console.WriteLine("Enter JSON file path:");
string jsonFilePath = Console.ReadLine();

string json = File.ReadAllText(jsonFilePath);
List<Personel> personnelList = JsonConvert.DeserializeObject<List<Personel>>(json);

List<string> reports = new List<string>();

foreach (var personel in personnelList)
{
    Console.WriteLine($"Enter working hour for {personel.FullName}:");
    personel.WorkingHour = Convert.ToInt32(Console.ReadLine());

    double salary = personel.CalculateSalary();

    if (personel.WorkingHour < 150)
    {
        reports.Add($"{personel.FullName} worked less than 150 hours.");
    }

    string report = JsonConvert.SerializeObject(new
    {
        Name = personel.FullName,
        WorkingHour = personel.WorkingHour,
        Salary = salary
    }, Newtonsoft.Json.Formatting.Indented);

    reports.Add(report);
}

Console.WriteLine("\nSalary Report:");
foreach (var report in reports)
{
    Console.WriteLine(report);
}

Console.ReadLine();
