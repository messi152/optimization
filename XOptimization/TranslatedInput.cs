using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOptimization
{
    public class TranslatedInput
    {
        [Index(0)]
        public string Word { get; set; }
        [Index(1)]
        public string TranslatedWord { get; set; }
    }
    public class TranslatedInputMap : ClassMap<TranslatedInput>
    {
        public TranslatedInputMap()
        {
            Map(p => p.Word).Index(0);
            Map(p => p.TranslatedWord).Index(1);
        }
    }
}
