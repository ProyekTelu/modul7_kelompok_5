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
    internal class DataMahasiswa1302210097
    {
        public void ReadJSON()
        {
            string jsonriz = File.ReadAllText(@"D:\Modul7_1302210097\modul7_kelompok_5\modul7_kelompok_5\jurnal7_1_1302210097.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(jsonriz);

    
            int i = 1;
            Console.WriteLine("Nama : " + jsonObj.firstName + " " + jsonObj.lastName + "\nGender : " + jsonObj.gender + "\nUmur : " + jsonObj.age + "\nAlamat" 
                + "\n" + jsonObj.address.streetAddress + " " + jsonObj.address.city + " " + jsonObj.address.state + "\n"
                );
            Console.WriteLine("MK YANG DIAMBIL");
            foreach (var course in jsonObj.courses)
            {
                Console.WriteLine($"MK {i} {course.code}-{course.name}");
                i++;
            }
        }
    }
}