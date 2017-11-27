using CTMerge.API.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using static CTMerge.API.Enums;

namespace CTMerge.API.Repositories
{
    public interface IPatientRepository
    {
        Task<IEnumerable<PatientVM>> FindPatient(string search);
    }
}
