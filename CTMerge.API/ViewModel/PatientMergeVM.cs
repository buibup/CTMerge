using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTMerge.API.ViewModel
{
    public class PatientMergeVM
    {
        public BasePatientVM PatientCache { get; set; }
        public List<PatientVM> PatientsBCT { get; set; }
    }
}