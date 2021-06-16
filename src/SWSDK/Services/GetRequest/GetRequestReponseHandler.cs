using System;
using SW.Entities.Common;
using SW.Helpers;

namespace SW.Services.GetRequest
{
    internal class GetRequestReponseHandler<T> : ResponseHandler<Data<T>>
    {
        public override Data<T> HandleException(Exception ex)
        {
            return ex.Response<Data<T>>();
        }
    }
}
