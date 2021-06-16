using System;
using System.Threading.Tasks;
using SW.Entities.Common;
using SW.Entities.Fiel;
using SW.Helpers;

namespace SW.Services.Fiel
{
    public class Fiel : FielServices
    {
        public Fiel(string url, string token, int proxyPort = 0, string proxy = null) 
            : base(url, token, proxy, proxyPort) {}

        public async Task<Data<string>> DeleteFielAsync(string rfc)
        {
            return await DeleteAsync(rfc);
        }

        public async Task<Data<ATEOASData<FielResponseEntity>>> GetAllFielAsync(int page = 1, int pageSize = 10)
        {
            return await GetAsync(page, pageSize);
        }

        public async Task<Data<FielResponseEntity>> PostFielAsync(string password, string privatekey, string publickey)
        {
            return await PostAsync(password, privatekey, publickey);
        }

        internal async override Task<Data<string>> DeleteAsync(string rfc)
        {
            var _handler = new FielResponseHandle<string>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);
                Validation.validateValue(rfc);

                var headers = GetHeadersAsync();
                var proxy = Helpers.RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetDeleteResponseAsync(this.Url,
                                $"/gestion/v1/api/certificates/{rfc}", headers, proxy);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }

        internal async override Task<Data<ATEOASData<FielResponseEntity>>> GetAsync(int page, int pageSize)
        {
            var _handler = new FielResponseHandle<ATEOASData<FielResponseEntity>>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);
                Validation.validateValue(page);
                Validation.validateValue(pageSize);

                var headers = GetHeadersAsync();
                var proxy = Helpers.RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetPostResponseAsync(this.Url,
                                $"/gestion/v1/api/certificates/get/fiel?page={page}&per_page={pageSize}", headers, proxy);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }

        internal async override Task<Data<FielResponseEntity>> PostAsync(string pass, string key, string cer)
        {
            var _handler = new FielResponseHandle<FielResponseEntity>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);
                Validation.validateValue(pass);
                key.validateb64();
                cer.validateb64();

                var headers = GetHeadersAsync();
                var contrent = Serializer.CreateRequestBodyAsync<FielEntity>(
                    new FielEntity()
                    {
                        password = pass,
                        privatekey = key,
                        publickey = cer

                    }
                );

                var proxy = Helpers.RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetPostResponseAsync(this.Url,
                                "/gestion/v1/api/certificates/create/fiel", headers, proxy, contrent);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }
    }
}
