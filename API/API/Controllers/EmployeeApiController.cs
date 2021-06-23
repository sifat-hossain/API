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
        public IHttpActionResult Getemp()
        {
            var result = db.Sp_CrudEmp(0,"","","",0,"Get").ToList();

            return Ok(result);
        }
    }
}
