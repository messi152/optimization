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
            var textArr = input.Split('-');
            var ouput = TranslateTitle(input, language);
            if (textArr.Length == 3)
            {
                ouput = "";
                if (StringUtils.IsNotEmpty(textArr[0]))
                    ouput += TranslateTitle(textArr[0], language);
                ouput += " " + textArr[1] + " ";
                if (StringUtils.IsNotEmpty(textArr[2]))
                    ouput += TranslateTitle(textArr[2], language);
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
