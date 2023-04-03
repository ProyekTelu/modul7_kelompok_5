using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    internal class DataMahasiswa1302213016
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"D:\modul7_kelompok_5\modul7_kelompok_5\jurnal7_1_1302213016.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Nama: "+ jsonObject.firstName + jsonObject.lastName +"\nGender: "+ jsonObject.gender + 
                "\nUmur: "+ jsonObject.age +"\nAlamat: "+ jsonObject.address.streetAddress+", " + jsonObject.address.city+", " + jsonObject.address.state);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in jsonObject.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}