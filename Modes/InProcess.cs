using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backlog_State.SystemCore;

namespace Backlog_State.Modes
{
    class InProcess : TaskState
    {
        public InProcess()
        {
            Console.WriteLine("InProcess");
        }

        public override void Start(Task task)
        { 
            Console.WriteLine("Уведомление разработчиков и менеджеров"); 
        }

        public override void Update(Task task)
        { 
            Console.WriteLine("Уведомление разработчиков и менеджеров");
        }

        public override void NextState(Task task)
        {
            Console.WriteLine("Переход в режим:\n" +
                "(1)Testing\n" +
                "(2)Closed\n" +
                "(3)Resolved\n");
            int mode = Convert.ToInt32(Console.ReadLine());
            switch (mode)
            {
                case 1:
                    task.State = new Testing();
                    break;
                case 2:
                    task.State = new Closed();
                    break;
                case 3:
                    task.State = new Resolved();
                    break;
            }
        }
    }
}
