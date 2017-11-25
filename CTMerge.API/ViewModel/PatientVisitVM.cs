using CTMerge.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTMerge.API.ViewModel
{
    public class PatientVisitVM
    {
        public string HN { get; set; }
        public string TitleName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public List<EpisodeVM> EpisodeVMList { get; set; }

        public string Name
        {
            get
            {
                return (string.IsNullOrEmpty(TitleName) ? "" : TitleName + " ") + (FirstName + " ") + (string.IsNullOrEmpty(MiddleName) ? "" : MiddleName + " ") + LastName;
            }
        }
    }
}