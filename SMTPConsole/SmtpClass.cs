using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SMTPConsole
{
    internal class SmtpClass
    {
        private string? to;
        private string? from;
        private string? subject;
        private string? body;
        private string? server;
        private string Prompt(string query)
        {
            Console.WriteLine(query);
            return Console.ReadLine()!;
        }
        public void Dialog()
        {
            to = Prompt("Введите адрес получателя:");
            from = Prompt("Введите адрес отправителя:");
            subject = Prompt("Введите тему");
            body = Prompt("Введите текст сообщения:");
            server = Prompt("Введите адрес сервера:");
        }
        public void SendMail()
        {
            MailMessage message = new
            MailMessage(from!, to!, subject, body);
            SmtpClient client = new SmtpClient(server);
            client.Timeout = 10000;
            client.Credentials = new NetworkCredential(from, "dpvbXBcruyxcDUz4BUCU");
            client.EnableSsl = true;
            try
            {
                client.Send(message);
                Console.WriteLine("Сообщение отправлено");
            }
            catch (SmtpException se)
            {
                Console.WriteLine("Сообщение не " +
                "отправлено по причине" +
                se.Message);
            }
        }
    }
}
