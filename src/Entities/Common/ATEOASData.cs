using System.Collections.Generic;

namespace SWSDK.Entities.Common
{
    public class ATEOASData<T>
    {
        public Metadata metaData { get; set; }
        public List<T> records { get; set; }
    }

    public class Metadata
    {
        public int page { get; set; }
        public int perPage { get; set; }
        public int pageCount { get; set; }
        public int totalCount { get; set; }
        public Links links { get; set; }
    }

    public class Links
    {
        public string current { get; set; }
        public string next { get; set; }
    }
}