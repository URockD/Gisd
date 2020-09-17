using System;
using System.Linq;
using Gisd.AppService.Models;
using Gisd.Domain.Models;

namespace Gisd.AppService.Models.Factories
{
    public class SieApiResponseFactory
    {
        public static SieApiResponse Create(Response response)
        {
            var serie = response.seriesResponse.series.FirstOrDefault();
            return new SieApiResponse
            {
                Title = serie.Title,
                DataValues = serie.Data.Select(item => new Values { Key = item.Date, DataValue = item.Data })
            };

        }
    }
}
