using System.IO.Ports;

namespace TestSerialCom
{
    public partial class Form1 : Form
    {
        SerialSender signal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get all ports
            string[] ports = SerialPort.GetPortNames();
            COMPortList.Items.AddRange(ports);
            COMPortList.SelectedIndex = 0;
            COMPortClose.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            COMPortOpen.Enabled = false;
            COMPortClose.Enabled = true;
            signal = new SerialSender(COMPortList.Text);
        }

        private void btnSend_Click (object sender, EventArgs e)
        {
            FramesReceive.Text = signal.Send(Utils.RemoveSpace(FramesSend.Text));

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            COMPortOpen.Enabled = true;
            COMPortClose.Enabled = false;
           signal.Stop();
        }
    }
}