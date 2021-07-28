using MeterDataRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MeterDataRepository.Services.Interfaces;
using MeterDataRepository.Models;

namespace MeterDataRepository.Services
{
    public class MeterService : IMeterService
    {
        private readonly IMeterRepository _meterRepo;

        public MeterService(IMeterRepository meterRepo)
        {
            _meterRepo = meterRepo;
        }

        public bool IsValid(int id)
        {
            return _meterRepo.IsValid(id);
        }

        public List<MeterData> GetAll()
        {
            return _meterRepo.GetAll();
        }
    }
}
