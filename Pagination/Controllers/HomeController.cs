using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pagination.Data;
using Pagination.Models;

namespace Pagination.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string sortOrder, string searchName, int pageIndex = 1)
        {
            int totalCount = _dbContext.Demo.AsNoTracking()
                .Where(s => String.IsNullOrEmpty(searchName) 
                    ? true 
                    : s.Name.Contains(searchName) 
                )
                .Select(x => x.Id)
                .Count();

            var demoTable = _dbContext.Demo.AsNoTracking()
                .Where(s => String.IsNullOrEmpty(searchName)
                    ? true
                    : s.Name.Contains(searchName)
                )
                .OrderBy(s => s.Id)
                .Skip((pageIndex - 1) * 5)
                .Take(5)
                .Select(x => new DemoTable
                {
                    Id = x.Id,
                    Name = x.Name,
                });

            //switch (sortOrder)
            //{
            //    case "id_desc":
            //        demoTable = demoTable.OrderByDescending(s => s.Id);
            //        break;
            //    case "name":
            //        demoTable = demoTable.OrderBy(s => s.Name);
            //        break;
            //    case "name_desc":
            //        demoTable = demoTable.OrderByDescending(s => s.Name);
            //        break;
            //    default:
            //        demoTable = demoTable.OrderBy(s => s.Id);
            //        break;
            //}

            //var model = new DemoViewModel
            //{
            //    IdSortParam = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "",
            //    NameSortParam = sortOrder == "name" ? "name_desc" : "name",
            //    SearchName = searchName,
            //    Demos = demoTable.ToList(),
            //    PageIndex = pageIndex,
            //    TotalCount = totalCount,
            //};

            return Json(new { pageIndex = pageIndex, totalCount = totalCount, demoTable = demoTable });
        }
    }
}
