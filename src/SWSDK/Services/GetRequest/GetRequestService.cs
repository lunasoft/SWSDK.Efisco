using System.Collections.Generic;
using System.Threading.Tasks;
using SW.Entities.Common;
using SW.Entities.GetRequest;

namespace SW.Services.GetRequest
{
    public abstract class GetRequestService : Services
    {
        public GetRequestService(string url, string token, string proxy, int proxyPort) : base(url, token, proxy, proxyPort) { }
        
        internal abstract Task<Data<ATEOASData<RequestResponseEntity>>> GelAllAsync(int page, int pageSize);
        
        internal abstract Task<Data<ATEOASData<SchedulerRequestEntity>>> GetAllPlanearAsync(int page, int pageSize);
        
        internal abstract Task<Data<RequestResponseEntity>> GetRequestSpecificAsync(string idRequest);

        internal virtual Dictionary<string, string> GetHeadersAsync()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>() {
                    { "Authorization", $"bearer {Token}" }
                };
            return headers;
        }
    }
}