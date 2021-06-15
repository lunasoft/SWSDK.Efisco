using System;

namespace SWSDK.Entities.Fiel
{
    public class FielResponseEntity
    {
        public string taxId { get; set; }
        public DateTime createdDate { get; set; }
        public string serialNumber { get; set; }
        public string name { get; set; }
        public DateTime notBefore { get; set; }
        public DateTime notAfter { get; set; }
    }
}
