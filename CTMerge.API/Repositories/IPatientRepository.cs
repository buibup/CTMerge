using CTMerge.API.Models;
using CTMerge.API.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using static CTMerge.API.Enums;

namespace CTMerge.API.Repositories
{
    public interface IPatientRepository
    {
        Task<IEnumerable<PatientVM>> GetPatientBCT(string search);
        Task<IEnumerable<BasePatientVM>> GetPatientSCTByHN(string hn);
        Task<IEnumerable<BasePatientVM>> GetPatientSCTByName(string firstName, string lastName);
        Task<PatientVisitVM> GetPatientBCTVisit(string hn);
        Task<bool> PatientMerge(string BCT_HN, string SCT_HN);
        Task<bool> HasPatient(string SCT_HN);
        Task<bool> MergedLog(PatientMergedLogVM log);
    }
}
