﻿using System;

namespace CTMerge.API.ViewModel
{
    public class EpisodeVM
    {
        public string EpiNo { get; set; }
        public string EpiType { get; set; }
        public string EpiSubTypeCode { get; set; }
        public string EpiSubTypeDesc { get; set; }
        public DateTime? EpiDate { get; set; }
        public TimeSpan? EpiTime { get; set; }
        public DateTime? EpiDateTime { get; set; }
        public string EpiLocCode { get; set; }
        public string EpiLocDesc { get; set; }
        public string EpiWardCode { get; set; }
        public string EpiWardDesc { get; set; }
        public string EpiRoom { get; set; }
        public string EpiBed { get; set; }
    }
}