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
        [Route("api/v1/GetPatientBCT/")]
        public async Task<IEnumerable<PatientVM>> GetPatientBCT(string search)
        {
            return await _patientService.GetPatientBCTAsync(search);
        }

        [Route("api/v1/GetPatientSCTByHN/")]
        [HttpGet]
        public async Task<IEnumerable<BasePatientVM>> GetPatientSCTByHN(string hn)
        {
            return await _patientService.GetPatientSCTByHNAsync(hn);
        }

        [Route("api/v1/GetPatientSCTByName/")]
        [HttpGet]
        public async Task<IEnumerable<BasePatientVM>> GetPatientSCTByName(string firstName, string lastName)
        {
            return await _patientService.GetPatientSCTByNameAsync(firstName, lastName);
        }

        [Route("api/v1/PatienMerge/")]
        [HttpPut]
        public async Task<bool> PatienMerge(string BCT_HN, string SCT_HN)
        {
            return await _patientService.PatientMergeAsync(BCT_HN, SCT_HN);
        }

        [Route("api/v1/GetPatientBCTVisit/")]
        [HttpGet]
        public async Task<PatientVisitVM> GetPatientBCTVisit(string hn)
        {
            return await _patientService.GetPatientBCTVisitAsync(hn);
        }
    }
}
