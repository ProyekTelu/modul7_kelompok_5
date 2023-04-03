using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    internal class TeamMembers1302213116
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText(@"D:\modul7_kelompok_5\modul7_kelompok_5\jurnal7_2_1302213116.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("\nTEAM MEMBERS \n");
            foreach (dynamic obj in jsonObj.members)
            {
                Console.WriteLine($"Name\t : {obj.firstName} {obj.lastName}\n" +
                    $"Gender\t : {obj.gender}\n" +
                    $"Age\t : {obj.age}\n" +
                    $"nim\t : {obj.nim}\n");
            }
        }
    }
}
