using System;
using SW.Helpers;

namespace SW.Services
{
    public class Services
    {
        private string _token;
        private string _url;
        private string _proxy;
        private int _proxyPort;
        private DateTime _expirationDate;
        private int _timeSession = 2;
        internal string Token
        {
            get { return _token; }
        }
        internal string Url
        {
            get { return _url; }
        }
        internal string Proxy
        {
            get { return _proxy; }
        }
        internal int ProxyPort
        {
            get { return _proxyPort; }
        }
        internal DateTime ExpirationDate
        {
            get { return _expirationDate;  }
        }
        public Services()
        {

        }
        public Services(string url, string token, string proxy, int proxyPort)
        {
            _url = RequestHelper.NormalizeBaseUrl(url);
            _token = token;
            _expirationDate = DateTime.Now.AddYears(_timeSession);
            _proxy = proxy;
            _proxyPort = proxyPort;
        }
    }
}
