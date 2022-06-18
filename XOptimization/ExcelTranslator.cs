using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOptimization
{
    class ExcelTranslator : ITranslator
    {
        string Source;
        public ExcelTranslator(string source)
        {
            this.Source = source;
        }
        public string Execute(string input, string language)
        {
            using (var reader = new StreamReader(Source))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<TranslatedInputMap>();
                var records = csv.GetRecords<TranslatedInput>();
                List<TranslatedInput> translatedInputList = records.ToList();
                if (translatedInputList!=null && translatedInputList.Count>0)
                {
                    foreach(TranslatedInput translatedInput in translatedInputList)
                    {
                        if (translatedInput.Word.Trim().ToUpper().Equals(input.Trim().ToUpper()))
                        {
                            return translatedInput.TranslatedWord;
                        }
                    }
                }
            }
            return input;
        }
    }
}
