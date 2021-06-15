using System;
using SWSDK.Entities.Common;
using SWSDK.Helpers;

namespace SWSDK.Services.GetRequest
{
    internal class GetRequestReponseHandler<T> : ResponseHandler<Data<T>>
    {
        public override Data<T> HandleException(Exception ex)
        {
            return ex.Response<Data<T>>();
        }
    }
}
