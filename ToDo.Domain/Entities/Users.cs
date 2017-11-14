using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ToDo.Domain.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
        }

        public string Name { get; set; }
        public string UserLogin { get; set; }

        public virtual List<TaskToDo> TasksToDo { get; set; }
        public virtual List<DoneTask> DoneTasks { get; set; }
    }
}
