using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bug_Tracker.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.DAO.Tests
{
    [TestClass()]
    public class BugDAOTests
    {
        [TestMethod()]
        public void getAllBugsTest()
        {

            BugDAO bugDAO = new BugDAO();
            List<Bug> bug = null;

            try
            {
                bug = bugDAO.getAllBugs();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Assert.AreEqual("", bug);
        }


        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getAllBugsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllBugsByProgrammerIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BugFixedTest()
        {
            Assert.Fail();
        }
    }
}