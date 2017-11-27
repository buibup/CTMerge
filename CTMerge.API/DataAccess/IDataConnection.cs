using CTMerge.API.ViewModel;
using System.Collections.Generic;
using static CTMerge.API.Enums;

namespace CTMerge.API.DataAccess
{
    public interface IDataConnection
    {
        IEnumerable<PatientVM> FindPatient(string search);
        IEnumerable<PatientVisitVM> FindPatientVisit(string hn);
        void MergePatient(string oldHN, string newHN);
    }
}
