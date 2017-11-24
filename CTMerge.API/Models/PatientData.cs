using System;

namespace CTMerge.API.Models
{
    public partial class PatientData
    {
        public int Id { get; set; }
        public string HN { get; set; }
        public string TitileName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string IDCard { get; set; }
        public string Passportnumber { get; set; }
        public string Telephone { get; set; }
        public string SexCode { get; set; }
        public DateTime? DOB { get; set; }
        public string MaritalCode { get; set; }
        public string PatientCategoryCode { get; set; }
        public string ReligionCode { get; set; }
        public string NationCode { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
    }
}
