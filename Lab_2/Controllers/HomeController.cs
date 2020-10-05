using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab_2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ComputerDbContext computerDb;
        public HomeController(ComputerDbContext computerDb)
        {
            this.computerDb = computerDb;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Computers()
        {
            List<Computer> computers = computerDb.Computers.ToList();
            return View(computers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> sli = new List<SelectListItem>();

            var enumNames =  typeof(Models.Computer.ComputerType).GetEnumNames();
            for(int i = 0; i < enumNames.Length; i++)
            {
                sli.Add(new SelectListItem(enumNames[i], i.ToString()));
            }

            ViewBag.Types = sli;
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddViewModel addvm)
        {
            if (ModelState.IsValid)
            {
                Computer computer = new Computer
                {
                    Name = addvm.Name,
                    Type = addvm.Type,
                    Count = addvm.Count,
                    Value = addvm.Value,
                    Description = addvm.Description
                };
                computerDb.Computers.Add(computer);
                computerDb.SaveChanges();
                return RedirectToAction("Computers");
            }
            ModelState.AddModelError("", "Adding Error");
            return RedirectToAction("Add");
        }
    }
}
