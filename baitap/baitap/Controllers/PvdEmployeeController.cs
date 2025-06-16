using baitap.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace baitap.Controllers
{
    public class PvdEmployeeController : Controller
    {
        private static List<PvdEmployee> pvdListEmployee = new List<PvdEmployee>
        {
            new PvdEmployee
            {
                PvdId = 231,
                PvdName = "Phạm Văn Duy",
                PvdBirthDay = new DateTime(2005, 12, 2),
                PvdEmail = "duyqd.qd2005@gmail.com",
                PvdPhone = "12345678",
                PvdSalary = 12000000m,
                PvdStatus = true
            },
            new PvdEmployee
            {
                PvdId = 2,
                PvdName = "Trần Thị B",
                PvdBirthDay = new DateTime(1992, 8, 15),
                PvdEmail = "tranthib@example.com",
                PvdPhone = "0902345678",
                PvdSalary = 13000000m,
                PvdStatus = true
            },
            new PvdEmployee
            {
                PvdId = 3,
                PvdName = "Lê Văn C",
                PvdBirthDay = new DateTime(1988, 3, 20),
                PvdEmail = "levanc@example.com",
                PvdPhone = "0903456789",
                PvdSalary = 15000000m,
                PvdStatus = false
            },
            new PvdEmployee
            {
                PvdId = 4,
                PvdName = "Phạm Thị D",
                PvdBirthDay = new DateTime(1995, 11, 5),
                PvdEmail = "phamthid@example.com",
                PvdPhone = "0904567890",
                PvdSalary = 12500000m,
                PvdStatus = true
            },
            new PvdEmployee
            {
                PvdId = 5,
                PvdName = "Hoàng Văn E",
                PvdBirthDay = new DateTime(1991, 7, 22),
                PvdEmail = "hoangvane@example.com",
                PvdPhone = "0905678901",
                PvdSalary = 13500000m,
                PvdStatus = false
            }
        };

        // GET: PvdEmployeeController
        public ActionResult PvdIndex()
        {
            return View(pvdListEmployee);
        }

        // GET: PvdEmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PvdEmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PvdEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(PvdIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: PvdEmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PvdEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(PvdIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: PvdEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PvdEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(PvdIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
