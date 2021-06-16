using System;
using SW.Entities.Common;
using SW.Helpers;

namespace SW.Services.GetFile
{
    internal class FileResponseHandle<T> : ResponseHandler<Data<T>>
    {
        public override Data<T> HandleException(Exception ex)
        {
            return ex.Response<Data<T>>();
        }
    }
}
