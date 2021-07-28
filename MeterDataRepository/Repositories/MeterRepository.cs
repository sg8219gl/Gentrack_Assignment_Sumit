using MeterDataRepository.Interfaces;
using MeterDataRepository.Models;
using System;
using System.Collections.Generic;

namespace MeterDataRepository.Repositories
{
    public class MeterRepository : IMeterRepository
    {
        public MeterData GetByID(int meterID)
        {
            throw new NotImplementedException();
        }

        public List<MeterData> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool IsValid(int meterID)
        {
            throw new NotImplementedException();
        }
    }
}
