using System;
using SWSDK.Enums;

namespace SW.Entities.CreateRequest
{
    public class RequestEntity
    {
        public DocumentType documentType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string taxId { get; set; }
        public bool generatePDF { get; set; }
    }
}
