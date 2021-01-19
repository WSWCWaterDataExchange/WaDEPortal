﻿using System;
using System.Collections.Generic;



namespace MapboxPrototypeAPI.Accessors.EF.DatabaseModels
{
    public partial class RegulatoryStatus
    {
        public string Name { get; set; }
        public string Term { get; set; }
        public string State { get; set; }
        public string Definition { get; set; }
        public string SourceVocabularyUri { get; set; }
        public string WaDename { get; set; }
    }
}
