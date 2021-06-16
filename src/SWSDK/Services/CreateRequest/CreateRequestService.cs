using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SW.Entities.CreateRequest;
using SW.Entities.Common;

namespace SW.Services.CreateRequest
{
    public abstract class CreateRequestService : Services
    {
        internal CreateRequestService(string url, string token, string proxy, int proxyPort) 
            : base(url, token, proxy, proxyPort) { }
        
        internal abstract Task<Data<RequestResponseEntity>> WebAsync(RequestEntity entity);
        internal abstract Task<Data<RequestResponseEntity>> ServiceAsync(RequestEntity entity);
        internal abstract Task<Data<RequestResponseEntity>> MetadataAsync(RequestEntity entity);
        internal abstract Task<Data<string>> SChedulerAsync(SchedureEntity entity);
        internal virtual Dictionary<string, string> GetHeadersAsync()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>() {
                    { "Authorization", $"bearer {Token}" }
                };
            return headers;
        }
    }
}