using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue_app
{
    public partial class Form1 : Form
    {
        private MyQueue<int> myqueue;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            myqueue = new MyQueue<int>((int)numericUpDown1.Value);
            listBox1_Refresh();
        }

        private void enqueue_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myqueue.Enqueue(Convert.ToInt32(textBox1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошло переполнение очереди");
            }

            listBox1_Refresh();
        }

        private void dequeue_btn_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = myqueue.Dequeue().ToString();
                listBox1_Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Пустая очередь");
            }
        }

        private void peek_btn_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = myqueue.Peek().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Пустая очередь");
            }
        }
        private void listBox1_Refresh()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < myqueue.ToArray().Count(); i++)
            {
                listBox1.Items.Add(myqueue.ToArray()[i]);
            }
        }
    }
}
