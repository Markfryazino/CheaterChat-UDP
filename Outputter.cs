using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cheater_Chat_1._3
{
    static class Outputter
    {
        public static MainForm form;

        public static void PrintWarning(string warning) //выводим сообщение в CallBack-окне
        {
            form.CallbackBox.Text = warning;
        }

        public static void PrintMessage(Message message) //Выводим сообщение в окне для сообщений
        {
            string outputMessage = message.Sender + ": '" + message.Body + "'\n";
            form.MessageViewBox.Text += outputMessage;
        }

        public static void PrintMessage(string message) //перегрузка предыдущего
        {
            int nameLength = message.IndexOf(':');
            form.MessageViewBox.Text += (message + "\n");
            /*if (nameLength == -1) return;             //это попытка выделить разными цветами имена отправителей
            string name = message.Remove(nameLength);
            form.MessageViewBox.Select(form.MessageViewBox.Text.LastIndexOf(':') - nameLength, nameLength);
            if (name == form.Client.Name) form.MessageViewBox.SelectionColor = Color.DarkGreen;
            else form.MessageViewBox.SelectionColor = Color.DarkCyan;*/
        }

        public static void PrintException(Exception e) //выводим информацию об исключении
        {
            PrintWarning("Увы, плохой код Творца привел к непоправимой ошибке:\n" + e.Message + "\nПрограмма сделает все возможное," +
                "чтобы стабилизировать ситуацию");
        }

        public static void AddUser(string name) //добавить пользователя в список подключений
        {
            if (!form.ConnectionList.Items.Contains(name))
                form.ConnectionList.Items.Add(name);
        }

        public static void RemoveUser(string name) //убрать пользователя из списка подключений
        {
            form.ConnectionList.Items.Remove(name);
        }
    }
}
