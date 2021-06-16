using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SW.Entities.Common;
using SW.Entities.Fiel;

namespace SW.Services.Fiel
{
    public abstract  class FielServices : Services
    {
        public FielServices(string url, string token, string proxy, int proxyPort) : base(url, token, proxy, proxyPort) { }

        internal abstract Task<Data<FielResponseEntity>> PostAsync(string password, string privatekey, string publickey);

        internal abstract Task<Data<ATEOASData<FielResponseEntity>>> GetAsync(int page, int pageSize);

        internal abstract Task<Data<string>> DeleteAsync(string rfc);

        internal virtual Dictionary<string, string> GetHeadersAsync()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>() {
                    { "Authorization", $"bearer {Token}" }
                };
            return headers;
        }
    }
}
