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

        public int Count() => throw new NotImplementedException();
        
        private IList<UserTask> _tasks = new List<UserTask>();
    }
}
