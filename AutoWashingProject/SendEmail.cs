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
        private string from;
        private string To;
        private string CC;
        private string BCC;
        private string Subject;
        private string Message;
        private string AttachmentFileNames;

        public SendEmail() { }

        public SendEmail(string from, string To, string CC, string BCC, string Subject, string Messag, string AttachmentFileNames)
        {
            this.from = from;
            this.To = To;
            this.CC = CC;
            this.BCC = BCC;
            this.Subject = Subject;
            this.Message = Message;
            this.AttachmentFileNames = AttachmentFileNames;


        }

        public string From
        {
            get { return from; }
            set { from = value; }
        }


        public string To1
        {
            get { return To; }
            set { To = value; }
        }



        public string CC1
        {
            get { return CC; }
            set { CC = value; }
        }


        public string BCC1
        {
            get { return BCC; }
            set { BCC = value; }
        }


        public string Subject1
        {
            get { return Subject; }
            set { Subject = value; }
        }


        public string Message1
        {
            get { return Message; }
            set { Message = value; }
        }


        public string AttachmentFileNames1
        {
            get { return AttachmentFileNames; }
            set { AttachmentFileNames = value; }
        }

        public void Send(User user,Reservation resv)
        {
            var fromAddress = new MailAddress("servizauto@gmail.com");
            var toAddress = new MailAddress("");//User emailcime
            const string fromPassword = "automosas";
            const string subject = "Emlékeztető a helyfoglalásról";
            const string username="User";
            const string plate="SM 00 MMM";
            const string reserveddate="2015.06.25";
            const string body = "Kedves "+ username+" \n Ez egy emlékeztető e-mail \n Ön az imént helyet foglalt a(z)"+plate+"rendszámú kocsijával , a(z) "+reserveddate+"dátumra a mi szervizunkben./n Köszönettel az Auto Mosás & Szerviz csapata.";

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
               // Console.WriteLine(ex.Message);
               // Console.ReadKey();
            }

        }


    }
}

