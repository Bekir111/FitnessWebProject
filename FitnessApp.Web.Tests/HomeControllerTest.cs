using FitnessApp.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;

namespace FitnessApp.Web.Tests
{
    public class HomeControllerTest : IClassFixture<WebApplicationFactory<Program>>
    {

        private readonly WebApplicationFactory<Program> server;

        public HomeControllerTest(WebApplicationFactory<Program> server)
        {
            this.server = server;
        }

        [Fact]
        public async Task IndexPageShouldReturnStatusCode200()
        {
            var client = this.server.CreateClient();
            var response = await client.GetAsync("/");
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            Assert.Contains("<title>", responseContent);
        }
    }
}