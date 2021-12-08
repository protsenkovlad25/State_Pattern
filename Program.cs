using System;
using Backlog_State.Modes;
using Backlog_State.SystemCore;

namespace Backlog_State
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(new New());

            task.Start();
            task.Update();
            task.NextState();
        }
    }
}
