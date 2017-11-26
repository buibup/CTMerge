using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CTMerge.API.ViewModel;

namespace CTMerge.API.DataAccess
{
    public class MySqlConnector : IDataConnection
    {
        public IEnumerable<PatientVisitVM> ReadAll()
        {
            throw new NotImplementedException();
        }

        public PatientVisitVM ReadOne(string search, Enums.SearchType searchType)
        {
            throw new NotImplementedException();
        }

        public PatientVisitVM Update(PatientVisitVM PatientVisit)
        {
            throw new NotImplementedException();
        }
    }
}