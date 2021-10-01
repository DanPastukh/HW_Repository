using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1_HW06._09._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Socket socket = null;
            int portStart = (int)numericUpDownPortStart.Value;
            int portEnd = (int)numericUpDownPortEnd.Value;

            Task.Factory.StartNew(() => {
                Parallel.For((int)numericUpDownStart.Value,(int) numericUpDownEnd.Value+1, iPcount =>
                 {
                     IPAddress iP= IPAddress.Parse($"{textBoxStart.Text}{iPcount}");
                     Parallel.For(portStart, portEnd, port => {
                         try
                         {
                             //Створюєм кінцеву точку
                             IPEndPoint iPEndPoint = new IPEndPoint(iP, port);//ip adress+номер порта/ 

                             //Створення сокета
                             socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//AddressFamily.InterNetwork - IPv4 

                             socket.Connect(iPEndPoint);

                             listBox1.Invoke(new Action(() => listBox1.Items.Add($"IP {iP} | Port is busy: {port}")));
                         }
                         catch (Exception ex)
                         {
                             listBox1.Invoke(new Action(() => listBox1.Items.Add($"IP {iP} | Port is free: {port}")));
                         }
                         finally
                         {
                             socket.Close();
                         }
                     });
                 });
            });
                
        }
    }
}
