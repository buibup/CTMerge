using CTMerge.API.Models;
using CTMerge.API.ViewModel;
using System;
using System.Collections.Generic;
using static CTMerge.API.Enums;

namespace CTMerge.API.DataAccess
{
    public interface IMySqlDataConnection
    {
        IEnumerable<PatientVM> GetPatientBCT(string search);
        PatientVisitVM GetPatientBCTVisit(string hn);
        bool PatientMerge(string BCT_HN, string SCT_HN);
        bool HasPatient(string SCT_HN);
        bool MergedLog(PatientMergedLogVM log);
    }
}
