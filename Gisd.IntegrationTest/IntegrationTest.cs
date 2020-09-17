using System;
using System.Net.Http;
using System.Threading.Tasks;
using Gisd.AppService;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Gisd.IntegrationTest
{
    public class IntegrationTest
    {
        protected readonly HttpClient _testClient;

        public IntegrationTest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _testClient = appFactory.CreateClient();
        }

        [Fact]
        public async Task Test01()
        {
            var result = await _testClient.GetAsync("sieapi");
        }
    }
}
