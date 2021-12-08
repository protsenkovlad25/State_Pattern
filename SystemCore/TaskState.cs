using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backlog_State.SystemCore
{
    abstract class TaskState
    {
        public abstract void Start(Task task);
        public abstract void Update(Task task);
        public abstract void NextState(Task task);
    }
}
