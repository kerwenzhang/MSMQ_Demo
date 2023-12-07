using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            using (MessageQueue queue = MessageQueue.Create(@".\private$\myqueue"))
            {
                queue.Label = "First Queue";
                MessageBox.Show($"Queue Created, Path: {queue.Path}, FormatName: {queue.FormatName}");
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string publicQueuePath = string.Empty;
            //foreach (MessageQueue queue in MessageQueue.GetPublicQueues())
            //{
            //    publicQueuePath += queue.Path + "\r\n";
            //}

            string privateQueuePath = string.Empty;
            foreach (MessageQueue queue in MessageQueue.GetPrivateQueuesByMachine("localhost"))
            {
                privateQueuePath += queue.Path + "\r\n";
            }
            MessageBox.Show($"Get all public queues: \r\n {publicQueuePath} Get all private queues: \r\n {privateQueuePath}");
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MessageQueue.Exists(@".\Private$\myqueue"))
                {
                    MessageQueue.Create(@".\Private$\myqueue");
                }
                MessageQueue queue = new MessageQueue(@".\Private$\myqueue");
                //queue.Send("First Message ", "Label1");

                var emp = new Employee()
                {
                    Id = 100,
                    Name = "John Doe",
                    Hours = 55,
                    Rate = 21.0
                };

                System.Messaging.Message msg = new System.Messaging.Message();
                msg.Body = emp;
                queue.Send(msg);
            }
            catch (MessageQueueException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            MessageQueue queue = new MessageQueue(@".\Private$\myqueue");
            //queue.Formatter = new XmlMessageFormatter(new String[] { "System.String, mscorlib" });
            //System.Messaging.Message Mymessage = queue.Receive();
            //labelQueue.Text = Mymessage.Body.ToString();

            var emp = new Employee();
            queue.Formatter = new XmlMessageFormatter(new Type[] { typeof(Employee) });
            emp = ((Employee)queue.Receive().Body);
            labelQueue.Text = $"Employee name: {emp.Name} Salary: {emp.Hours * emp.Rate}";
        }
    }
    public class Employee
    {
        public int Id;
        public string Name;
        public int Hours;
        public double Rate;
    }
}
