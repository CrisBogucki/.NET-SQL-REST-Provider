using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Rest
{
    public class Headers
    {
        private WebRequest webRequest;
        public Headers(WebRequest webRequest)
        {
            this.webRequest = webRequest;
        }

        public void SetHeader(string headers)
        {
            string[] _headers = headers.ToString().Split('|');
            if (_headers.Length > 0)
            {
                for (int i = 0; i > _headers.Length; i++)
                {
                    var item = _headers[i].Split(':');
                    string key = item[0];
                    string value = item[1];
                    this.webRequest.Headers.Set(key, value);
                }
            }
        }

    }
}
