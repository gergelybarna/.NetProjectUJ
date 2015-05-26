using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace AutoWashingProject
{
    class SendEmail
    {


        public SendEmail() { }




        public void Send(User user, Reservation resv, string p)
        {
            var fromAddress = new MailAddress("servizauto@gmail.com");
            var toAddress = new MailAddress(user.Email);//User emailcime
            const string fromPassword = "automosas";
            const string subject = "Emlékeztető a helyfoglalásról";
             string username = user.Name;
             string plate = p;
            string reserveddate = resv.Date.ToString();
             string body = "Kedves " + username + " \n Ez egy emlékeztető e-mail \n Ön az imént helyet foglalt a(z) " + plate + " rendszámú kocsijával , a(z) " + reserveddate + "dátumra a mi szervizunkben./n Köszönettel az Auto Mosás & Szerviz csapata.";

            try
            {

                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };


                var message = new MailMessage(fromAddress.Address, toAddress.Address, subject, body);

                smtp.Send(message);
                // ("Message Sent Successfully");
                // Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Console.ReadKey();
            }

        }


    }
}

