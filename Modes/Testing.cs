using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backlog_State.SystemCore;

namespace Backlog_State.Modes
{
    class Testing : TaskState
    {
        public Testing()
        {
            Console.WriteLine("Testing");
        }

        public override void Start(Task task)
        { 
            Console.WriteLine("Уведомление тестеров"); 
        }

        public override void Update(Task task)
        { 
            Console.WriteLine("Уведомление тестеров и менеджеров"); 
        }

        public override void NextState(Task task)
        {
            Console.WriteLine("Переход в режим:\n" +
                "(1)InProcess\n" +
                "(2)Resolved\n");
            int mode = Convert.ToInt32(Console.ReadLine());
            switch (mode)
            {
                case 1:
                    task.State = new InProcess();
                    break;
                case 2:
                    task.State = new Resolved();
                    break;
            }
        }
    }
}
