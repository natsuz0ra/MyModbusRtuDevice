using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModbusRtuDevice.Models
{
    public class AlarmModel
    {
        public int Id { get; set; }
        public bool IsSelected { get; set; }
        public int SlaveId { get; set; }
        public string DeviceName { get; set; }
        public string Address { get; set; }
        public string VariableName { get; set; }
        public double Value { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
        public string State { get; set; }
    }
}
