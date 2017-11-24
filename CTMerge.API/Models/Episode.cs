
using System;

namespace CTMerge.API.Models
{
    public partial class Episode
    {
        public int Id { get; set; }
        public string Hn { get; set; }
        public string Epi { get; set; }
        public string EpiType { get; set; }
        public string EpiSubTypeCode { get; set; }
        public DateTime EpiDate { get; set; }
        public TimeSpan EpiTime { get; set; }
        public DateTime EpiDateTime { get; set; }
        public string EpiLocCode { get; set; }
        public string EpiWardCode { get; set; }
        public string EpiRoom { get; set; }
        public string EpiBed { get; set; }
    }
}
