using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPO.Logic;

namespace TPO.Tests
{
    [TestClass]
    public class TaskManagerTest
    {
        [TestMethod]
        public void TestCount()
        {
            // arrange
            TaskManager mgr = new TaskManager();

            // act
            int cnt = mgr.Count();

            // assert
            Assert.AreEqual(0, cnt);
        }
    }
}
