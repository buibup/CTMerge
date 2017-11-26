using CTMerge.API.Models;
using CTMerge.API.Services;
using CTMerge.API.ViewModel;
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
    public class PatientController : ApiController
    {
        private readonly IPatientVisitService _patientVisitService;

        public PatientController(IPatientVisitService patientVisitService)
        {
            _patientVisitService = patientVisitService ?? throw new ArgumentNullException(nameof(patientVisitService));
        }
        

        public async Task<IEnumerable<PatientVisitVM>> ReadAllAsync()
        {
            var allPatient = await _patientVisitService.ReadAllAsync();
            return allPatient;
        }
    }
}
