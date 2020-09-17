using System;
using System.Net;
using Gisd.Domain.Models;

namespace Gisd.DataAccess.Factories
{
    internal static class CreateRequestFactory
    {
        internal static HttpWebRequest Create(SerieRequest request)
        {
            string url = string.Format(request.Url, request.SerieID);
            string token = request.Token;

            HttpWebRequest webRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            webRequest.Accept = "application/json";
            webRequest.Headers["Bmx-Token"] = token;

            return webRequest;
        }
    }
}
