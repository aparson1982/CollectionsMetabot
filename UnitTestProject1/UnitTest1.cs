using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionsMetabot;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(CollectionWrapper.Insert("Row 0"));
            Console.WriteLine(CollectionWrapper.Insert("Row 2"));
            Console.WriteLine(CollectionWrapper.Insert("Row 4"));
            Console.WriteLine(CollectionWrapper.Insert("Row 5"));
            Console.WriteLine(CollectionWrapper.Insert("Row 6"));
            Console.WriteLine("***");
            Console.WriteLine(CollectionWrapper.GetElement());
            Console.WriteLine(CollectionWrapper.GetElement());
            Console.WriteLine(CollectionWrapper.GetElement());
            Console.WriteLine(CollectionWrapper.GetElement());
            Console.WriteLine(CollectionWrapper.GetElement());
            Console.WriteLine(CollectionWrapper.GetElement());
            Console.WriteLine(CollectionWrapper.GetElement());
            Console.WriteLine("***");
            Console.WriteLine(CollectionWrapper.GetElementAt(1));
            Console.WriteLine(CollectionWrapper.GetElementAt(0));

            Console.WriteLine(CollectionWrapper.GetCount());

            Console.WriteLine(CollectionWrapper.ClearCollection());
            Console.WriteLine(CollectionWrapper.ClearCollection());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Acct", 1, "0002190"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "AcctName", 1, "Ziem'S Carpet Workroom, Inc."));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "City", 1, "Bloomington"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "State", 1, "MN"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Zip", 1, "55420"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Status", 1, "A"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Territory", 1, "Henry, Allen-0617(P) 0617"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "SellCo", 1, "42"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Div", 1, "01"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Region", 1, "019"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "NewTerritory", 1, "0123"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "NewTerritoryName", 1, "John Doe"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "EffectiveDate", 1, "Jan 4 2021"));

            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Acct", 2, "0002190"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "AcctName", 2, "Ziem'S Carpet Workroom, Inc."));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "City", 2, "Bloomington"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "State", 2, "MN"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Zip", 2, "55420"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Status", 2, "A"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Territory", 2, "Henry, Allen-0617(P) 0617"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "SellCo", 2, "43"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Div", 2, "01"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Region", 2, "019"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "NewTerritory", 2, "0123"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "NewTerritoryName", 2, "John Doe"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "EffectiveDate", 2, "Jan 4 2021"));

            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Acct", 3, "0002190"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "AcctName", 3, "Ziem'S Carpet Workroom, Inc."));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "City", 3, "Bloomington"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "State", 3, "MN"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Zip", 3, "55420"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Status", 3, "A"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Territory", 3, "Henry, Allen-0617(P) 0617"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "SellCo", 3, "42"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Div", 3, ""));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "Region", 3, ""));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "NewTerritory", 3, "0123"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "NewTerritoryName", 3, "John Doe"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRows", "Sub1", "EffectiveDate", 3, "Jan 4 2021"));

            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "Acct", 3, "0002190"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "AcctName", 3, "Ziem'S Carpet Workroom, Inc."));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "City", 3, "Bloomington"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "State", 3, "MN"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "Zip", 3, "55420"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "Status", 3, "A"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "Territory", 3, "Henry, Allen-0617(P) 0617"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "SellCo", 3, "42"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "Div", 3, ""));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "Region", 3, ""));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "NewTerritory", 3, "0123"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "NewTerritoryName", 3, "John Doe"));
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"AcctTerrRow", "Sub1", "EffectiveDate", 3, "Jan 4 2021"));

            Console.WriteLine(DictionaryExpansion.DicExGetDictionaryLength());
            Console.WriteLine(DictionaryExpansion.DicExGetSessionLength($@"AcctTerrRows"));
            Console.WriteLine(DictionaryExpansion.DicExGetSubSessionLength($@"AcctTerrRows", "Sub1"));
            Console.WriteLine(DictionaryExpansion.DicExGetColLength($@"AcctTerrRows", "Sub1","Acct"));

        }

        [TestMethod]
        public void TestCollectionDictionary()
        {
            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session1", "Row001"));
            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session1", "Row002"));
            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session1", "Row003"));
            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session1", "Row004"));
            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session1", "Row005"));

            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session2", "Row010"));
            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session2", "Row011"));
            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session2", "Row012"));
            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session2", "Row013"));


            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session1", "Row006"));
            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session1", "Row007"));
            Console.WriteLine(CollectionDictionary.CollectionDictionaryInsert("Session2", "Row014"));



            Console.WriteLine(CollectionDictionary.GetElement("Session1"));
            Console.WriteLine(CollectionDictionary.GetElement("Session1"));
            Console.WriteLine(CollectionDictionary.GetElement("Session1"));
            Console.WriteLine(CollectionDictionary.GetElement("Session2"));
            Console.WriteLine(CollectionDictionary.GetElement("Session2"));
            Console.WriteLine(CollectionDictionary.GetElement("Session2"));
            Console.WriteLine(CollectionDictionary.GetElement("Session2"));
            Console.WriteLine(CollectionDictionary.GetElement("Session2"));
            Console.WriteLine(CollectionDictionary.GetElement("Session2"));
            Console.WriteLine(CollectionDictionary.GetElement("Session2"));
            Console.WriteLine(CollectionDictionary.GetElement("Session2"));
            Console.WriteLine(CollectionDictionary.GetElement("Session2"));
            Console.WriteLine(CollectionDictionary.GetElement("Session2"));
            Console.WriteLine(CollectionDictionary.GetElement("Session1"));
            Console.WriteLine(CollectionDictionary.GetElement("Session1"));
            Console.WriteLine(CollectionDictionary.GetElement("Session1"));
            Console.WriteLine(CollectionDictionary.GetElement("Session1"));
            Console.WriteLine(CollectionDictionary.GetElement("Session1"));
            Console.WriteLine(CollectionDictionary.GetElement("Session1"));




        }
    }
}
