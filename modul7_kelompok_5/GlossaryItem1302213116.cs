using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    internal class GlossaryItem1302213116
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText(@"D:\modul7_kelompok_5\modul7_kelompok_5\jurnal7_3_1302213116.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(jsonString);

            dynamic GlossEntry = jsonObj.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine($"\nID\t\t : {GlossEntry.ID}\n" +
                $"Sort As\t\t : {GlossEntry.SortAs}\n" +
                $"Gloss Term\t : {GlossEntry.GlossTerm}\n" +
                $"Acronym\t\t : {GlossEntry.Acronym}\n" +
                $"Abbrev\t\t : {GlossEntry.Abbrev}\n" +
                $"-Gloss Def-\n" +
                $">Para\t\t : {GlossEntry.GlossDef.para}\n" +
                $">Gloss See Also\t : {GlossEntry.GlossDef.GlossSeeAlso[0]} & {GlossEntry.GlossDef.GlossSeeAlso[1]}\n" +
                $"Gloss See\t : {GlossEntry.GlossSee}");
        }
    }
}
