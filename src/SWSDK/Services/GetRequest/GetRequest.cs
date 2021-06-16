
using SW.Entities.Common;
using SW.Entities.GetRequest;
using SW.Helpers;
using System;
using System.Threading.Tasks;

namespace SW.Services.GetRequest
{
    public class GetRequest : GetRequestService
    {
        public GetRequest(string url, string token, int proxyPort = 0, string proxy = null)
            : base(url, token, proxy, proxyPort) { }
            
        public async Task<Data<ATEOASData<RequestResponseEntity>>> GelAllRequestAsync(int page = 1, int pageSize = 25)
        {
            return await GelAllAsync(page, pageSize);
        }

        public async Task<Data<ATEOASData<SchedulerRequestEntity>>> GetAllSchedulerAsync(int page = 1, int pageSize =  10)
        {
            return await GetAllPlanearAsync(page, pageSize);
        }

        public async Task<Data<RequestResponseEntity>> GetRequestByIdAsync(string idRequest)
        {
            return await GetRequestSpecificAsync(idRequest);
        }

        internal async override Task<Data<ATEOASData<RequestResponseEntity>>> GelAllAsync(int page, int pageSize)
        {
            var _handler = new GetRequestReponseHandler<ATEOASData<RequestResponseEntity>>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);
                Validation.validateValue(page);
                Validation.validateValue(pageSize);

                var headers = GetHeadersAsync();
                var proxy = RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetResponseAsync(this.Url,
                                $"/gestion/v1/api/gestionxml/request?page={page}&per_page={pageSize}", headers, proxy);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }

        internal async override Task<Data<ATEOASData<SchedulerRequestEntity>>> GetAllPlanearAsync(int page, int pageSize)
        {
            var _handler = new GetRequestReponseHandler<ATEOASData<SchedulerRequestEntity>>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);
                Validation.validateValue(page);
                Validation.validateValue(pageSize);

                var headers = GetHeadersAsync();
                var proxy = RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetResponseAsync(this.Url,
                                $"/gestion/v1/api/GestionXml/scheduler?page={page}&perpage={pageSize}", headers, proxy);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }

        internal async override Task<Data<RequestResponseEntity>> GetRequestSpecificAsync(string idRequest)
        {
            var _handler = new GetRequestReponseHandler<RequestResponseEntity>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);
                idRequest.ValidateGuid();

                var headers = GetHeadersAsync();
                var proxy = RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetResponseAsync(this.Url,
                                $"/gestion/{idRequest}", headers, proxy);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }
    }
}
