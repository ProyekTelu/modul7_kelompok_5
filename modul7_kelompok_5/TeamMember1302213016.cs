using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    internal class TeamMember1302213016
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_kelompok_5\modul7_kelompok_5\jurnal7_2_1302213016.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("\nTeam member list:");
            int i = 1;
            foreach (var members in jsonObject.members)
            {
                Console.WriteLine($"{members.nim} {members.firstName}{members.lastName} ({members.age} {members.gender})");
                i++;
            }
        }
        
}
}
