using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backlog_State.SystemCore;

namespace Backlog_State.Modes
{
    class Resolved : TaskState
    {
        public override void Start(Task task)
        { Console.WriteLine("Уведомление разработчиков и менеджеров"); }

        public override void Update(Task task)
        { Console.WriteLine("Уведомление менеджеров"); }

        public override void NextState(Task task)
        {
            Console.WriteLine("Переход в режим:\n" +
                "(1)InProcess\n" +
                "(2)Closed\n");
            int mode = Convert.ToInt32(Console.ReadLine());
            switch (mode)
            {
                case 1:
                    task.State = new InProcess();
                    break;
                case 2:
                    task.State = new Closed();
                    break;
            }
        }
    }
}
