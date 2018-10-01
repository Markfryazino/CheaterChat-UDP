using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Cheater_Chat_1._3
{
    public class User //класс пользователя
    {
        public string Name;
        public UdpClient UDP = null;
        public MainForm Form;
        private Task ListeningTask = null;

        public static string GroupStringIP = "230.230.230.230"; //координаты группы
        public static IPAddress GroupIP = IPAddress.Parse(GroupStringIP);
        public static int GroupPort = 1984;

        public User(string NickName, MainForm _form) //конструктор юзера
        {
            try
            {
                Name = NickName;
                Form = _form;
                UDP = new UdpClient(GroupPort);
                UDP.JoinMulticastGroup(GroupIP, 50);
                ListeningTask = new Task(ListenToMessages);
                ListeningTask.Start();
                WriteMessage(Name + " присоединился к чату", "присоединился");
            }
            catch (Exception e)
            {
                Outputter.PrintException(e);
            }
        }

        private void ListenToMessages() //метод для прослушки сообщений
        {
            try
            {
                while (true)
                {
                    IPEndPoint remoteIP = null;
                    byte[] byteMessage = UDP.Receive(ref remoteIP);
                    string[] receivedMessage = Encoding.Unicode.GetString(byteMessage).Split('$');

                    Form.Invoke(new MethodInvoker(() =>
                    {
                        if (receivedMessage[0] != "нет")
                            Outputter.PrintMessage(receivedMessage[0]);
                        if (receivedMessage.Length > 1)
                        {
                            if (receivedMessage[1] == "покинул")
                                Outputter.RemoveUser(receivedMessage[2]);
                            else if (receivedMessage[1] == "присоединился")
                            {
                                Outputter.AddUser(receivedMessage[2]);
                                WriteMessage("нет", "подключен");
                            }
                            else if (receivedMessage[1] == "подключен")
                            {
                                if (receivedMessage[2] != Name)
                                    Outputter.AddUser(receivedMessage[2]);
                            }
                        }
                    }));
                }
            }
            catch (Exception e)
            {
                Form.Invoke(new MethodInvoker(() =>
                {
                    Outputter.PrintException(e);
                    Outputter.PrintWarning("\nКлиент перестал получать сообщения. Вам придется перезагрузить программу.");
                }));
            }
        }

        public void WriteMessage(string message, string additional = "") //метод для отправки сообщения
        {
            try
            {
                string finalMessage = "";
                if (additional == "") finalMessage = message;
                else finalMessage = message + "$" + additional + "$" + Name;
                byte[] toSend = Encoding.Unicode.GetBytes(finalMessage);
                int numSend = 0;
                while (numSend != toSend.Length)
                {
                    numSend = UDP.Send(toSend, toSend.Length, GroupStringIP, GroupPort);
                }
            }
            catch (Exception e)
            {
                Outputter.PrintException(e);
                Outputter.PrintWarning("\nНе удалось отправить сообщение.");
            }
        }

        public void Destroy()
        {
            WriteMessage(Name + " покинул чат.", "покинул");
            if (UDP != null) 
                UDP.Close();
        }
    }
}
