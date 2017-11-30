using CTMerge.API.ViewModel;
using System.Collections.Generic;
using static CTMerge.API.Enums;

namespace CTMerge.API.DataAccess
{
    public interface IDataConnection
    {
        IEnumerable<PatientVM> GetPatient(string search);
        IEnumerable<PatientVisitVM> GetPatientVisit(string hn);
        bool MergePatient(string oldHN, string newHN);
    }
}
