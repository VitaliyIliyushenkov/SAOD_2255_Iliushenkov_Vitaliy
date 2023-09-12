using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
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
                mystack = new MyStack<int>((int)numericUpDown1.Value);
                listBox1_Refresh();
        }

        private void push_btn_Click(object sender, EventArgs e)
        {
            try
            {
                mystack.Push(Convert.ToInt32(textBox1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошло переполнение стека");
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
            try
            {
                textBox1.Text = mystack.Pop().ToString();
                listBox1_Refresh();
            }
            catch(Exception)
            {
                MessageBox.Show("Cтек пустой");
            }
        }

        private void peek_btn_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = mystack.Peek().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Cтек пустой");
            }
        }
    }
}
