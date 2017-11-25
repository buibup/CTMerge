using CTMerge.API.Models;
using CTMerge.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace CTMerge.API.Controllers
{
    public class PatientDataController : ApiController
    {
        private readonly IPatientDataService _patientDataService;
        public PatientDataController(IPatientDataService patientDataService)
        {
            _patientDataService = patientDataService ?? throw new ArgumentNullException(nameof(patientDataService));
        }
        

        public async Task<IEnumerable<PatientData>> ReadAllAsync()
        {
            var allPatient = await _patientDataService.ReadAllAsync();
            return allPatient;
        }
    }
}
