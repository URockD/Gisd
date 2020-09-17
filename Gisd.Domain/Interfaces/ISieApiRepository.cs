using System;
using Gisd.Domain.Models;
using System.Threading.Tasks;

namespace Gisd.Domain.Interfaces
{
    public interface ISieApiRepository
    {
        Task<Response> GetDataSerieAsync(SerieRequest request);
    }
}
