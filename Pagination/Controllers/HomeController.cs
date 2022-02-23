using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pagination.Models;

namespace Pagination.Controllers
{
    public class HomeController : Controller
    {

        DemoViewModel context = new DemoViewModel();
        public HomeController()
        {
        }

        public ActionResult Index(string sortOrder, string searchName, int pageIndex = 1)
        {
            int totalCount = GetDemoTable().Count();
            IEnumerable<DemoTable> demoTable = GetDemoTable().Skip((pageIndex - 1) * 5).Take(5);

            if (!String.IsNullOrEmpty(searchName))
            {
                demoTable = demoTable.Where(s => s.Name.Contains(searchName));
            }

            switch (sortOrder)
            {
                case "id_desc":
                    demoTable = demoTable.OrderByDescending(s => s.Id);
                    break;
                case "name":
                    demoTable = demoTable.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    demoTable = demoTable.OrderByDescending(s => s.Name);
                    break;
                default:
                    demoTable = demoTable.OrderBy(s => s.Id);
                    break;
            }

            var model = new DemoViewModel
            {
                IdSortParam = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "",
                NameSortParam = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "name",
                SearchName = searchName,
                Demos = demoTable.ToList(),
                PageIndex = pageIndex,
                TotalCount = totalCount,
            };

            return View(model);
        }



        public JsonResult GetResult(string id)
        {
            List<DemoTable> demoTable = new List<DemoTable>();
            demoTable = context.Demos.ToList();
            return Json(demoTable);
        }

        private List<DemoTable> GetDemoTable() 
        {
            return new List<DemoTable>
            {
                new DemoTable { Id = 1, Name = "Chan Sin Yow" },
                new DemoTable { Id = 2, Name = "Yong Han" },
                new DemoTable { Id = 3, Name = "Amelia" },
                new DemoTable { Id = 4, Name = "Amy" },
                new DemoTable { Id = 5, Name = "Angela" },
                new DemoTable { Id = 6, Name = "Anna" },
                new DemoTable { Id = 7, Name = "Anne" },
                new DemoTable { Id = 8, Name = "Bella" },
                new DemoTable { Id = 9, Name = "Belle" },
                new DemoTable { Id = 10, Name = "Carol" },
                new DemoTable { Id = 11, Name = "Chloe" },
                new DemoTable { Id = 12, Name = "Claire" },
                new DemoTable { Id = 13, Name = "Diana" },
                new DemoTable { Id = 14, Name = "Ella" },
                new DemoTable { Id = 15, Name = "Emily" },
                new DemoTable { Id = 16, Name = "Emma" },
                new DemoTable { Id = 17, Name = "Sam" },
                new DemoTable { Id = 18, Name = "Tony Stark" },
                new DemoTable { Id = 19, Name = "Peter Parker" },
                new DemoTable { Id = 20, Name = "Steve" },
                new DemoTable { Id = 21, Name = "Steve" },
                new DemoTable { Id = 22, Name = "Steve" },
                new DemoTable { Id = 23, Name = "Steve" },
                new DemoTable { Id = 24, Name = "Steve" },
                new DemoTable { Id = 25, Name = "Steve" },
                new DemoTable { Id = 26, Name = "Sos" },
                new DemoTable { Id = 27, Name = "Sos" },
                new DemoTable { Id = 28, Name = "Sos" },
                new DemoTable { Id = 29, Name = "Sos" },
                new DemoTable { Id = 30, Name = "Sos" },
                new DemoTable { Id = 31, Name = "Covid" },
                new DemoTable { Id = 32, Name = "Covid" },
                new DemoTable { Id = 33, Name = "Covid" },
                new DemoTable { Id = 34, Name = "Covid" },
                new DemoTable { Id = 35, Name = "Covid" },
            };
        }
    }
}
