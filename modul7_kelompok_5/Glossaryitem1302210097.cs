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
    internal class Glossaryitem1302210097
    {
        public void ReadJSON()
        {
            string jsonriz = File.ReadAllText(@"D:\Modul7_1302210097\modul7_kelompok_5\modul7_kelompok_5\jurnal7_3_1302210097.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(jsonriz);

            Console.WriteLine("\nGlossEntry");
            Console.WriteLine("ID: " + jsonObj.glossary.GlossDiv.GlossList.GlossEntry.ID
                + "\nSortAs: " + jsonObj.glossary.GlossDiv.GlossList.GlossEntry.SortAs
                + "\nGlossTerm: " + jsonObj.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm
                + "\nAcronym: " + jsonObj.glossary.GlossDiv.GlossList.GlossEntry.Acronym
                + "\nAbbrev: " + jsonObj.glossary.GlossDiv.GlossList.GlossEntry.Abbrev
                + "\nGlossDef: \n     para: " + jsonObj.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para
                + "\n     GlossSeeAlso: " + jsonObj.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[0]
                + ", " + jsonObj.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[1]
                + "\nGlossSee: " + jsonObj.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);

        }
    }
}