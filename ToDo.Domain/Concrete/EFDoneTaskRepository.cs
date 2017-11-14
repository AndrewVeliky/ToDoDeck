using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Abstract;
using ToDo.Domain.Entities;

namespace ToDo.Domain.Concrete
{
    public class EFDoneTaskRepository: IDoneTaskRepository
    {
        ApplicationContext context = new ApplicationContext();

        public IEnumerable<DoneTask> DoneTasks
        {
            get { return context.DoneTasks; }
        }
    }
}
