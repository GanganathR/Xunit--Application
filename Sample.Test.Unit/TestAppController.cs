using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using API_App.Controllers;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;

namespace Sample.Test.Unit
{
   public class TestAppController
    {
        [Fact]
        public async Task  Get_OnSuccessMessage200()
        {
            //Arrange 
            var weathercntrl = new WeatherForecastController();
            //Act
            var result = (OkObjectResult)await weathercntrl.Get();
            //Asseet
            result.StatusCode.Should().Be(200);   
        }
    }   
}
