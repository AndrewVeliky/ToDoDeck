using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Domain.Abstract
{
    public interface ITaskRepository
    {
        IEnumerable<TaskToDo> TasksToDo { get; }
        void SaveTask(TaskToDo task);
    }
}
