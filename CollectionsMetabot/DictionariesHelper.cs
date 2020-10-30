using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMetabot
{
    public class Class1
    {
        internal Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public string DictionaryUpdateValue(string key, string value)
        {
            string str = string.Empty;
            try
            {
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key] = value;

                    str = "Updated key/value: " + dictionary[key].ToString() + "/" + value;
                }
                else
                {
                    dictionary.Add(key, value);
                    str = "Added key/value: " + dictionary[key].ToString() + "/" + value;
                }
            }
            catch (Exception e)
            {
                str = e.Message + Environment.NewLine;
            }

            return str;
        }

        public string DictionaryGetValue(string key, string value)
        {
            string str = string.Empty;
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
