using System;
using System.Collections.Generic;
using SW.Enums;

namespace SW.Entities.Common
{
    public class RequestResponseEntity
    {
        public string idDealer { get; set; }
        public string idUser { get; set; }
        public string requestId { get; set; }
        public string taxId { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime dateFrom { get; set; }
        public DateTime dateTo { get; set; }
        public RequestType requestType { get; set; }
        public DocumentType documentType { get; set; }
        public StatusRequest statusRequest { get; set; }
        public string message { get; set; }
        public int totalFiles { get; set; }
        public int efosIndicator { get; set; }
        public List<Process> processes { get; set; }
    }

    public class Process
    {
        public string requestId { get; set; }
        public string idDealer { get; set; }
        public string idUser { get; set; }
        public ProcessType processType { get; set; }
        public StatusRequest statusProcess { get; set; }
        public string message { get; set; }
        public string url { get; set; }
        public DateTime createdDate { get; set; }
    }
}

