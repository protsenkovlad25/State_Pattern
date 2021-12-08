using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backlog_State.SystemCore
{
    class Task
    {
        public TaskState State { get; set; }

        public Task(TaskState state) { State = state; }

        public void Start() { State.Start(this); }
        public void Update() { State.Update(this); }
        public void NextState() { State.NextState(this); }
    }
}
