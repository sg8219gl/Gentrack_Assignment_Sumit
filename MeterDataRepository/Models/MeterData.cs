using System;
using System.Collections.Generic;
using System.Text;

namespace MeterDataRepository.Models
{
    public class MeterData
    {
        public int Id { get; set; }
        public string MeterName { get; set; }
        public DateTime ReadingDate { get; set; }
        public TimeSpan ReadingTime { get; set; }
        public int ReadingValue { get; set; }
    }
}
