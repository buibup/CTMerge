using CTMerge.API.ViewModel;
using System.Collections.Generic;
using static CTMerge.API.Enums;

namespace CTMerge.API.DataAccess
{
    public interface IDataConnection
    {
        IEnumerable<PatientVisitVM> ReadAll();
        PatientVisitVM ReadOne(string search, SearchType type);
        IEnumerable<PatientVM> FindPatient(string search, SearchType type);
        PatientVisitVM Update(PatientVisitVM PatientVisit);
    }
}
