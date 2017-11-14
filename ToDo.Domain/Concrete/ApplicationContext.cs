using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ToDo.Domain.Entities;

namespace ToDo.Domain.Concrete
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext() : base("IdentityDb") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

        public DbSet<TaskToDo> TasksToDo { get; set; }
        public DbSet<DoneTask> DoneTasks { get; set; }
    }
}
