using CTMerge.API.Models;
using CTMerge.API.ViewModel;
using System.Collections.Generic;
using static CTMerge.API.Enums;

namespace CTMerge.API.DataAccess
{
    public interface IMySqlDataConnection
    {
        IEnumerable<PatientVM> GetPatientBCT(string search);
        IEnumerable<PatientMergeVM> GetPatientMerge(string hn);
        IEnumerable<PatientVisitVM> GetPatientVisit(string hn);
        bool MergePatient(string oldHN, string newHN);
    }
}
