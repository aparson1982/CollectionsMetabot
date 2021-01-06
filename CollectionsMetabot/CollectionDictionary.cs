﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMetabot
{
    public class CollectionDictionary : CollectionsProperties
    {
        internal static Dictionary<string, Collection> collectionDictionary = new Dictionary<string, Collection>();
        private static Dictionary<string, int> sessionInvokeCounter = new Dictionary<string, int>();
        internal static Collection a;
        internal static Iterator i;
        private static int insertCounter = 0;
        private static int numberOfInvokes = 0;
        private static Item item;

        public static string CollectionDictionaryInsert(string sessionName, string value)
        {
            string str = string.Empty;
            try
            {

                if (!collectionDictionary.ContainsKey(sessionName))
                {
                    a = new Collection();
                    collectionDictionary[sessionName] = a;
                    a[insertCounter] = new Item(value).Name;
                    i = a.CreateIterator();
                    str = $"Session [{sessionName}] | Updated session/value: " + a[insertCounter];
                }
                else
                {
                    a = collectionDictionary[sessionName];
                    int tempCount = a.Count;
                    //tempCount = tempCount;
                    //dictionary[key] = value;

                    a[tempCount] = new Item(value).Name;

                    i = a.CreateIterator();

                    //collectionDictionary.Add(sessionName, a);
                    //collectionDictionary[sessionName] = a;

                    str = $"Session [{sessionName}] | Updated session/value: " + a[tempCount];
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


        public static string SplitIntoDictionaryCollection(string sessionName, string input, char delimiter)
        {
            string str = string.Empty;
            try
            {
                List<string> l = input.Split(delimiter).ToList();
                for (int i = 0; i < l.Count; i++)
                {
                    str += CollectionDictionaryInsert(sessionName, l[i].Trim()) + Environment.NewLine;
                }
            }
            catch (Exception e)
            {
                ReturnStatusCode = -1;
                str = $"{ErrorIntro}" +
                    $"Message:  {e.Message} + {Environment.NewLine}" +
                    $"StackTrace:  {e.StackTrace} + {Environment.NewLine}";
            }
            return str;
        }


        private static void GetInvokeCounter(string sessionName)
        {
            try
            {

                if (!sessionInvokeCounter.ContainsKey(sessionName))
                {
                    sessionInvokeCounter[sessionName] = 0;
                }
                else
                {
                    sessionInvokeCounter[sessionName] += 1;
                }
            }
            catch (Exception e)
            {
                ReturnStatusCode = -1;
                ReturnStatusDescription = $"{ErrorIntro} Message:  {e.Message}{Environment.NewLine}";
                throw e;
            }
            
        }
    


        public static string GetElement(string sessionName)
        {
            string str = string.Empty;
            try
            {

                //if (numberOfInvokes < 1)
                //{
                //    item = i.First();
                //}
                //if (item == null)
                //{
                //    return null;
                //}
                //str = item.Name.ToString();
                //item = i.Next();
                //numberOfInvokes += 1;
                //ReturnStatusCode = 0;


                GetInvokeCounter(sessionName);
                numberOfInvokes = sessionInvokeCounter[sessionName];
                Collection a = collectionDictionary[sessionName];
                object s;
                
                if (numberOfInvokes < 1)
                {
                    a.item = i.First();
                    s = a[numberOfInvokes];
                    str = s.ToString();
                }
                if (numberOfInvokes >= a.Count)
                {
                    return null;
                }
                str = a[numberOfInvokes].ToString();
                ReturnStatusCode = 0;
            }
            catch (Exception e)
            {
                ReturnStatusCode = -1;
                str = $"{ErrorIntro}" +
                    $"Message:  {e.Message} + {Environment.NewLine}" +
                    $"StackTrace:  {e.StackTrace} + {Environment.NewLine}";
            }

            return str;
        }
    }
}
