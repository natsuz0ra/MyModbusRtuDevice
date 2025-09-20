using MyModbusRtuDevice.Common;
using MyModbusRtuDevice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyModbusRtuDevice.Forms
{
    public partial class SystemConfig : Form
    {
        public SystemConfig()
        {
            InitializeComponent();
            this.Load += SystemConfig_Load;
        }

        private void SystemConfig_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void serialPortsDropList_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            serialPortsDropList.SelectedValue = e.Value;
            serialPortsDropList.Text = serialPortsDropList.SelectedValue.ToString();

            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.PortName = serialPortsDropList.SelectedValue.ToString();
        }

        private void baudDropList_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            baudDropList.SelectedValue = e.Value;
            baudDropList.Text = baudDropList.SelectedValue.ToString();

            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.BaudRate = Convert.ToInt32(baudDropList.SelectedValue);
        }

        private void dataBitsDropList_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            dataBitsDropList.SelectedValue = e.Value;
            dataBitsDropList.Text = dataBitsDropList.SelectedValue.ToString();

            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.DateBit = Convert.ToInt32(dataBitsDropList.SelectedValue);
        }

        private void parityDropList_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            parityDropList.SelectedValue = e.Value;
            parityDropList.Text = parityDropList.SelectedValue.ToString();

            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.Parity = (Parity)Enum.Parse(typeof(Parity), parityDropList.SelectedValue.ToString());
        }

        private void stopBitsDropList_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            stopBitsDropList.SelectedValue = e.Value;
            stopBitsDropList.Text = stopBitsDropList.SelectedValue.ToString();

            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitsDropList.SelectedValue.ToString());
        }

        private void readBufferInput_ValueChanged(object sender, AntdUI.DecimalEventArgs e)
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.ReadBuffterSize = Convert.ToInt32(e.Value);
        }

        private void readTimeoutInput_ValueChanged(object sender, AntdUI.DecimalEventArgs e)
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.ReadTimeout = Convert.ToInt32(e.Value);
        }

        private void writeBufferInput_ValueChanged(object sender, AntdUI.DecimalEventArgs e)
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.WriteBuffterSize = Convert.ToInt32(e.Value);
        }

        private void writeTimeoutInput_ValueChanged(object sender, AntdUI.DecimalEventArgs e)
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.WriteTimeout = Convert.ToInt32(e.Value);
        }

        private void InitData()
        {
            // 初始化可用的串口列表
            serialPortsDropList.Items.AddRange(SerialPort.GetPortNames());
            // 初始化校验位列表
            parityDropList.Items.AddRange(Enum.GetNames(typeof(Parity)));
            // 初始化停止位列表
            stopBitsDropList.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            // 初始化选择项和显示值，从读取的配置中获取
            var cm = AppSession.ModbusService.GetCommunicationModel();

            serialPortsDropList.SelectedValue = serialPortsDropList.Items.ToArray<string>().First(p => p == cm.PortName);
            serialPortsDropList.Text = serialPortsDropList.SelectedValue.ToString();
            baudDropList.SelectedValue = baudDropList.Items.ToArray<string>().First(p => p == cm.BaudRate.ToString());
            baudDropList.Text = baudDropList.SelectedValue.ToString();
            dataBitsDropList.SelectedValue = dataBitsDropList.Items.ToArray<string>().First(p => p == cm.DateBit.ToString());
            dataBitsDropList.Text = dataBitsDropList.SelectedValue.ToString();
            parityDropList.SelectedValue = parityDropList.Items.ToArray<string>().First(p => p == cm.Parity.ToString());
            parityDropList.Text = parityDropList.SelectedValue.ToString();
            stopBitsDropList.SelectedValue = stopBitsDropList.Items.ToArray<string>().First(p => p == cm.StopBits.ToString());
            stopBitsDropList.Text = stopBitsDropList.SelectedValue.ToString();

            readBufferInput.Value = Convert.ToDecimal(cm.ReadBuffterSize);
            readTimeoutInput.Value = Convert.ToDecimal(cm.ReadTimeout);
            writeBufferInput.Value = Convert.ToDecimal(cm.WriteBuffterSize);
            writeTimeoutInput.Value = Convert.ToDecimal(cm.WriteTimeout);

            slaveInput1.Text = cm.DeviceList[0].SlaveId.ToString();
            deviceNameInput2.Text = cm.DeviceList[0].Name;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = cm.DeviceList[0].Variable;
        }

        private void addVariableBtn1_Click(object sender, EventArgs e)
        {
            AddVariable avForm = new AddVariable(1);
            avForm.AcceptAction = new Action<byte, VariableModel>(AddVariable1);
            avForm.ShowDialog();
        }

        private void AddVariable1(byte slaveId, VariableModel variable)
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();
            var variables = cm.DeviceList.First(p => p.SlaveId == slaveId).Variable;
            variables.Add(variable);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = variables;
        }
    }
}
