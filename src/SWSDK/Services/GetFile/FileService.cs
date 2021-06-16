using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SW.Entities.Common;

namespace SW.Services.GetFile
{
    public abstract class FileService : Services
    {
        public FileService(string url, string token, string proxy, int proxyPort) : base(url, token, proxy, proxyPort) { }

        internal abstract Task<Data<string>> GetUrlAsync(string pathFile);

        internal virtual Dictionary<string, string> GetHeadersAsync()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>() {
                    { "Authorization", $"bearer {Token}" }
                };
            return headers;
        }
    }
}
