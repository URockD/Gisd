using System;
using Gisd.Domain.Models;
namespace Gisd.Domain.Factories
{
    public static class SerieRequestFactory
    {
        public static SerieRequest Create(string serieID, string url, string token)
        {
            return new SerieRequest
            {
                SerieID = serieID,
                Url = url,
                Token = token
            };
        }
    }

}

