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

            Console.WriteLine("\nTeam member list: ");
            foreach (dynamic obj in jsonObj.members)
            {
                Console.WriteLine($"{obj.nim} {obj.firstName} {obj.lastName} ({obj.age} {obj.gender})");
            }
        }
    }
}
