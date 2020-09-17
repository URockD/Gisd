using System;
using System.Net;
using System.Threading.Tasks;
using Gisd.Domain.Interfaces;
using Gisd.Domain.Models;
using Gisd.DataAccess.Factories;

namespace Gisd.DataAccess
{
    public class SieApiRepository : ISieApiRepository
    {
        public async Task<Response> GetDataSerieAsync(SerieRequest request)
        {
            HttpWebRequest webRequest = CreateRequestFactory.Create(request);
            HttpWebResponse response = await webRequest.GetResponseAsync() as HttpWebResponse;
            return CreateResponseFactory.Create<Response>(response);
        }
    }
}
