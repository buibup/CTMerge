namespace CTMerge.API.Models
{
    public partial class Careprovider
    {
        public int Id { get; set; }
        public string CareCode { get; set; }
        public string CareName { get; set; }
        public string CareGroupCode { get; set; }
        public string CareSMCNo { get; set; }
        public string CareLocCode { get; set; }
        public string CareSpecialtyCode { get; set; }
        public string CareSubSpecialtyCode { get; set; }
        public bool? CareSpecialistCheckFlag { get; set; }
        public bool? CareSurgeonCheckFlag { get; set; }
        public bool? CareAnaesthetistCheckFlag { get; set; }
        public bool? CareRadiologistCheckFlag { get; set; }
    }
}
