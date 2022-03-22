using System.Security.Cryptography;
using System.Text;

namespace Codi.Core.Common.Helpers;

public static class SecurityHelper
{
    private static readonly string SecretKey;

    static SecurityHelper()
    {
        var key = Environment.GetEnvironmentVariable("SecretCodiKey");
        SecretKey = key ?? throw new InvalidOperationException("The environment variable is null");
    }
    
    public static string EncryptToken(string token)  
    {  
        byte[] iv = new byte[16];  
        byte[] array;  

        using (Aes aes = Aes.Create())  
        {  
            aes.Key = Encoding.UTF8.GetBytes(SecretKey);  
            aes.IV = iv;  

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);  

            using (MemoryStream memoryStream = new MemoryStream())  
            {  
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))  
                {  
                    using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))  
                    {  
                        streamWriter.Write(token);  
                    }  

                    array = memoryStream.ToArray();  
                }  
            }  
        }  

        return Convert.ToBase64String(array);  
    }  
  
        
    public static string DecryptToken(string token)  
    {  
        byte[] iv = new byte[16];  
        byte[] buffer = Convert.FromBase64String(token);  

        using (Aes aes = Aes.Create())  
        {  
            aes.Key = Encoding.UTF8.GetBytes(SecretKey);  
            aes.IV = iv;  
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);  

            using (MemoryStream memoryStream = new MemoryStream(buffer))  
            {  
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))  
                {  
                    using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))  
                    {  
                        return streamReader.ReadToEnd();  
                    }  
                }  
            }  
        }  
    }
}