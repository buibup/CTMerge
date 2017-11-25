using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CTMerge.API.Models;
using CTMerge.API.Repositories;
using CTMerge.API.ViewModel;

namespace CTMerge.API.Services
{
    public class PatientVisitService : IPatientVisitService
    {
        private IPatientVisitRepository _patientVisitRepository;
        public PatientVisitService(IPatientVisitRepository patientVisitRepository)
        {
            _patientVisitRepository = patientVisitRepository ?? throw new ArgumentNullException(nameof(patientVisitRepository));
        }
        public Task<PatientVisitVM> CreateAsync(PatientVisitVM patient)
        {
            throw new NotImplementedException();
        }

        public Task<PatientVisitVM> DeleteAsync(string hn)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsPatientExistsAsync(string hn)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatientVisitVM>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PatientVisitVM> ReadOneAsync(string hn)
        {
            throw new NotImplementedException();
        }

        public Task<PatientVisitVM> UpdateAsync(PatientVisitVM patient)
        {
            throw new NotImplementedException();
        }
    }
}