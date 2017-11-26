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
        public async Task<IEnumerable<PatientVM>> FindPatient(string search, string type)
        {
            SearchType searchType = SearchType.HN;
            if (!Enum.TryParse(type, true, out searchType))
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound,"this type does not exist"));
            }
            else
            {
                return await _patientService.FindPatientAsync(search, searchType);
            }
        }
    }
}
