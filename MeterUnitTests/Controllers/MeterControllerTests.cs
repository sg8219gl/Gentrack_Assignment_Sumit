using MeterDataRepository.Models;
using MeterDataUnitTest.Services;
using MeterWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace MeterDataUnitTest.Tests.Controllers
{
    public class MeterControllerTests
    {
        [Fact]
        public void MeterController_GetTotalMeterReading()
        {
            //Arrange
            var mockMeter = new List<MeterData>()
            {
                new MeterData()
                {
                 Id = 1,
                MeterName = "E1083",
                ReadingDate= new DateTime(2021, 01, 01),
                ReadingTime =new TimeSpan(01,30,0),
                ReadingValue=7
                },
                new MeterData()
                {
                 Id = 1,
                MeterName = "E1083",
                ReadingDate= new DateTime(2021, 01, 01),
                ReadingTime =new TimeSpan(02,30,0),
                ReadingValue=6
                }
            };

            var mockMeterService = new MockMeterService().MockGetAll(mockMeter);            
            var controller = new MeterController(mockMeterService.Object);
            var _readingDate = new DateTime(2021, 01, 01);
            var result = controller.GetTotalMeterReading("E1083", _readingDate);
            var _resultVal = (OkObjectResult)result;
            var _count = _resultVal.Value;
            Assert.Equal("13", _count.ToString());
          
           
        }

        
    }
}
