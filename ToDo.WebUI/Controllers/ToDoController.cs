using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDo.Domain.Abstract;
using ToDo.Domain.Concrete;
using ToDo.Domain.Entities;
using ToDo.WebUI.Models;
using Microsoft.AspNet.Identity;

namespace ToDo.WebUI.Controllers
{
    public class ToDoController : Controller
    {
        private ITaskRepository repository;

        public ToDoController(ITaskRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            var currentUserId = User.Identity.GetUserId();
            if (currentUserId != null)
            {
                TaskToDoListViewModel model = new TaskToDoListViewModel
                {
                    TasksToDo = repository.TasksToDo.OrderBy(t => t.TaskToDoId)
                                            .Where(t => t.Users_Id == currentUserId)
                };
                return View(model);
            }
            else
            {
                return View("~/Views/Account/Login.cshtml");
            }
        }

        public ViewResult Create()
        {
            return View("Create", new TaskToDo());
        }

        [HttpPost]
        public ActionResult Create(TaskToDo task)
        {
            var currentUserId = User.Identity.GetUserId();
            if (ModelState.IsValid)
            {
                task.DateTime = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString();
                task.Users_Id = currentUserId;
                task.Status = false;
                repository.SaveTask(task);
                TempData["message"] = string.Format("Created: {0}", task.Name);
                return RedirectToAction("List", "ToDo");
            }
            else
            {
                TempData["message"] = string.Format("Task: {0} isn`t created!", task.Name);
                return RedirectToAction("List", "ToDo");
            }
            
        }
    }
}