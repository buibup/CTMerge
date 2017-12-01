using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTMerge.API.ViewModel
{
    public class PatientVM
    {
        public BasePatientVM Patient { get; set; }
        public string SCT_HN { get; set; }
    }
}