using Microsoft.VisualStudio.TestTools.UnitTesting;
using BestNote_cs;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestNote_cs.Tests
{
    [TestClass()]
    public class DataManagerByMySQLTests
    {
        [TestMethod()]
        public void getFileListTest()
        {
            DataManagerByMySQL dataMananger = new DataManagerByMySQL();
            ArrayList retData = dataMananger.getFileList("research");
            foreach (var item in retData)
            {
                Console.WriteLine(item);
            }
            dataMananger.close();
//            Assert.Fail();
        }

        [TestMethod()]
        public void getFolderListTest()
        {
            DataManagerByMySQL dataManager = new DataManagerByMySQL();
            ArrayList retData = dataManager.getFolderList();
            foreach (var item in retData)
            {
                Console.WriteLine(item);
            }
            dataManager.close();
//            Assert.Fail();
        }
    }
}