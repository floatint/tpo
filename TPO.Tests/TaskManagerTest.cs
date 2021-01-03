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

        [TestMethod]
        public void TestAdd()
        {
            // arrange
            TaskManager mgr = new TaskManager();

            // act
            mgr.Add(new UserTask { Name = "task_1", Description = "task_1" });
            mgr.Add(new UserTask { Name = "task_2", Description = "task_2" });

            // assert
            Assert.AreEqual(2, mgr.Count());
        }
    }
}
