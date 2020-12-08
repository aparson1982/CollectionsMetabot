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

            DictionaryHelper.DictionaryUpdateValue("Adam", "1", "S2.xlsx");
            DictionaryHelper.DictionaryUpdateValue("Tommie", "2", "S3.xlsx");
            DictionaryHelper.DictionaryUpdateValue("Chris", "0", "S1.xlsx");
            DictionaryHelper.DictionaryUpdateValue("Chris", "2", "S3.xlsx");
            DictionaryHelper.DictionaryUpdateValue("Tommie", "1", "S2.xlsx");
            
            
            string str1 = string.Empty;
            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    str1 += DictionaryHelper.DictionaryGetKey($"{i}", $"S{j}.xlsx") + " ";
                }
            }
            

            Console.WriteLine(str1);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"PathFile\of\SomeExcelFile.xlsx", "Sheet1", "A", 1, "Adam"));

            Console.WriteLine(DictionaryExpansion.DicExUpdateValue($@"PathFile\of\SomeExcelFile.xlsx", "Sheet1", "B", 1, "Beavis"));

            Console.WriteLine(DictionaryExpansion.DicExGetValue($@"PathFile\of\SomeExcelFile.xlsx","Sheet1","A",1));

            

        }
    }
}
