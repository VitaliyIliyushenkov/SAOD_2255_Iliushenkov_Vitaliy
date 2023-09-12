using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                mystack = new MyStack<int>((int)numericUpDown1.Value);
            }
            catch 
            {
                throw new Exception("Filling error");
            }
        }

        private void push_btn_Click(object sender, EventArgs e)
        {
            try
            {
                mystack.Push(Convert.ToInt32(textBox1.Text));
            }
            catch
            {
                throw new Exception("Transmission error");
            }
            
            listBox1_Refresh();
        }
        
        private void listBox1_Refresh()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < mystack.Values().Count(); i++) 
            {
                listBox1.Items.Add(mystack.Values()[i]);
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
