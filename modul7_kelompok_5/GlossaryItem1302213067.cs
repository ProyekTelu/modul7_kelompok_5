using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    internal class GlossaryItem1302213067
    {
        public void ReadJson()
        {

            string file = File.ReadAllText(@"D:\modul7_kelompok_5\modul7_kelompok_5\jurnal7_3_1302213067.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(file);

            Console.WriteLine("\nGlossEntry:");
            Console.WriteLine("ID: " + jsonObject.glossary.GlossDiv.GlossList.GlossEntry.ID
                + "\nSortAs: " + jsonObject.glossary.GlossDiv.GlossList.GlossEntry.SortAs
                + "\nGlossTerm: " + jsonObject.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm
                + "\nAcronym: " + jsonObject.glossary.GlossDiv.GlossList.GlossEntry.Acronym
                + "\nAbbrev: " + jsonObject.glossary.GlossDiv.GlossList.GlossEntry.Abbrev
                + "\nGlossDef: \n     para: " + jsonObject.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para
                + "\n     GlossSeeAlso: " + jsonObject.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[0]
                + ", " + jsonObject.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[1]
                + "\nGlossSee: " + jsonObject.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
        }
    }
}
