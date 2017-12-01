using CTMerge.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMerge.API.DataAccess
{
    public interface ICacheDataConnection
    {
        BasePatientVM GetPatientByHN(string hn);
        IEnumerable<BasePatientVM> GetPatient(string hn);
        IEnumerable<BasePatientVM> GetPatient(string firstName, string lastName);
    }
}
