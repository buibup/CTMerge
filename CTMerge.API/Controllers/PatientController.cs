using CTMerge.API.Services;
using CTMerge.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using static CTMerge.API.Enums;

namespace CTMerge.API.Controllers
{
    public class PatientController : ApiController
    {
        private readonly IPatientService _patientService;

        public PatientController()
        {
            _patientService = new PatientService();
        }

        [HttpGet]
        [Route("api/v1/FindPatient/")]
        public async Task<IEnumerable<PatientVM>> GetPatient(string search)
        {
            return await _patientService.GetPatientAsync(search);
        }
    }
}
