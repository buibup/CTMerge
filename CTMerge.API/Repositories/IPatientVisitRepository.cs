using CTMerge.API.Models;
using CTMerge.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMerge.API.Repositories
{
    public interface IPatientVisitRepository
    {
        Task<IEnumerable<PatientVisitVM>> ReadAllAsync();
        Task<PatientVisitVM> ReadOneAsync(string hn);
        Task<PatientVisitVM> CreateAsync(PatientVisitVM PatientVisit);
        Task<PatientVisitVM> UpdateAsync(PatientVisitVM PatientVisit);
        Task<PatientVisitVM> DeleteAsync(string hn);
    }
}
