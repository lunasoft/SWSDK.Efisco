using System;
using SW.Enums;

namespace SW.Entities.CreateRequest
{
    public class SchedureEntity
    {
        public bool Active { get; set; }
        public TimeSpan Schedule { get; set; }
        public DocumentType DocumentType { get; set; }
        public string TaxId { get; set; }
        public int LapseDays { get; set; }
        public int ProcessType { get; set; }
        public int FrecuencyInDays { get; set; }
  
    }
}
