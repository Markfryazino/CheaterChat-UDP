using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheater_Chat_1._3
{
    public partial class MainForm : Form
    {

        public User Client = null; //наш пользователь

        public MainForm()
        {
            InitializeComponent();
            Outputter.form = this;
        }

        private void ChangeEnabled(bool b) //функция для отключения или включения элементов
        {
            ConnectionList.Enabled = b;
            SendMessageBtn.Enabled = b;
            UserMessageBox.Enabled = b;
            MessageViewBox.Enabled = b;
        }

        private void MainForm_Load(object sender, EventArgs e) //метод, возникающий при загрузке формы
        {
            ChangeEnabled(false);
            Outputter.PrintWarning("Введи никнейм. В целях конспирации мы крайне не рекомендуем указывать настоящее имя.");
        }

        private void AuthorizeBtn_Click(object sender, EventArgs e) //по нажатию на кнопку авторизации
        {
            string inputName = AuthorizeBox.Text;
            if (inputName.Length < 4)
            {
                Outputter.PrintWarning("Имя слишком короткое.");
                return;
            }
            Client = new User(inputName, this);
            Outputter.PrintWarning("Ты вошел в чат!");
            ChangeEnabled(true);
            AuthorizeBox.ReadOnly = true;
            AuthorizeBox.BackColor = Color.FromArgb(255, 224, 192);
            AuthorizeBtn.Enabled = false;
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            string message = UserMessageBox.Text.Trim(' ', '\n');
            if (message.Contains('\n')) message = "\n" + message;
            Client.WriteMessage(Client.Name + ": " + message);
            UserMessageBox.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (Client != null)
                Client.Destroy();
            this.Close();
        }
    }
}
