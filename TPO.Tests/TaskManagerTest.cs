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

        [TestMethod]
        public void TestDelete()
        {
            // arrange
            TaskManager mgr = new TaskManager();

            // act
            mgr.Add(new UserTask { Name = "test", Description = "test" });
            mgr.Add(new UserTask { Name = "test2", Description = "test2" });
            mgr.Delete(1);

            // assert
            Assert.AreEqual(1, mgr.Count());
        }

        [TestMethod]
        public void TestGet()
        {
            // arrange
            TaskManager mgr = new TaskManager();
            UserTask target = new UserTask
            {
                Name = "target",
                Description = "target"
            };

            // act
            mgr.Add(new UserTask { Name = "task_1", Description = "task_1" });
            mgr.Add(target);
            mgr.Add(new UserTask { Name = "task_2", Description = "task_2" });
            UserTask tmp = mgr.Get(1);

            // assert
            Assert.IsNotNull(tmp);
            Assert.AreEqual(target, tmp);
        }
    }
}
