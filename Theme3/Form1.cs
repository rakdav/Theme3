using System.Net.Mail;
using System.Net;

namespace Theme3
{
    public partial class Form1 : Form
    {
        private string server = "100.30.0.30";//запишите здесь адрес вашего сервера
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
            SmtpClient client = new SmtpClient(server);
            client.Port = 25; //здесь устанавливаетс€
                              //порт сервера
                              //настройки дл€ отправки почты(логин и пароль
            client.Credentials =
            new NetworkCredential("test", "test");
            //вызываем асинхронную отправку сообщени€
            client.SendAsync(message, "ThatТs all");
        }
    }
}
