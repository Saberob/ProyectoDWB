using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea1DWBE.DataAccess;

namespace Tarea1DWBE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NorthwindController : Controller
    {
        // GET: NorthwindController
        [HttpGet]
        public IEnumerable<Categories> Get()
        {
            // select * from Employee
            /*NorthwindContext dataContext = new NorthwindContext();

            var employeeQuery = dataContext.Employees.Select(s => s);

            var output = employeeQuery.ToArray();

            return output;*/

            using (var dataContext = new NorthwindContext())
            {
                var employeeQuery = dataContext.Categories.Select(s => s);
                var output = employeeQuery.ToList();
                return output;
            }
        }
    }
}
