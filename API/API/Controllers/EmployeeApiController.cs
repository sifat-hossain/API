using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.DomainModel;
using API.Models;

namespace API.Controllers
{
    public class EmployeeApiController : ApiController
    {
        private APIEntities db = new APIEntities();
        [HttpGet]
        public IHttpActionResult Getemp()
        {
            var result = db.Sp_CrudEmp(0, "", "", "", 0, "Get").ToList();

            return Ok(result);
        }
        [HttpPost]
        public IHttpActionResult Create(EmployeeInfo employeeInfo)
        {
            var createEmp = db.Sp_CrudEmp(0, employeeInfo.EmpName, employeeInfo.Email, employeeInfo.Location, employeeInfo.Salary, "Insert");
            return Ok(createEmp);
        }
        
        [HttpGet]
        public IHttpActionResult Details(int id)
        {
            var details = db.Sp_CrudEmp(id, "", "", "", 0, "GetEmp").FirstOrDefault();
            return Ok(details);
        }
    }
}
