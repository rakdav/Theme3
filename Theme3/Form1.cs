using System.Net.Mail;
using System.Net;

namespace Theme3
{
    public partial class Form1 : Form
    {
        private string server = "100.30.0.30";//�������� ����� ����� ������ �������
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
            SmtpClient client = new SmtpClient(server);
            client.Port = 25; //����� ���������������
                              //���� �������
                              //��������� ��� �������� �����(����� � ������
            client.Credentials =
            new NetworkCredential("test", "test");
            //�������� ����������� �������� ���������
            client.SendAsync(message, "That�s all");
        }
    }
}
