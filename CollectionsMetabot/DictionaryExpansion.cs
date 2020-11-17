using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMetabot
{
    public class DictionaryExpansion : CollectionsProperties
    {
        internal static Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<int, string>>>> nDictionary = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<int, string>>>>();

        
        public static string DicExUpdateValue(string SessionName, string SubSession, string ColName, int Row, string value)
        {
            string str = string.Empty;
            try
            {
                if (!nDictionary.ContainsKey(SessionName))
                {
                    nDictionary[SessionName] = new Dictionary<string, Dictionary<string, Dictionary<int, string>>>();
                }
                if(!nDictionary[SessionName].ContainsKey(SubSession))
                {
                    nDictionary[SessionName][SubSession] = new Dictionary<string, Dictionary<int, string>>();
                }
                if(!nDictionary[SessionName][SubSession].ContainsKey(ColName))
                {
                    nDictionary[SessionName][SubSession][ColName] = new Dictionary<int, string>();
                }

                if (nDictionary[SessionName][SubSession][ColName].ContainsKey(Row))
                {
                    nDictionary[SessionName][SubSession][ColName][Row] = value;
                    str = $"Session [{SessionName}>{SubSession} | Updated key/value: {ColName}{Row} :: {value}";
                    ReturnStatusCode = 0;
                }
                else
                {
                    nDictionary[SessionName][SubSession][ColName].Add(Row, value);
                    str = $"Session [{SessionName}>{SubSession} | Added key/value: {ColName}{Row} :: {value}";
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


        public static string DicExGetValue(string SessionName, string SubSession, string ColName, int Row)
        {
            string str = string.Empty;
            try
            {
                str = nDictionary[SessionName][SubSession][ColName][Row];
                ReturnStatusCode = 0;
            }
            catch (Exception e)
            {

                ReturnStatusCode = -1;
                str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
            }
            return str;
        }

        public static string DicExGetSessionLength(string SessionName)
        {
            string str = string.Empty;
            try
            {
                str = nDictionary[SessionName].Count.ToString();
                ReturnStatusCode = 0;
            }
            catch (Exception e)
            {
                ReturnStatusCode = -1;
                str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
            }
            return str;
        }

        public static string DicExGetSubSessionLength(string SessionName, string SubSession)
        {
            string str = string.Empty;
            try
            {
                str = nDictionary[SessionName][SubSession].Count.ToString();
                ReturnStatusCode = 0;
            }
            catch (Exception e)
            {
                ReturnStatusCode = -1;
                str = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
            }
            return str;
        }

        public static string DicExGetColLength(string SessionName, string SubSession, string ColName)
        {
            string str = string.Empty;
            try
            {
                str = nDictionary[SessionName][SubSession][ColName].Count.ToString();
                ReturnStatusCode = 0;
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
