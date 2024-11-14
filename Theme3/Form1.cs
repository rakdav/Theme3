using System.Net.Mail;
using System.Net;

namespace Theme3
{
    public partial class Form1 : Form
    {
        private string server = "smtp.mail.ru";//запишите здесь адрес вашего сервера
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //создаем объект сообщени€
            MailMessage message = new MailMessage(
            fromBox.Text, toBox.Text,
            themeBox.Text, bodyBox.Text);
            //создаем объект отправки
            SmtpClient client = new SmtpClient(server,25);
            client.Credentials =
            new NetworkCredential(fromBox.Text, "");//сюда код доступа
            client.EnableSsl = true;
            //вызываем асинхронную отправку сообщени€
            client.SendAsync(message, "ThatТs all");
        }
    }
}
