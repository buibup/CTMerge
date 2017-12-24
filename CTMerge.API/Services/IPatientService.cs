using CTMerge.API.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using static CTMerge.API.Enums;

namespace CTMerge.API.Services
{
    public interface IPatientService
    {
        Task<bool> IsPatientExistsAsync(string hn);
        Task<IEnumerable<PatientVM>> GetPatientBCTAsync(string search);
        Task<IEnumerable<BasePatientVM>> GetPatientSCTByHNAsync(string hn);
        Task<IEnumerable<BasePatientVM>> GetPatientSCTByNameAsync(string firstName, string lastName);
        Task<PatientVisitVM> GetPatientBCTVisitAsync(string hn);
        Task<bool> PatientMergeAsync(string BCT_HN, string SCT_HN);
        Task<bool> MergedLog(PatientMergedLogVM log);
    }
}
