using System;
using SW.Entities.Common;
using SW.Helpers;

namespace SW.Services.CreateRequest
{
    internal class CreateRequestResponseHandle<T> : ResponseHandler<Data<T>>
    {
        public override Data<T> HandleException(Exception ex)
        {
            return ex.Response<Data<T>>();
        }
    }
}
