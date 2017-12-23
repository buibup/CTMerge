using CTMerge.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTMerge.API.ViewModel
{
    public class PatientMergedLogVM
    {
        public string BCT_HN { get; set; }
        public string SCT_HN { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public MergedStatus Status { get; set; }
        public DateTime MergeDateTime { get; set; }
        
    }

    public enum MergedStatus
    {
        Unmerged,
        Merged
    }
}