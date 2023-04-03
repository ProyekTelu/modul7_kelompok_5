using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul7_kelompok_5
{
    internal class DataMahasiswa1302213116
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText(@"D:\modul7_kelompok_5\modul7_kelompok_5\jurnal7_1_1302213116.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"DATA DIRI MAHASISWA \n" +
                $"Name\t\t : {jsonObj.firstName} {jsonObj.lastName}\n" +
                $"Gender\t\t : {jsonObj.gender}\n" +
                $"-Address- \n" +
                $">Street Address\t : {jsonObj.address.streetAddress}\n" +
                $">City\t\t : {jsonObj.address.city}\n" +
                $">State\t\t : {jsonObj.address.state}\n" +
                $"-Courses-");
            foreach ( dynamic obj in jsonObj.courses ) { 
                Console.WriteLine($">Code : {obj.code} Name : {obj.name}");
            }
        }
    }
}
