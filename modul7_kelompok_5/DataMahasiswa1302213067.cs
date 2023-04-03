using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    internal class DataMahasiswa1302213067
    {
        public void ReadJSON()
        {
            string file = File.ReadAllText(@"D:\modul7_kelompok_5\modul7_kelompok_5\jurnal7_1_1302213067.json");

            dynamic jsonFile = JsonConvert.DeserializeObject(file);
            
            int i = 1;
            Console.WriteLine("Nama : " + jsonFile.firstName + " " + jsonFile.lastName + " \n" + "Gender : " + 
                jsonFile.gender + " \n" + "Umur : " + jsonFile.age + " \n" + "Alamat : " + 
                jsonFile.address.streetAddress + " " + jsonFile.address.city + " " + jsonFile.address.state);

            foreach (var c in jsonFile.courses)
            {
                Console.WriteLine("MK " + i + " " + c.code + "-" + c.name);
                i++;
            }
            
        }
    }
}
