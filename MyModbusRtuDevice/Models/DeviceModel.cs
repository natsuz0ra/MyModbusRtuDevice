using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModbusRtuDevice.Models
{
    public class DeviceModel
    {
        // 从站id
        public byte SlaveId { get; set; }
        // 设备名称
        public string Name { get; set; }
        // 数据位列表
        public List<VariableModel> Variable { get; set; }
    }
}
