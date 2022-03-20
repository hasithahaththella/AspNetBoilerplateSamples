using System.Threading.Tasks;
using AcmeCorp.Models.TokenAuth;
using AcmeCorp.Web.Controllers;
using Shouldly;
using Xunit;

namespace AcmeCorp.Web.Tests.Controllers
{
    public class HomeController_Tests: AcmeCorpWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}