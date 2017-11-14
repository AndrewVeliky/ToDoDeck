using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Abstract;
using ToDo.Domain.Entities;

namespace ToDo.Domain.Concrete
{
    public class EFTaskToDoRepository : ITaskRepository
    {
        ApplicationContext context = new ApplicationContext();
        
        public IEnumerable<TaskToDo> TasksToDo
        {
            get { return context.TasksToDo; }
        }

        public void SaveTask(TaskToDo task)
        {
            context.TasksToDo.Add(task);
            context.SaveChanges();
        }
    }
}
