using System;
using System.Linq;
using Gisd.AppService.Models;
using Gisd.Domain.Models;
namespace Gisd.AppService.Models.Factories
{
    public class DashboardResponseFactory
    {
        public static DashboardResponse Create(Response response)
        {
            var serie = response.seriesResponse.series.FirstOrDefault();
            return new DashboardResponse
            {
                Title = serie.Title,
                Labels = serie.Data.Select(item => item.Date),
                Data = serie.Data.Select(item => item.Data)   
            };

        }
    }
}
