using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMetabot
{
    public class CollectionWrapper : CollectionsProperties
    {
        internal static Collection a = new Collection();
        internal static Iterator i;
        private static int insertCounter = 0;
        private static int numberOfInvokes = 0;
        private static Item item;

        public static string Insert(string input)
        {
            string str = string.Empty;
            try
            {
                a[insertCounter] = new Item(input);
                str = $"Inserted {input} at index [{insertCounter}]";
                insertCounter += 1;
                i = a.CreateIterator();
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

        public static string SplitIntoCollection(string input, char delimiter)
        {
            string str = string.Empty;
            try
            {
                List<string> l = input.Split(delimiter).ToList();
                str = l.Aggregate(str, (current, t) => current + (Insert(t.Trim()) + Environment.NewLine));
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


        public static string GetElement()
        {
            string str = string.Empty;
            try
            {
                if (numberOfInvokes < 1)
                {
                    item = i.First();
                }
                if (item == null)
                {
                    return null;
                }
                str = item.Name.ToString();
                item = i.Next();
                numberOfInvokes += 1;
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

        public static string GetElementAt(int index)
        {
            string str = string.Empty;
            try
            {
                Item ob = (Item)a[index];
                str = ob.Name;
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


        public static string GetCount()
        {
            string str = string.Empty;
            try
            {
                str = a.Count.ToString();
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


        public static string ClearCollection()
        {
            string str = string.Empty;
            try
            {
                a.Demolish();
                numberOfInvokes = 0;
                insertCounter = 0;
                str = true.ToString();
                ReturnStatusCode = 0;
            }
            catch (Exception)
            {
                ReturnStatusCode = -1;
                str = false.ToString();
            }
            return str;
        }
    }
}
