using System;
using System.Text.RegularExpressions;

namespace SWSDK.Helpers
{
    public static  class Validation
    {
         public static void ValidateHeaderParameters(string url, string token)
        {
            if (string.IsNullOrEmpty(url) || url == "/")
                throw new ServicesException("Falta Capturar URL");

            if (string.IsNullOrEmpty(token))
                throw new ServicesException("Falta Capturar Token");   

            if(token.Split('.').Length != 3)
                throw new ServicesException("Token Mal Formado");
        }

        public static void validateb64(this string value) 
        {
            if(!(value.Length % 4 == 0) && Regex.IsMatch(value, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None))
                 throw new ServicesException($"{nameof(value)} No es base64");
        }

        public static void validateValue<T>(T value) 
        {
            if (typeof(T) == typeof(string))
                if(string.IsNullOrEmpty(value as string))
                    throw new ServicesException($"{nameof(value)} es Null o Empty");
            if (typeof(T) == typeof(int))
                if(Convert.ToInt32(value) < 0 || value.Equals(default(T)))
                    throw new ServicesException($"{nameof(value)} es menor a 1");
            if (value == null || value.Equals(default(T)))
                throw new ServicesException($"{nameof(value)} es Null o Empty");
        }

        public static void ValidateGuid(this string guid)
        {
            if (!Guid.TryParse(guid, out _))
                throw new ServicesException("Guid invalido");
        }
    }
}