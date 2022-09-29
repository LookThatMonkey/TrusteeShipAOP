using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrusteeShipAOP.Core.Attribute;

namespace TrusteeShipAOP
{
    public partial class Form1 : Form
    {
        public static EventHandler<AspectEventArgs> OnEntry;
        public static EventHandler<AspectEventArgs> OnExit;
        public static Form1 Form;
        Class1 Class1 = new Class1();
        public Form1()
        {
            Form = this;
            InitializeComponent();
            OnEntry = (sender, e) => 
            {
                Form1.Form.AddLog(e.Name);
            };
            OnExit = (sender, e) =>
            {
                Form1.Form.AddLog(e.Name);
            };
        }

        private void AddLog(string name)
        {
            listBox1.Items.Add(name);
        }

        /// <summary>
        /// 触发Class1的Add函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Class1.Add(1, 1);
        }

        /// <summary>
        /// 累加Class1的aabbc属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Class1.aabbc++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
