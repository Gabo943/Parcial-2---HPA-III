using Negocio.Contratos;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Negocio.Servicios
{
    public class Sha512HashService : IHashService, IVerificarHashService
    {
        public string GenerarHash(string passwordPlano)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(passwordPlano);
                byte[] hashBytes = sha512.ComputeHash(bytes);
                return ConvertirAHex(hashBytes);
            }
        }

        public bool VerificarHash(string passwordPlano, string hashAlmacenado)
        {
            string hashCalculado = GenerarHash(passwordPlano);
            // Comparación con tiempo constante para evitar timing attacks
            return CompararSeguro(hashCalculado, hashAlmacenado);
        }

        private static string ConvertirAHex(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        private static bool CompararSeguro(string a, string b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            int resultado = 0;
            for (int i = 0; i < a.Length; i++)
                resultado |= a[i] ^ b[i];

            return resultado == 0;
        }
    }
}