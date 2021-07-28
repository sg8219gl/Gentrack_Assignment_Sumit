using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeterDataRepository.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MeterWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterController : ControllerBase
    {
        private readonly IMeterService _meterService;

        public MeterController(IMeterService meterService)
        {
            _meterService = meterService;
        }
       
        [HttpGet]
        public IActionResult GetTotalMeterReading(string meterName, DateTime readingDate)
        {
            var meter = _meterService.GetAll();            
            var _result= meter.Where(d => d.MeterName == meterName && d.ReadingDate == readingDate).Select(d => d.ReadingValue).Sum();
            return Ok(_result);


        }
        [HttpGet]
        public IActionResult GetAllMeterReadingTotal(DateTime readingDate)
        {
            var meter = _meterService.GetAll();
            
            var _result = (from mt in meter
                             group mt by mt.MeterName into groupResult
                             select new
                             {
                                 MeterName = groupResult.Key,
                                 ReadingValue = groupResult.Where(d => d.ReadingDate == readingDate).Sum(f => f.ReadingValue )
                             }).ToList();

           
            return Ok(_result);


        }
    }
}