using CTMerge.API.Models;
using CTMerge.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMerge.API.Services
{
    public interface IPatientVisitService
    {
        Task<IEnumerable<PatientVisitVM>> ReadAllAsync();
        Task<PatientVisitVM> ReadOneAsync(string hn);
        Task<bool> IsPatientExistsAsync(string hn);
        Task<PatientVisitVM> CreateAsync(PatientVisitVM patient);
        Task<PatientVisitVM> UpdateAsync(PatientVisitVM patient);
        Task<PatientVisitVM> DeleteAsync(string hn);
    }
}
