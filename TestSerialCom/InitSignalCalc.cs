namespace TestSerialCom
{
    public partial class InitSignalCalc : Form
    {
        public InitSignalCalc()
        {
            InitializeComponent();
        }

        private void creatFrame_Click(object sender, EventArgs e)
        {
            if(FLSCode.Text != "" && int.TryParse(FLSCode.Text, out int n))
            frameCreate.Text = CreateFrameTLS(Int16.Parse(FLSCode.Text), !initOrReceive.Checked);
        }

        public static string CreateFrameTLS(int tlsCode, bool type)
        {
            string frame = "";
            string frameCalc = "";
            string tls = tlsCode.ToString("X");
            tls = tls.Length == 1 ? "0" + tls : tls;
            //Check si c est la trame de start
            if (type)
            {
                //Total frame
                frame = "68 10 10 68 calc 16";
                //Frame to calcule
                frameCalc = "53 01 09 C8 01 0A 04 05 01 01 05 01 37 01 " + tls + " 01";
            }
            //Trame de retour
            else
            {
                //Total frame
                frame = "68 10 10 68 calc 16";
                //Frame to calcule
                frameCalc = "08 C8 09 01 C8 0A 04 85 01 01 05 01 37 01 " + tls + " 01";
            }
            //On transforme en byte
            int total = Utils.StringToByteArray(Utils.RemoveSpace(frameCalc)).Sum(x => x);
            //On convertit les bytes en string
            string totalStr = string.Format("{0:x}", total);
            //On remplace calc par notre calcule
            frame = frame.Replace("calc", frameCalc + totalStr.Substring(1));
            //On retourne la trame
            return frame;
        }

        private void copyFrame_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(frameCreate.Text);
        }
    }
}
