using CTMerge.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CTMerge.API.Enums;

namespace CTMerge.API.DataAccess
{
    public interface IDataConnection
    {
        IEnumerable<PatientVisitVM> ReadAll();
        PatientVisitVM ReadOne(string search, SearchType searchType);
        PatientVisitVM Update(PatientVisitVM PatientVisit);
    }
}
