using System.Threading.Tasks;
using SchoolManegment.Models.TokenAuth;
using SchoolManegment.Web.Controllers;
using Shouldly;
using Xunit;

namespace SchoolManegment.Web.Tests.Controllers
{
    public class HomeController_Tests: SchoolManegmentWebTestBase
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