﻿using System;
using System.Collections.Generic;



namespace MapboxPrototypeAPI.Accessors.EF.DatabaseModels
{
    public partial class Epsgcode
    {
        public Epsgcode()
        {
            ReportingUnitsDims = new HashSet<ReportingUnitsDim>();
            SitesDims = new HashSet<SitesDim>();
        }

        public string Name { get; set; }
        public string Term { get; set; }
        public string Definition { get; set; }
        public string State { get; set; }
        public string SourceVocabularyUri { get; set; }
        public string WaDename { get; set; }

        public virtual ICollection<ReportingUnitsDim> ReportingUnitsDims { get; set; }
        public virtual ICollection<SitesDim> SitesDims { get; set; }
    }
}
