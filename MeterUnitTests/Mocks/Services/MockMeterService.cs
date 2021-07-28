using MeterDataRepository.Models;
using MeterDataRepository.Services.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeterDataUnitTest.Services
{
    public class MockMeterService : Mock<IMeterService>
    {
        public MockMeterService MockIsValid(bool result)
        {
            Setup(x => x.IsValid(It.IsAny<int>()))
                .Returns(result);

            return this;
        }

        public MockMeterService VerifyIsValid(Times times)
        {
            Verify(x => x.IsValid(It.IsAny<int>()), times);

            return this;
        }

        public MockMeterService MockGetAll(List<MeterData> results)
        {
            Setup(x => x.GetAll())
                .Returns(results);

            return this;
        }

        public MockMeterService VerifyGetAll(Times times)
        {
            Verify(x => x.GetAll(), times);

            return this;
        }
    }
}
