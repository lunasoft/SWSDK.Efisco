using System;
using System.Threading.Tasks;
using SW.Entities.Common;
using SW.Helpers;
using SW.Entities.File;

namespace SW.Services.GetFile
{
    public class GetFile : FileService
    {
        public GetFile(string url, string token, int proxyPort = 0, string proxy = null) 
            : base(url, token, proxy, proxyPort) {}
        public async Task<Data<string>> GetFileUrlAsync(string pathFile)
        {
            return await GetUrlAsync(pathFile);
        }

        internal async override Task<Data<string>> GetUrlAsync(string pathFile)
        {
            var _handler = new FileResponseHandle<string>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);
                Validation.validateValue(pathFile);

                var content = Serializer.CreateRequestBodyAsync<FileEntity>(
                    new FileEntity()
                    { 
                        PathFile =  pathFile
                    }
                );

                var headers = GetHeadersAsync();
                var proxy = Helpers.RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetPostResponseAsync(this.Url,
                                "/gestion/v1/api/file", headers, proxy, content);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }
    }
}
