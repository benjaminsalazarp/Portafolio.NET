using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace WebOnT
{
    public class Email
    {
        MailMessage m = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        public bool enviarCorreo(string email,string nombre,string apellido_p, string apellido_m,string rut,string fono,
            string colegio,string curso)
        {
            try
            {
                m.From = new MailAddress("portafolioG42017@gmail.com");
                m.Subject = "PeticionRegistro";
                m.To.Add(new MailAddress("portafolioG42017@gmail.com"));
                string mensaje = "email: " + email + "\n" +
                                "Nombre: " + nombre + "\n" +
                                "Apellido paterno: " + apellido_p + "\n" +
                                "Apellido materno: " + apellido_m + "\n" +
                                "Rut: " + rut + "\n" +
                                "Fono: " + fono + "\n" +
                                "Colegio: " + colegio + "\n" +
                                "Curso: " + curso + "\n";
                m.Body = mensaje;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("portafolioG42017@gmail.com", "portafolio04");
                smtp.EnableSsl = true;
                smtp.Send(m);



                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
                return false;
            }
        }
    }
}