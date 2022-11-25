using System.IO.Ports;

namespace TestSerialCom
{
    public partial class SerialPortTools : Form
    {
        SerialSender signal;
        public SerialPortTools()
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
            if (signal.IsConnected())
            {
                FramesSendBtn.Enabled = true;
            }
            else
            {
                Utils.MessageSend("error", "La connexion n'a pas pu ce faire");
            }
        }

        private void btnSend_Click (object sender, EventArgs e)
        {
            if (Utils.OnlyHexInString(FramesSend.Text))
            {
                frameReceived.Items.Add(DateTime.Now.ToString() + " :: " + signal.Send(Utils.RemoveSpace(FramesSend.Text)));
                FramesSend.Clear();
            }
            else
            {
                Utils.MessageSend("error", "La trame saisie n'est pas en caractère hexadécimal");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            COMPortOpen.Enabled = true;
            COMPortClose.Enabled = false;
            FramesSendBtn.Enabled = false;
            signal.Stop();
        }

        private void frameInitGenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitSignalCalc form = new InitSignalCalc();
            form.Show();
        }
    }
}