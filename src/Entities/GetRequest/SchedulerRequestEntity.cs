using System;
using SWSDK.Enums;

namespace SWSDK.Entities.GetRequest
{
    public class SchedulerRequestEntity
    {
        public string idDealer { get; set; }
        public string idUser { get; set; }
        public bool active { get; set; }
        public int lapseDays { get; set; }
        public TimeSpan schedule { get; set; }
        public DocumentType documentType { get; set; }
        public string taxId { get; set; }
        public DateTime visited { get; set; }
        public int processType { get; set; }
        public DateTime nextSchedule { get; set; }
        public int frequencyInDays { get; set; }
        public bool generatePdf { get; set; }
        public bool googleDrive { get; set; }
    }
}
