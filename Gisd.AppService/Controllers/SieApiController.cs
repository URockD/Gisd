using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Gisd.Domain.Interfaces;
using Gisd.AppService.Models.Factories;

namespace Gisd.AppService.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class SieApiController : ControllerBase
    {
        private readonly ILogger<SieApiController> _logger;
        private readonly ISieApiRepository _repository;
        private readonly IConfiguration _configuration;

        public SieApiController(ILogger<SieApiController> logger,
            ISieApiRepository repository,
            IConfiguration configuration)
        {
            _logger = logger;
            _repository = repository;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var serieID = _configuration["SieApi:SerieID"];
            var url = _configuration["SieApi:Url"];
            var token = _configuration["SieApi:Token"];
            var request = Gisd.Domain.Factories.SerieRequestFactory.Create(serieID, url, token);
            var resultRepository = await _repository.GetDataSerieAsync(request);
            var result = SieApiResponseFactory.Create(resultRepository);
            return base.Ok(result);
        }
    }
}
