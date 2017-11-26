using CTMerge.API.Models;
using System;
using System.Web.Http;

namespace CTMerge.API.Controllers
{
    public class CTController : ApiController
    {
        [HttpGet]
        [Route("api/v1/GetPatient/{hn}")]
        public IHttpActionResult GetPatientDataByHn(string hn)
        {
            var patient = new PatientData()
            {
                Id = 1,
                HN = "test",
                FirstName = "test",
                LastName = "test",
                DOB = DateTime.Now.AddYears(26),
                Address ="test"
            };

            return Ok(patient);
        }

        [HttpPost]
        [Route("api/v1/AddPatient")]
        public IHttpActionResult GetPatientDataByHn(PatientData pt)
        {
            return Ok(pt.HN);
        }
    }
}
