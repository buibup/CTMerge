using System;
using System.Collections.Generic;

namespace CTMerge.API.ViewModel
{
    public class PatientVisitVM
    {
        public PatientVM PatientVM { get; set; }
        public List<EpisodeVM> EpisodeList { get; set; }
    }
}