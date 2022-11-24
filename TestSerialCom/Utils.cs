using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestSerialCom
{
    public static  class Utils
    {
        /// <summary>
        /// Envoie de message personnaliser a la vue
        /// </summary>
        /// <param name="type">Type du message</param>
        /// <param name="msg">Le contenue du message</param>
        public static void MessageSend(string type, string msg)
        {
            switch (type)
            {
                case "info":
                    MessageBox.Show(msg, "Test-Tools V2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "error":
                    MessageBox.Show(msg, "Test-Tools V2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "warning":
                    MessageBox.Show(msg, "Test-Tools V2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default:
                    MessageBox.Show(msg, "Test-Tools V2", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
            }
        }
        /// <summary>
        /// Permet d'enlever les espaces des inputs
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveSpace(string input)
        {
            //On enlève les espace dans les trames
            return Regex.Replace(input, @"\s+", "");
        }
        /// <summary>
        /// Convert hex string to byte array for send
        /// </summary>
        /// <param name="hex">frame in hex</param>
        /// <returns></returns>
        public static byte[] PrepareToSend(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        /// <summary>
        /// Transform String to byte array
        /// </summary>
        /// <param name="text"></param>
        /// <returns>byte array</returns>
        public static byte[] StringToByteArray(string text)
        {
            return Enumerable.Range(0, text.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(text.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
