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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EB_Bluetooth_temperature_and_battery_level
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbx_select_port.Items.AddRange(ports);
            cbx_select_port.SelectedIndex = 0;
        }
        public void ATCommand_init()
        {
            try
            {
                Port_deviceTest.PortName = cbx_select_port.SelectedItem.ToString();
                Port_deviceTest.BaudRate = 9600;
                Port_deviceTest.DataBits = 8;
                Port_deviceTest.Parity = Parity.None;
                Port_deviceTest.StopBits = StopBits.One;
                Port_deviceTest.NewLine = "\r\n";
                Port_deviceTest.Handshake = Handshake.None;
                Port_deviceTest.DtrEnable = true;
                Port_deviceTest.WriteBufferSize = 1024;
                Port_deviceTest.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

                Port_deviceTest.Open();

                if (Port_deviceTest.IsOpen)
                {
                    Port_deviceTest.WriteLine("AT + TESTFUNNY");
                    Console.WriteLine("AT + TESTFUNNY");
                    Port_deviceTest.WriteLine("AT + TEMPERATURE");
                    Console.WriteLine("AT + TEMPERATURE");
                    Port_deviceTest.WriteLine("AT + BATTERYLEVEL");
                    Console.WriteLine("AT + BATTERYLEVEL");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Port_deviceTest Init False");
            }
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            char[] Chars_delimiter = { ' ', ',', '.', ':', '\t', '\n' };
            string Data_in_str = Port_deviceTest.ReadExisting();
            string[] Data_in_arr = Data_in_str.Split(Chars_delimiter);
            if (Data_in_arr[1].IndexOf("OK") >= 0) return;
            String Data_row_on_time = "";
            Console.Write(DateTime.Now.ToString("h:mm:ss tt"));
            Console.Write(',');
            Console.Write(Data_in_arr[1]);
            Console.Write(',');
            Console.Write(Data_in_arr[2]);
            Data_row_on_time = DateTime.Now.ToString("h:mm:ss tt") + "," + Data_in_arr[1] + "," + Data_in_arr[2];
            SetText(this.tbx_output.Text.ToString() + '\n' + Data_row_on_time);
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbx_output.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tbx_output.Text = text;
                this.tbx_output.SelectionStart = this.tbx_output.Text.ToString().Length;
                this.tbx_output.ScrollToCaret();
            }
        }
        private void btn_start_log_Click(object sender, EventArgs e)
        {
            ATCommand_init();
            tmr_logging_data.Enabled = true;
        }

        private void btn_stop_log_Click(object sender, EventArgs e)
        {
            tmr_logging_data.Enabled = false;

        }

        private void tmr_logging_data_Tick(object sender, EventArgs e)
        {
            try
            {
                Port_deviceTest.WriteLine("AT + TEMPERATURE");
                Console.WriteLine("AT + TEMPERATURE");
                Port_deviceTest.WriteLine("AT + BATTERYLEVEL");
                Console.WriteLine("AT + BATTERYLEVEL");
            }
            catch
            {
                return;
            }
        }
    }
}
