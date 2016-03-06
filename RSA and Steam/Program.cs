﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_and_Steam
{
    class Program
    {
        static void Main(string[] args)
        {
            var rsa = new RSA();
            string pass = "hello";
            string encrypted;

            rsa.Exponent = "010001";
            rsa.Modulus = "DC2FBA25D19DD7289AAA1D39326D0C3277295DD886BDB2A570B5FFA87EDE7AA849AB92D4D2D0F486F736CDDD194F9B0D186E1D5F31026553FE281F3069264D6AB8214A8D3C76DE7573BBD2D926504EE9075072EA9AEB85B6103B0AE578D811781ABB384CA19F9A62A6E57459CD192AD9AD72D0E6B9F5E264C15D8E6F12E661E82969CE988AE868083A541573D123E8A59877B4F316B1A6C18BC611FFD4DFF72E5F33DBD2379043A5A4E40BF22331EE3CEDFD7930E942B277122D763F321C7D0147AEDB613870C16DF9E33524A4A20656D6BFF5D261A830A9E591E85B638F6A1C69928F56BB316AB3395F6A069A680FEE25BE8FCF85B4EBEC2E13B0D9490D8EA5";
            encrypted = rsa.Encrypt(pass);

            Console.WriteLine("Encrypted password {0}", encrypted);
            Console.ReadKey();
        }
    }
}