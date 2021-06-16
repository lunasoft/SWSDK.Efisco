using System;
using System.Net.Http;
using System.Text;

namespace SW.Helpers
{
    internal static class Serializer
    {
        internal static StringContent CreateRequestBodyAsync<T>(T entity)
        {
            var body = Newtonsoft.Json.JsonConvert.SerializeObject(entity);
            StringContent content = new StringContent(body, Encoding.UTF8, "application/json");
            return content;
        }
    }
}
