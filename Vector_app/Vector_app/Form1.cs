using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vector_app
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        private MyVector<int> myvector = new MyVector<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_Refresh()
        {
            listBox1.Items.Clear();
            foreach (var item in myvector)
            {
                listBox1.Items.Add(item);
            }
        }

        private void CapSize_Refresh()
        {
            tb_capacity.Text = myvector.Capacity.ToString();
            tb_size.Text = myvector.Size.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                myvector.Add(Convert.ToInt32(tb_add.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            CapSize_Refresh();
            listBox1_Refresh();
        }

        private void btn_setvalue_Click(object sender, EventArgs e)
        {
            try
            {
                myvector.SetValue(Convert.ToInt32(tb_setvalue_index.Text), Convert.ToInt32(tb_setvalue_value.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            CapSize_Refresh();
            listBox1_Refresh();
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            try
            {
                myvector.Resize(Convert.ToInt32(tb_resize.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            CapSize_Refresh();
            listBox1_Refresh();
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            try
            {
                myvector.Reserve(Convert.ToInt32(tb_reserve.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            CapSize_Refresh();
            listBox1_Refresh();
        }

        private void btn_shrinkto_Click(object sender, EventArgs e)
        {
            try
            {
                myvector.ShrinkToFit();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            CapSize_Refresh();
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            myvector = new MyVector<int>((int)numericUpDown1.Value);
            for (int i = 0; i < myvector.Capacity; i++)
            {
                int item = random.Next(100);
                myvector.Add(item);
            }
            listBox1_Refresh();
            CapSize_Refresh();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            myvector = new MyVector<int>((int)numericUpDown1.Value);
            CapSize_Refresh();
            listBox1_Refresh();
        }
    }
}
