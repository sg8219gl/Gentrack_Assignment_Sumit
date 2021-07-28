
using MeterDataRepository.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeterDataUnitTest.Repositories
{
    public class MockMeterRepository : Mock<IMeterRepository>
    {
        public MockMeterRepository MockIsValid(bool result)
        {
            Setup(x => x.IsValid(It.IsAny<int>()))
                .Returns(result);

            return this;
        }

        public MockMeterRepository VerifyIsValid(Times times)
        {
            Verify(x => x.IsValid(It.IsAny<int>()), times);

            return this;
        }
    }
}
