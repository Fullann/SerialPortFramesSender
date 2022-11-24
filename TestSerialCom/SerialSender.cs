using System.IO.Ports;

namespace TestSerialCom
{
    public  class SerialSender
    {
        private SerialPort _COMPort;        //Port de comuniquation

        public SerialSender(string port)
        {
            //Création de la connexion
            _COMPort = new SerialPort()
            {
                PortName = port,        // Port pour la communication
                BaudRate = 9600,        // Set Baud rate = 9600
                DataBits = 8,           // Number of data bits = 8
                Parity = Parity.Even,   // No parity
                StopBits = StopBits.One,// One stop bit
                ReadTimeout = 500,       // Time for read 
                WriteTimeout = 500       //Time to write 
            };

            // Open the serial port
            _COMPort.Open();
            _COMPort.RtsEnable = true;
            _COMPort.DtrEnable = true;
        }

        public string Send(string input)
        {
            //Si le port est ouvert
            if (_COMPort.IsOpen)
            {
                //On récupert le nombre de caractère de la trame
                int length = input.Length / 2;
                //On envoie la trâme
                _COMPort.Write(Utils.PrepareToSend(input), 0, length);
                return Read();
            }
            return "Un probleme à été rencontrer";
        }
        public string Read()
        {
            int intBuffer;
            intBuffer = _COMPort.BytesToRead;
            byte[] byteBuffer = new byte[intBuffer];
            _COMPort.Read(byteBuffer, 0, intBuffer);
            return BitConverter.ToString(byteBuffer).Replace("-", "");
        }
        /// <summary>
        /// On stop la connexion avec le signal
        /// </summary>
        public void Stop()
        {
            //On stop
            _COMPort.Close();
        }
    }
}
