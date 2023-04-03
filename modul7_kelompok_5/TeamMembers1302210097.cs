using System;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace modul7_kelompok_5
{
    internal class TeamMembers1302210097
    {
        public void ReadJSON()
        {
            string jsonriz = File.ReadAllText(@"D:\Modul7_1302210097\modul7_kelompok_5\modul7_kelompok_5\jurnal7_2_1302210097.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(jsonriz);


            int i = 1;
            Console.WriteLine("\nTEAM MEMBERS LIST");
            foreach (var members in jsonObj.members)
            {
                Console.WriteLine( members.firstName + " " + members.lastName + " " + members.gender +" "+ members.age + " " + members.nim);
                i++;
            }
        }
    }
}