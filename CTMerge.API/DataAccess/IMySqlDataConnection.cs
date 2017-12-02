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
        PatientVisitVM GetPatientBCTVisit(string hn);
        bool PatientMerge(string BCT_HN, string SCT_HN);
    }
}
