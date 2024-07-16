using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHungPhu.PHUQUI
{
    public class Config
    {
        private const long desIV = 3245176605330277139L;

        private const long desKey = 1596710084089744276L;

        public static string ConnectionString = "";

        public static bool IsLocal_LAN = true;

        private string DecryptPassword(string password)
        {
            if (password == "")
            {
                return "";
            }
            byte[] bytes = BitConverter.GetBytes(1596710084089744276L);
            byte[] bytes2 = BitConverter.GetBytes(3245176605330277139L);
            byte[] array = HexStringToByteArray(password);
            MemoryStream memoryStream = new MemoryStream();
            DES dES = new DESCryptoServiceProvider();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, dES.CreateDecryptor(bytes, bytes2), CryptoStreamMode.Write);
            cryptoStream.Write(array, 0, array.Length);
            cryptoStream.Close();
            StringBuilder stringBuilder = new StringBuilder();
            byte[] array2 = memoryStream.ToArray();
            foreach (byte value in array2)
            {
                stringBuilder.Append((char)value);
            }
            return stringBuilder.ToString();
        }

        private string EncryptPassword(string password)
        {
            byte[] bytes = BitConverter.GetBytes(1596710084089744276L);
            byte[] bytes2 = BitConverter.GetBytes(3245176605330277139L);
            byte[] bytes3 = Encoding.Default.GetBytes(password);
            MemoryStream memoryStream = new MemoryStream();
            byte[] array = new byte[100];
            DES dES = new DESCryptoServiceProvider();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, dES.CreateEncryptor(bytes, bytes2), CryptoStreamMode.Write);
            cryptoStream.Write(bytes3, 0, bytes3.Length);
            cryptoStream.Close();
            StringBuilder stringBuilder = new StringBuilder();
            byte[] array2 = memoryStream.ToArray();
            foreach (byte b in array2)
            {
                stringBuilder.AppendFormat("{0:X2}", b);
            }
            return stringBuilder.ToString();
        }

        private byte[] HexStringToByteArray(string hexString)
        {
            byte[] array = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i += 2)
            {
                string value = hexString.Substring(i, 2);
                array[i / 2] = Convert.ToByte(value, 16);
            }
            return array;
        }

        public static string EncryptPass(string text)
        {
            return new Config().EncryptPassword(text);
        }

        public static string DecryptPass(string text)
        {
            return new Config().DecryptPassword(text);
        }

        public static string connectionString()
        {
            string text = new Config().DecryptPassword("0c7a03b250a2d583c626009923ae0d6572d5d5c18056d8fa1ca8e98988fa234367ba2ca5d451ab2f95dbd63161dfc6935786fd1556d1ac93");
            string text2 = new Config().DecryptPassword("c98df389ec094e25");
            string text3 = new Config().DecryptPassword("1a73948fa13dd8345abe105e99e96809");
            string text4 = new Config().DecryptPassword("1a73948fa13dd834a54c48691283303a");
            string text5 = new Config().DecryptPassword("eac1925927b4a6b71ab61bbcda2110d3e2926f6cced88613806215d5017df798");
            string text6 = new Config().DecryptPassword("33f3d52ea43e11645fa2fdb2ab9ff8b8");
            ConnectionString = text + Application.StartupPath + "\\" + text3 + text5 + text4 + text6 + text2;
            return ConnectionString;
        }

        public static string UserEmail()
        {
            return new Config().DecryptPassword("a05990e795cadba9fdf9b1b3e13a092fff659a3b219cd9d3");
        }

        public static string PassEmail()
        {
            return new Config().DecryptPassword("388f9cd3a41998404352797dfe4dd8a5");
        }

        public static string STMP()
        {
            return new Config().DecryptPassword("310310c90f83748be7045fea3d04e1ae");
        }
    }
}
