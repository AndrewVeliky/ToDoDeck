using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDo.Domain.Entities;

namespace ToDo.WebUI.Models
{
    public class TaskToDoListViewModel
    {
        public IEnumerable<TaskToDo> TasksToDo;
        public string PassedTime;
    }
}