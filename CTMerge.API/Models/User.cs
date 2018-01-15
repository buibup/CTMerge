using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTMerge.API.Models
{
    public class User
    {
        public string SSUSR_Initials { get; set; }
        public string SSUSR_Name { get; set; }
        public string SSUSR_Password { get; set; }
    }

    public class UserResult
    {
        public string SSUSR_Initials { get; set; }
        public string SSUSR_Name { get; set; }
        public string SSUSR_Password { get; set; }
        public string SSGRP_Desc { get; set; }
        public string CTLOC_Desc { get; set; }
        public bool IsGroupAllow { get; set; }
    }

    public class GetUserResult
    {
        public string SSUSR_Initials { get; set; }
        public string SSUSR_Name { get; set; }
        public string SSGRP_Desc { get; set; }
        public string CTLOC_Desc { get; set; }
        public bool IsGroupAllow { get; set; }
    }
}