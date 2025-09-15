using MyModbusRtuDevice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModbusRtuDevice.Common
{
    public class AppSession
    {
        public static ModbusService ModbusService { get; set; } = new ModbusService();
        public static DBService DBService { get; set; } = new DBService();

        // 告警数据列表，仅用于去重，不用于展示
        public static List<AlarmModel> AlarmData = new List<AlarmModel>();
    }
}
