using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOptimization
{
    public interface ITranslator
    {
         string Execute(string input, string language);
    }
}
