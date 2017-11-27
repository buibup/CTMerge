using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CTMerge.API.Repositories;
using CTMerge.API.ViewModel;

namespace CTMerge.API.Services
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientVisitRepository;
        public PatientService()
        {
            _patientVisitRepository = new PatientRepository();
        }

        public Task<IEnumerable<PatientVM>> FindPatientAsync(string search)
        {
            return _patientVisitRepository.FindPatient(search);
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
    }
}