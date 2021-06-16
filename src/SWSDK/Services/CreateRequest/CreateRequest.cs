using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using SW.Entities.CreateRequest;
using SW.Entities.Common;
using SW.Helpers;

namespace SW.Services.CreateRequest
{
    public class CreateRequest : CreateRequestService
    {
        public CreateRequest(string url, string token, int proxyPort = 0, string proxy = null) 
            : base(url, token, proxy, proxyPort) {}

        internal async override Task<Data<RequestResponseEntity>> ServiceAsync(RequestEntity entity)
        {
            var _handler = new CreateRequestResponseHandle<RequestResponseEntity>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);

                var content = Serializer.CreateRequestBodyAsync<RequestEntity>(entity);

                var headers = GetHeadersAsync();
                var proxy = Helpers.RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetPostResponseAsync(this.Url,
                                "/gestion/v1/api/massiveservicemanager/request/create/webservice", headers, proxy, content);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }

        internal async override Task<Data<RequestResponseEntity>> WebAsync(RequestEntity entity)
        {
            var _handler = new CreateRequestResponseHandle<RequestResponseEntity>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);

                var content = Serializer.CreateRequestBodyAsync<RequestEntity>(entity);

                var headers = GetHeadersAsync();
                var proxy = Helpers.RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetPostResponseAsync(this.Url,
                                "/gestion/v1/api/massiveservicemanager/request/create/webportal", headers, proxy, content);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }

        internal async override Task<Data<RequestResponseEntity>> MetadataAsync(RequestEntity entity)
        {
            var _handler = new CreateRequestResponseHandle<RequestResponseEntity>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);

                var content = Serializer.CreateRequestBodyAsync<RequestEntity>(entity);

                var headers = GetHeadersAsync();
                var proxy = Helpers.RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetPostResponseAsync(this.Url,
                                "/gestion/v1/api/massiveservicemanager/request/create/webservice/metadata", headers, proxy, content);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }

        internal async override Task<Data<string>> SChedulerAsync(SchedureEntity entity)
        {
            var _handler = new CreateRequestResponseHandle<string>();
            try
            {
                Validation.ValidateHeaderParameters(Url, Token);

                var entityRequest = new List<object>()
                {
                    new {
                        Active = Convert.ToInt32(entity.Active),
                        Schedule = entity.Schedule,
                        DocumentType = entity.DocumentType,
                        TaxId = entity.TaxId,
                        LapseDays = entity.LapseDays,
                        ProcessType = entity.ProcessType,
                        FrecuencyInDays = entity.FrecuencyInDays
                    }
                };

                var content = Serializer.CreateRequestBodyAsync(entityRequest);

                var d =  await content.ReadAsStringAsync();

                var headers = GetHeadersAsync();
                var proxy = Helpers.RequestHelper.ProxySettings(this.Proxy, this.ProxyPort);
                return await _handler.GetPostResponseAsync(this.Url,
                                "/gestion/v1/api/GestionXml/scheduler/create", headers, proxy, content);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }

        public async Task<Data<RequestResponseEntity>> CreateWebServiceRequestAsync(RequestEntity entity)
        {
            return await ServiceAsync(entity);
        }

        public async Task<Data<RequestResponseEntity>> CreateWebPortalRequestAsync(RequestEntity entity)
        {
            return await WebAsync(entity);
        }

        public async Task<Data<string>> CreateSchedulerAsync(SchedureEntity entity)
        {
            return await SChedulerAsync(entity);
        }

        public async Task<Data<RequestResponseEntity>> CreateMetadataAsync(RequestEntity entity)
        {
            return await MetadataAsync(entity);
        }
    }
}
