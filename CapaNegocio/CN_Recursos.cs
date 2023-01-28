using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Recursos
    {

        public static string GenerarClave()
        {
            //Este metodo retorna una clave de 6 digitos
            string clave= Guid.NewGuid().ToString("N").Substring(0, 6);
            return clave;
        }


        //Esto metodo es para encriptar algun texto que se le envie como parametro
        public static string ConvertirShad256(string texto)
        {
            StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach(byte b in result)
                {
                    Sb.Append(b.ToString("x2"));
                }
            }
            return Sb.ToString();
        }

        public static bool EnviarCorreo(string correo, string asunto, string mensaje)
        {
            bool resu = false;

            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress("carlodl2lzebe@gmail.com");
                mail.Body = mensaje;
                mail.IsBodyHtml = true;
                var smtp = new SmtpClient();
                {
                    Credentials = new NetworkCredential("", ""),
                    Host = "smtp.gmail.com",
                    port= 587,
                        EnableSsl = true
                };

            }catch(Exception ex)
            {

            }
        }
    }
}
