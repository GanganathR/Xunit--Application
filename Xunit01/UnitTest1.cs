using System;
using Xunit;
using API_App.Controllers;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using Moq;
using API_App.Services;

namespace Xunit01
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public async Task Get_OnSuccessMessage200()
        {
            //Arrange 
            var weathercntrl = new WeatherForecastController();
            //Act
            var result = (OkObjectResult)await weathercntrl.Get();
            //Asseet
            result.StatusCode.Should().Be(200);
        }


        [Fact]
        public async Task Get_OnSuccess_InvokeUserServiceSuccess()
        {
            //Arrange 
            var mockservice = new  Mock<IUserService>();

            var weathercntrl = new WeatherForecastController(mockservice.Object);
            //Act
            var result = (OkObjectResult)await weathercntrl.Get();
            //Asseet
            result.StatusCode.Should().Be(200);
        }
    }
}
