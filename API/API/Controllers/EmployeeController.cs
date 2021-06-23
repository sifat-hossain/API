using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using API.DomainModel;
using API.Models;

namespace API.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<EmployeeInfo> employeeInfos = null;
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:58848/api/EmployeeApi");
            var consumeapi = httpClient.GetAsync("EmployeeApi");
            consumeapi.Wait();
            var readData = consumeapi.Result;
            if(readData.IsSuccessStatusCode)
            {
                var displayData = readData.Content.ReadAsAsync<IList<EmployeeInfo>>();
                displayData.Wait();
                employeeInfos = displayData.Result;
            }
            return View(employeeInfos);
        }
    }
}