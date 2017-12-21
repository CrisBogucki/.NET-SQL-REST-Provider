using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Rest
{
    public static class Headers
    {
        public static WebHeaderCollection SetHeader(string headers)
        {
            WebHeaderCollection result = new WebHeaderCollection();
            string[] _headers = headers.ToString().Split('|');
            if (_headers.Length > 0)
            {
                for (int i = 0; i > _headers.Length; i++)
                {
                    var item = _headers[i].Split(':');
                    string key = item[0];
                    string value = item[1];
                    result.Add(key, value);
                }
            }
            return result;
        }

    }
}
