using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backlog_State.SystemCore;

namespace Backlog_State.Modes
{
    class Closed : TaskState
    {
        public Closed()
        {
            Console.WriteLine("Closed");
        }

        public override void Start(Task task)
        { 
            Console.WriteLine("Уведомление менеджеров"); 
        }

        public override void Update(Task task)
        { 
            Console.WriteLine("Уведомление менеджеров"); 
        }

        public override void NextState(Task task)
        { }
    }
}
