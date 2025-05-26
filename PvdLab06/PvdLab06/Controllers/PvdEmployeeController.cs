using Microsoft.AspNetCore.Mvc;
using PvdLab06.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PvdLab06.Controllers
{
    public class PvdEmployeeController : Controller
    {
        // Tạm lưu danh sách nhân viên trong static list
        private static List<PvdEmployee> employees = new List<PvdEmployee>
        {
            new PvdEmployee { PvdId = "NV001", PvdName = "Nguyễn Văn A", PvdBirthDay = new DateTime(1990, 5, 12), PvdEmail = "a.nguyen@example.com", PvdPhone = "0901234567", PvdSalary = 12000000, PvdStatus = true },
            new PvdEmployee { PvdId = "NV002", PvdName = "Trần Thị B", PvdBirthDay = new DateTime(1992, 8, 23), PvdEmail = "b.tran@example.com", PvdPhone = "0907654321", PvdSalary = 15000000, PvdStatus = true },
            new PvdEmployee { PvdId = "NV003", PvdName = "Lê Văn C", PvdBirthDay = new DateTime(1988, 1, 5), PvdEmail = "c.le@example.com", PvdPhone = "0912345678", PvdSalary = 10000000, PvdStatus = false },
            new PvdEmployee { PvdId = "NV004", PvdName = "Phạm Thị D", PvdBirthDay = new DateTime(1995, 11, 18), PvdEmail = "d.pham@example.com", PvdPhone = "0934567890", PvdSalary = 17000000, PvdStatus = true },
            new PvdEmployee { PvdId = "NV005", PvdName = "Hoàng Văn E", PvdBirthDay = new DateTime(1993, 3, 9), PvdEmail = "e.hoang@example.com", PvdPhone = "0987654321", PvdSalary = 13000000, PvdStatus = false },
        };

        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PvdEmployee emp)
        {
            employees.Add(emp);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id)
        {
            var emp = employees.FirstOrDefault(e => e.PvdId == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(PvdEmployee emp)
        {
            var existing = employees.FirstOrDefault(e => e.PvdId == emp.PvdId);
            if (existing == null) return NotFound();

            existing.PvdName = emp.PvdName;
            existing.PvdBirthDay = emp.PvdBirthDay;
            existing.PvdEmail = emp.PvdEmail;
            existing.PvdPhone = emp.PvdPhone;
            existing.PvdSalary = emp.PvdSalary;
            existing.PvdStatus = emp.PvdStatus;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            var emp = employees.FirstOrDefault(e => e.PvdId == id);
            if (emp != null)
            {
                employees.Remove(emp);
                TempData["Message"] = $"Đã xóa nhân viên có mã {id}.";
            }
            else
            {
                TempData["Message"] = $"Không tìm thấy nhân viên với mã {id}.";
            }

            return RedirectToAction("Index");
        }

    }
}
