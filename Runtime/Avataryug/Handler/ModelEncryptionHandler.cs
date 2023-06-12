using System;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using System.IO.Compression;
using System.Security.Cryptography;
using Org.OpenAPITools.Client;

public enum EncryptionType
{
    EncryptionCompression,
    Encryption
}
public class ModelEncryptionHandler
{
    static string key = "0123456789123456";
    public static byte[] GetGlbByte(byte[] data, EncryptionType encryptionType)
    {
        byte[] outdata = null;
        if (encryptionType == EncryptionType.EncryptionCompression)
        {
            outdata = GetEncCompByte(data);
        }
        if (encryptionType == EncryptionType.Encryption)
        {
            outdata = GetGlbDecryptByte(data);
        }
        return outdata;
    }

    static byte[] GetEncCompByte(byte[] data)
    {
        AESCipher cipher = new AESCipher(key);
        byte[] decryptedData = cipher.Decrypt(data);
        string strindata = Encoding.UTF8.GetString(decryptedData);
        byte[] compressedData = Convert.FromBase64String(strindata);
        byte[] decompress = Decompress(compressedData);
        return decompress;
    }

    private static byte[] Decompress(byte[] data)
    {
        using (MemoryStream ms = new MemoryStream(data))
        {
            using (GZipStream stream = new GZipStream(ms, CompressionMode.Decompress))
            {
                using (MemoryStream decompressedMs = new MemoryStream())
                {
                    stream.CopyTo(decompressedMs);
                    return decompressedMs.ToArray();
                }
            }
        }
    }


    //static string keys = "e43262b695b3413ecdf7e8bc7bfec448";
    //static string ivs = "5025fe6b4b99af84c7f30d0258eda11c";

    static byte[] stringtobyteKey(string _key)
    {
        byte[] byteArray = new byte[_key.Length / 2];
        for (int i = 0; i < _key.Length; i += 2)
        {
            byteArray[i / 2] = Convert.ToByte(_key.Substring(i, 2), 16);
        }
        return byteArray;
    }
    public static byte[] GetGlbDecryptByte(byte[] data)
    {
        byte[] inputkey = stringtobyteKey(Configuration.SecretKey);
        byte[] inputiv = stringtobyteKey(Configuration.IVSecretKey);
        var dta = Decrypt(data, inputkey, inputiv);
        return dta;
    }
    static byte[] Decrypt(byte[] data, byte[] kye, byte[] ive)
    {
        using (var aesAlg = Aes.Create())
        {
            aesAlg.Key = kye;
            aesAlg.IV = ive;
            aesAlg.Mode = CipherMode.CBC;
            aesAlg.Padding = PaddingMode.PKCS7;
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            byte[] plainBytes = decryptor.TransformFinalBlock(data, 0, data.Length);
            return plainBytes;
        }
    }
}
public class AESCipher
{
    private byte[] key;

    public AESCipher(string key)
    {
        this.key = Encoding.UTF8.GetBytes(key);
    }

    public byte[] Decrypt(byte[] data)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = key;

            byte[] iv = Encoding.UTF8.GetBytes("0123456789123456"); // use a static IV for simplicity
            aesAlg.IV = iv;

            byte[] dataToDecrypt = data.Skip(16).ToArray();
            using (MemoryStream ms = new MemoryStream(dataToDecrypt))// data[16..]))
            {
                using (CryptoStream cs = new CryptoStream(ms, aesAlg.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (MemoryStream msDecrypted = new MemoryStream())
                    {
                        cs.CopyTo(msDecrypted);
                        return msDecrypted.ToArray();
                    }
                }
            }
        }
    }

    public byte[] Encrypt(byte[] data)
    {
        byte[] iv = Encoding.UTF8.GetBytes("0123456789123456"); // use a static IV for simplicity
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = key;
            aesAlg.IV = iv;

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                }
                byte[] encryptedData = ms.ToArray();
                byte[] result = new byte[iv.Length + encryptedData.Length];
                iv.CopyTo(result, 0);
                encryptedData.CopyTo(result, iv.Length);
                return result;
            }
        }
    }
}
