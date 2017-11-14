using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDo.Domain.Entities
{
    public class TaskToDo
    {
        public int TaskToDoId { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string DateTime { get; set; }
        public bool Status { get; set; }

        public string Users_Id { get; set; }
    }
}
