using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_app
{
    public partial class Form1 : Form
    {
        private MyStack<int> mystack;
        public Form1()
        {
            InitializeComponent();
        }

        //Задание стека
        private void Form1_Load(object sender, EventArgs e)
        {
            mystack = new MyStack<int>(8);
        }

        private void push_btn_Click(object sender, EventArgs e)
        {
            mystack.Push(Convert.ToInt32(textBox1.Text));
            listBox1_Refresh();
        }
        
        public void listBox1_Refresh()
        {
            listBox1.Items.Clear();
            for (int i = mystack.Count()-1; i >= 0; i--) 
            {
                listBox1.Items.Add(mystack.Value(i));
            }
        }

        private void pop_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = mystack.Pop().ToString();
            listBox1_Refresh();
        }

        private void peek_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = mystack.Peek().ToString();
        }
    }
}
