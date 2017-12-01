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
        Task<IEnumerable<PatientVisitVM>> GetPatientVisit(string hn);
    }
}
