using CTMerge.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static CTMerge.API.Enums;

namespace CTMerge.API.ViewModel
{
    public class PatientMergedLogVM
    {
        public string BCT_HN { get; set; }
        public string SCT_HN { get; set; }
        public User User { get; set; }
        public string Status { get; set; }
        public DateTime MergeDateTime { get; set; }
    }


}