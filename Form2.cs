using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Process[] Param { get; internal set; }

        private void Form2_Load(object sender, EventArgs e)
        {


            // 遍历进程列表
            foreach (Process process in Param)
            {
                // 创建一个 ListViewItem 对象
                ListViewItem item = new ListViewItem(process.ProcessName);
                //item.SubItems.Add(process.ProcessName);
                // 设置进程 ID
                item.SubItems.Add(process.Id.ToString());

                // 将 ListViewItem 添加到 ListView 控件中
                listView1.Items.Add(item);
            }
        }
    }
}
