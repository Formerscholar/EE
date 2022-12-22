using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();

            Form2 form2 = new Form2();

            form2.Param = processes;

            form2.Show();

        }
    }
}