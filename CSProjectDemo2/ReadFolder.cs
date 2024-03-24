using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo2
{
    public class ReadFolder
    {
        private string path = "~/CSProjectDemo2/CSDemo2ConsoleApp/personel.json";
        public static List<Personel> EmployeeListRead(string path)
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Personel>>(json);
        }
    }
}
