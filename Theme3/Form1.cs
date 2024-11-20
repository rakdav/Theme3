using System.Net.Mail;
using System.Net;

namespace Theme3
{
    public partial class Form1 : Form
    {
        private string server = "smtp.mail.ru";//�������� ����� ����� ������ �������
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //������� ������ ���������
            MailMessage message = new MailMessage(
            fromBox.Text, toBox.Text,
            themeBox.Text, bodyBox.Text);
            //������� ������ ��������
            SmtpClient client = new SmtpClient(server,25);
            client.Credentials =
            new NetworkCredential(fromBox.Text, "");//���� ��� �������
            client.EnableSsl = true;
            //�������� ����������� �������� ���������
            client.SendAsync(message, "That�s all");
        }
    }
}
