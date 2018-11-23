using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavySampleSite.Engine;

namespace NavyUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        TextMaker tm;

        [TestInitialize]
        public void TestInitialize()
        {
            tm = new TextMaker();
        }

        [TestMethod]
        public void TestSiteName()
        {
            Assert.AreEqual(tm.SiteName,"ශ්‍රී ලංකා නාවික හමුදාව");
        }

        [TestMethod]
        public void TestEmail()
        {
            Assert.AreEqual(tm.Email,"wac@navy.lk");
        }

        [TestMethod]
        public void TestTP1()
        {
            bool chk = tm.ContactDetails.Contains("+94112210000");
            Assert.IsTrue(chk);
        }

        [TestMethod]
        public void TestTP2()
        {
            bool chk = tm.ContactDetails.Contains("+94772530934");
            Assert.IsTrue(chk);
        }

        [TestMethod]
        public void TestAddress()
        {
            bool chk = tm.ContactDetails.Contains("Naval Headquarters");
            Assert.IsTrue(chk);
        }

         [TestMethod]
        public void TestSiteDescription()
        {
            bool chk = tm.SiteDescription.Contains("most vital defence force");
            Assert.IsTrue(chk);
        }

         [TestMethod]
        public void TestSiteDescriptionLength()
        {
            int length = tm.SiteDescription.Length;
            Assert.AreEqual(length, 371);
        }

         [TestMethod]
        public void TestSecret()
        {
            string s1 = tm.SecretCode;
            string s2 = tm.CalculateMD5Hash("NAVY");

            Assert.AreEqual(s1,s2);
        }
    }
}
