using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTMerge.API.ViewModel
{
    public class BasePatientVM
    {
        private string _titleName = "";
        private string _firstName = "";
        private string _lastName = "";

        public string HN { get; set; }
        public string TitleName
        {
            get { return _titleName.Trim(); }
            set { _titleName = value; }
        }
        public string FirstName
        {
            get { return _firstName.Trim(); }
            set { _firstName = value; }
        }
        public string MiddleName { get; set; } = "";
        public string LastName
        {
            get { return _lastName.Trim(); }
            set { _lastName = value; }
        }
        public DateTime? DOB { get; set; }
        public string SexCode { get; set; } = "";
        public string SexDesc { get; set; } = "";
        public string IDCard { get; set; } = "";
        public string Name
        {
            get
            {
                return (string.IsNullOrEmpty(TitleName) ? "" : TitleName) + (FirstName + " ") + (string.IsNullOrEmpty(MiddleName) ? "" : MiddleName + " ") + LastName;
            }
        }
    }
}