using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Steganography
{
    class Encrypt
    {
        // Variables
        //private static int keyLength = 256;
        RijndaelManaged AESCrypto = new RijndaelManaged();
        System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();

        // Methods
        public void setKey(string inKey)
        {
            //AESCrypto.Key = Encoding.UTF8.GetBytes(inKey); // Sets key to user-defined key in settings
            
        }

        public string DecryptAES(string inText)
        {
            byte[] inBytes = ascii.GetBytes(inText);
            MemoryStream ms = new MemoryStream(inBytes); // Creates new memory stream with the encrypted string opened
            string plainText;
            try
            {
                ICryptoTransform decryptor = AESCrypto.CreateDecryptor(AESCrypto.Key, AESCrypto.IV); // Creates AES Decryptor
                CryptoStream Crypto_Stream = new CryptoStream(ms, decryptor, CryptoStreamMode.Write); // Creates Cryptography memory stream
                StreamReader Stream_Read = new StreamReader(Crypto_Stream);
                //plainText = Crypto_Stream.ToString();
                plainText = Stream_Read.ReadToEnd(); // Reads plaintext from cryptography stream
                return plainText;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }

        }

        public string EncryptAES(string plainText)
        {
            byte[] EncryptedBytes;
            try
            {
                MemoryStream ms = new MemoryStream(); // Create new memory stream
                ICryptoTransform Encryptor = AESCrypto.CreateEncryptor(AESCrypto.Key, AESCrypto.IV); // Creates encrypting instance
                CryptoStream Crypto_Stream = new CryptoStream(ms, Encryptor, CryptoStreamMode.Write); // Creates cryptography memory stream
                //StreamReader Stream_Read = new StreamReader(Crypto_Stream);

                byte[] plainBytes = ascii.GetBytes(plainText); // Converts string plain text to Byte array of plain text

                Crypto_Stream.Write(plainBytes, 0, plainBytes.Length); // Writes plain text to encrypting stream
                EncryptedBytes = ms.ToArray();
                string encryptionFinal = ascii.GetString(EncryptedBytes);
                //foreach(byte x in EncryptedBytes)
                //{
                //    encryptionFinal += ascii.GetString(x);
                //}
                return encryptionFinal; // Returns array in string form

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }
            
        }
    }
}
