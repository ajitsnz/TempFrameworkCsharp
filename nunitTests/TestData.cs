using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using SampleAutomationFramework.Models;
using System;
using System.Collections;
using System.IO;

namespace SampleAutomationFramework.nunitTests
{
    public class TestData
    {
        public static IEnumerable TransferCSVData()
        {
            var csvfileName = "TransferData.csv";

            var csvData = new CsvReader(GetCsv(csvfileName, "TestData\\UserData"));
            while (csvData.ReadNextRecord())
            {
                //if (csvData["valid"].ToString().Equals("1"))
                Transfer transfer = new Transfer(csvData["transferto"], csvData["transferfrom"], csvData["address"], csvData["amount"]);
                yield return new TestCaseData(transfer).SetName(csvData["Decription"]);
            }
        }

        public static IEnumerable UserLoginCSVData()
        {
            var csvfileName = "UserLoginData.csv";

            var csvData = new CsvReader(GetCsv(csvfileName, "TestData\\UserData"));
            while (csvData.ReadNextRecord())
            {
                if (csvData["valid"].ToString().Equals("1"))
                    yield return new TestCaseData(new User(csvData["username"], csvData["password"])).SetName(csvData["details"]);
            }
        }

        public static IEnumerable UserLoginData()
        {
            yield return new TestCaseData(new User("user1@sector36.com", "user@001")).SetName("Login Test Case (Valid)");
            yield return new TestCaseData(new User("user1@sector36.com", "23423")).SetName("Login Test Case (InValid)");
        }

        public static StreamReader GetCsv(string fileName, string path = "TestData")
        {
            return new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + $"\\{path}\\{fileName}"));
        }
    }
}
