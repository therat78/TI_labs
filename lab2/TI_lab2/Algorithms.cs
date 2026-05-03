using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_lab2
{
    public class Algorithms
    {
        int START_REG_LENGTH;
        byte[] register;
        int bitCount;
        int[] feedbackTaps = { 24, 2, 0 };
        public byte[] originalData;
        public byte[] encryptedData;
        StringBuilder keyStream;

        public Algorithms(int startRegLength)
        {
            this.START_REG_LENGTH = startRegLength;
            register = new byte[START_REG_LENGTH];
        }

        public string GenKeyStream()
        {
            keyStream = new StringBuilder();

            bitCount = originalData.Length * 8;

            for (int i = 0; i < bitCount; i++)
            {
                int outputBit = register[START_REG_LENGTH - 1];
                keyStream.Append(outputBit);

                byte feedback = 0;
                foreach (int tap in feedbackTaps)
                {
                    feedback ^= register[tap];
                }

                for (int j = START_REG_LENGTH - 1; j > 0; j--)
                {
                    register[j] = register[j - 1];
                }

                register[0] = feedback;
            }

            return keyStream.ToString();
        }

        public void GetStartReg(string initRegState)
        {
            for (int i = 0; i < START_REG_LENGTH - 1; i++)
            {
                register[START_REG_LENGTH - 1 - i] = byte.Parse(initRegState[i].ToString());
            }
        }

        public string GetBinaryPreview(byte[] data)
        {
            if (data == null || data.Length == 0) return "";

            StringBuilder sb = new StringBuilder();
            int bitsAdded = 0;

            for (int i = 0; i < data.Length; i++)
            {
                for (int bit = 7; bit >= 0; bit--)
                {
                    sb.Append((data[i] >> bit) & 1);
                    bitsAdded++;

                    if (bitsAdded % 8 == 0)
                        sb.Append(" ");
                }
            }

            return sb.ToString();
        }

        public string GetBinaryPreview(string data)
        {
            if (data == null || data.Length == 0) return "";

            StringBuilder sb = new StringBuilder();
            int bitsAdded = 0;

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i]);
                bitsAdded++;
                if (bitsAdded % 8 == 0)
                    sb.Append(" ");
            }

            return sb.ToString();
        }

        public byte[] EncryptDecryptData()
        {
            if (keyStream.Length < bitCount)
            {
                throw new Exception("Длина ключевого потока меньше длины данных!");
            }

            byte[] result = new byte[originalData.Length];

            for (int byteIdx = 0; byteIdx < originalData.Length; byteIdx++)
            {
                byte originalByte = originalData[byteIdx];
                byte encryptedByte = 0;

                for (int bitIdx = 0; bitIdx < 8; bitIdx++)
                {
                    int keyBit = int.Parse(keyStream[byteIdx * 8 + bitIdx].ToString());
                    int originalDataBit = (originalByte >> (7 - bitIdx)) & 1;
                    int resultBit = originalDataBit ^ keyBit;

                    encryptedByte |= (byte)(resultBit << (7 - bitIdx));
                }

                result[byteIdx] = encryptedByte;
            }

            return result;
        }
    }
}
