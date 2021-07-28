using MeterDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeterDataRepository.Services.Interfaces
{
    public interface IMeterService
    {
        bool IsValid(int id);

        List<MeterData> GetAll();
    }
}
