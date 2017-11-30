using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CTMerge.API.ViewModel;

namespace CTMerge.API.DataAccess
{
  public class CacheConnector : IDataConnection
  {
    public IEnumerable<PatientVM> GetPatient(string search)
    {
      throw new NotImplementedException();
    }

        public IEnumerable<PatientVisitVM> GetPatientVisit(string hn)
        {
            throw new NotImplementedException();
        }

        public bool MergePatient(string oldHN, string newHN)
        {
            throw new NotImplementedException();
        }
    }
}
