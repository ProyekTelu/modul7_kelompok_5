using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    internal class TeamMember1302213067
    {
        public void ReadJSON()
        {
            string file = File.ReadAllText(@"D:\modul7_kelompok_5\modul7_kelompok_5\jurnal7_2_1302213067.json");

            dynamic jsonFile = JsonConvert.DeserializeObject(file);

            int i = 1;
            Console.WriteLine("Team member list:");
            foreach (var member in jsonFile.members)
            {
                Console.WriteLine( member.nim + " " + member.firstName + " " + 
                    member.lastName + " " + member.age + " " + member.gender);
            }
        }
    }
}
