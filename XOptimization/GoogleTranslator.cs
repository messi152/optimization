using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace XOptimization
{
    class GoogleTranslator : ITranslator
    {
        public string Execute(string input, string language)
        {
            var ouput = "";
            if (!input.Contains("[") && !input.Contains("]")) return TranslateWord(input, language);
            var textArr = input.Split('[');
            if (StringUtils.IsNotEmpty(textArr[0]))
                ouput += TranslateWord(textArr[0], language);
            if (StringUtils.IsNotEmpty(textArr[1])) { 
                textArr = textArr[1].Split(']');
                ouput += " " + textArr[0] + " ";
                if (StringUtils.IsNotEmpty(textArr[1]))
                    ouput += TranslateWord(textArr[1], language);
            }
            return ouput.Trim();
        }
        private string TranslateWord(string input, string language)
        {
            var ouput = "";
            var textArr = input.Split('.');
            foreach(string text in textArr)
            {
                if (StringUtils.IsNotEmpty(text))
                    ouput += TranslateTitle(text, language)+" ";
            }
            return ouput;
        }
        private string TranslateTitle(string input, string language)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                "en", language, Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }
    }
}
