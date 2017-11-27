using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CTMerge.API.ViewModel;

namespace CTMerge.API.DataAccess
{
  public class CacheConnector : IDataConnection
  {
    public IEnumerable<PatientVM> FindPatient(string search)
    {
      throw new NotImplementedException();
    }
  }
}
