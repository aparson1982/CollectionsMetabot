using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMetabot
{
    public class DictionaryHelper : CollectionsProperties
    {
        
        internal static Dictionary<string, Dictionary<string, string>> dictionaryOfDictionaries = new Dictionary<string, Dictionary<string, string>>();

        public static string DictionaryUpdateValue(string key, string value, string sessionName)
        {
            string str = string.Empty;
            try
            {
                if (!dictionaryOfDictionaries.ContainsKey(sessionName))
                {
                    dictionaryOfDictionaries[sessionName] = new Dictionary<string, string>();
                }
                
                if (dictionaryOfDictionaries[sessionName].ContainsKey(key))
                {
                    //dictionary[key] = value;
                    dictionaryOfDictionaries[sessionName][key] = value;

                    str = $"Session [{sessionName}] | Updated key/value: " + key + " :: " + value;
                    ReturnStatusCode = 0;
                }
                else
                {
                    dictionaryOfDictionaries[sessionName].Add(key, value);
                    //dictionary.Add(key, value);
                    str = $"Session [{sessionName}] | Added key/value: " + key + " :: " + value;
                    ReturnStatusCode = 0;
                }
            }
            catch (Exception e)
            {
                ReturnStatusCode = -1;
                str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
            }

            return str;
        }

        public static string DictionaryGetValue(string key, string sessionName)
        {
            string str = string.Empty;
            try
            {
                str = dictionaryOfDictionaries[sessionName][key];
            }
            catch (Exception e)
            {
                ReturnStatusCode = -1;
                str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
            }
            return str;
        }

        public static string DictionaryGetKey(string value, string sessionName)
        {
            string str = string.Empty;
            try
            {
                IEnumerable<string> keys = dictionaryOfDictionaries[sessionName].Where(pair => pair.Value == value).Select(pair => pair.Key);
                
                str = string.Join(", ", keys.ToArray());
                ReturnStatusCode = 0;
            }
            catch (Exception e)
            {
                ReturnStatusCode = -1;
                str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
            }
            return str;
        }

        public static string DictionaryClearAllDictionaries()
        {
            string str = string.Empty;
            try
            {
                try
                {
                    dictionaryOfDictionaries.Clear();
                    ReturnStatusCode = 0;
                }
                catch (Exception e)
                {
                    ReturnStatusCode = -1;
                    str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
                }
                try
                {
                    DictionaryExpansion.nDictionary.Clear();
                    ReturnStatusCode = 0;
                }
                catch (Exception e)
                {
                    ReturnStatusCode = -1;
                    str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
                }
                
            }
            catch (Exception e)
            {
                ReturnStatusCode = -1;
                str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
            }
            return str;
        }

        public static string DictionaryClearContents(string sessionName)
        {
            string str = string.Empty;
            try
            {
                try
                {
                    dictionaryOfDictionaries[sessionName].Clear();
                    ReturnStatusCode = 0;
                }
                catch (Exception e)
                {
                    ReturnStatusCode = -1;
                    str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
                }

                try
                {
                    DictionaryExpansion.nDictionary[sessionName].Clear();
                    ReturnStatusCode = 0;
                }
                catch (Exception e)
                {
                    ReturnStatusCode = -1;
                    str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
                }
                
            }
            catch (Exception e)
            {
                ReturnStatusCode = -1;
                str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
            }
            return str;
        }

    }
}
