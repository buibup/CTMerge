using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CTMerge.API.Models;
using CTMerge.API.ViewModel;

namespace CTMerge.API.Repositories
{
    public class PatientVisitRepository : IPatientVisitRepository
    {
        private readonly List<PatientVisitVM> _patientVisit;

        public PatientVisitRepository(IEnumerable<PatientVisitVM> PatientVisit)
        {
            if (PatientVisit == null) { throw new ArgumentNullException(nameof(PatientVisit)); }
            _patientVisit = new List<PatientVisitVM>(PatientVisit);
        }

        public Task<PatientVisitVM> CreateAsync(PatientVisitVM PatientVisit)
        {
            throw new NotImplementedException();
        }

        public Task<PatientVisitVM> DeleteAsync(string hn)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatientVisitVM>> ReadAllAsync()
        {
            return Task.FromResult(_patientVisit.AsEnumerable());
        }

        public Task<PatientVisitVM> ReadOneAsync(string hn)
        {
            var patietnData = _patientVisit.FirstOrDefault(c => c.HN == hn);
            return Task.FromResult(patietnData);
        }

        public Task<PatientVisitVM> UpdateAsync(PatientVisitVM PatientVisit)
        {
            throw new NotImplementedException();
        }
    }
}