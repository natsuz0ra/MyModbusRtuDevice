using MyModbusRtuDevice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyModbusRtuDevice.Forms
{
    public partial class AddVariable : Form
    {
        public Action<byte, VariableModel> AcceptAction { get; set; }
        private byte slaveId;

        public AddVariable(byte slaveId)
        {
            InitializeComponent();
            this.slaveId = slaveId;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AcceptAction?.Invoke(slaveId, new VariableModel
                {
                    Address = Convert.ToUInt16(addrInput.Text),
                    Name = variableNameInput.Text,
                    Rate = Convert.ToDouble(rateInput.Text),
                    Offset = Convert.ToDouble(offsetInput.Text),
                    Color = colorPicker.Value,
                    Min = Convert.ToDouble(minValueInput.Text),
                    Max = Convert.ToDouble(maxValueInput.Text),
                });
                this.Close();
            }
            catch (Exception exp)
            {
                // 如果有错误，那么弹窗提示
                MessageBox.Show("所填信息格式错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
