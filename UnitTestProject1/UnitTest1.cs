﻿using System;
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
            Console.WriteLine(DictionaryHelper.DictionaryUpdateValue($@"PathFile\of\SomeExcelFile.xlsx", "2", "Adam"));

            Console.WriteLine(DictionaryHelper.DictionaryGetValue($@"PathFile\of\SomeExcelFile.xlsx", "Adam"));

            Console.WriteLine(DictionaryHelper.DictionaryUpdateValue($@"PathFile\of\SomeExcelFile.xlsx", "3", "Eric"));

            Console.WriteLine(DictionaryHelper.DictionaryGetValue($@"PathFile\of\SomeExcelFile.xlsx", "Eric"));

            Console.WriteLine(DictionaryHelper.DictionaryUpdateValue($@"PathFile\of\SomeExcelFiles.xlsx", "3", "Adam"));

            Console.WriteLine(DictionaryHelper.DictionaryGetKey($@"3", "Eric"));

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
