using MeterDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MeterDataRepository.Interfaces
{
    public interface IMeterRepository
    {
        MeterData GetByID(int id);
        List<MeterData> GetAll();
        bool IsValid(int leagueID);
    }
}
