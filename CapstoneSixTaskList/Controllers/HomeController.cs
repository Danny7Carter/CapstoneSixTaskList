﻿using CapstoneSixTaskList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneSixTaskList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TasksList()
        {
            TaskListEntities db = new TaskListEntities();
            List<Task> Task = db.Tasks.ToList();
            ViewBag.Tasks = Task;

            

            return View();
        }
    }
}