using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO.Logic
{
    /// <summary>
    /// Менеджер задач
    /// </summary>
    public class TaskManager
    {

        public int Count() => _tasks.Count;

        public void Add(UserTask userTask) => _tasks.Add(userTask);

        public void Delete(int idx) => _tasks.RemoveAt(idx);

        public UserTask Get(int idx) => throw new NotImplementedException();
        
        private IList<UserTask> _tasks = new List<UserTask>();
    }
}
