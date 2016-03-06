using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RSA_and_Steam
{
    class RSA
    {
        public byte[] _exponent;
        public byte[] _modulus;

        public string Exponent
        {
            set
            {
                _exponent = hexToBytes(value);
            }
        }

        public string Modulus
        {
            set
            {
                _modulus = hexToBytes(value);
            }
        }

        public string Encrypt(string data)
        {
            //string encrypted;
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            var parametrs = new RSAParameters();
            var provider = new RSACryptoServiceProvider();

            parametrs.Exponent = _exponent;
            parametrs.Modulus = _modulus;
            provider.ImportParameters(parametrs);

            return Convert.ToBase64String(provider.Encrypt(byteData, false));
        }

        private byte[] hexToBytes(string hex)
        {
            byte[] arr = new byte[hex.Length >> 1];
            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((getHexVal(hex[i << 1]) << 4) + (getHexVal(hex[(i << 1) + 1])));
            }
            return arr;
        }

        private int getHexVal(char hex)
        {
            int val = (int)hex;
            return val - (val < 58 ? 48 : 55);
        }

    }
}
