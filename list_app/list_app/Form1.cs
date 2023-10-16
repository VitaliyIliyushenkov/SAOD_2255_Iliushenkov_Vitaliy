using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_app
{
    public partial class Form1 : Form
    {
        MyList<int> list = new MyList<int>();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_Refresh()
        {
            listBox1.Items.Clear();
            foreach (int item in list)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            list = new MyList<int>();
            try
            {
                list = new MyList<int>();
                for (int i = 0; i < Convert.ToInt32(tb_size.Text); i++)
                {
                    int item = random.Next(100);
                    list.Append(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            listBox1_Refresh();
        }

        private void btn_append_Click(object sender, EventArgs e)
        {
            try
            {
                list.Append(Convert.ToInt32(tb_append.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            listBox1_Refresh();
        }

        private void btn_prepend_Click(object sender, EventArgs e)
        {
            try
            {
                list.Prepend(Convert.ToInt32(tb_prepend.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            listBox1_Refresh();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = list.Find(Convert.ToInt32(tb_find.Text)).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                list.Remove(Convert.ToInt32(tb_remove.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            listBox1_Refresh();
        }

        private void btn_at_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = list.At(Convert.ToInt32(tb_at.Text)).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btn_removeat_Click(object sender, EventArgs e)
        {
            try
            {
                list.RemoveAt(Convert.ToInt32(tb_removeat.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            listBox1_Refresh();
        }

        private void btn_toarray_Click(object sender, EventArgs e)
        {
            label4.Text = "{";
            foreach (var item in list.ToArray()) 
            {
                label4.Text += '('+ item.ToString() + ')';
            }
            label4.Text += '}';
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            try
            {
                list.Insert(Convert.ToInt32(tb_insert_index.Text), Convert.ToInt32(tb_insert_value.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            listBox1_Refresh();
        }

        private void btn_setvalue_Click(object sender, EventArgs e)
        {
            try
            {
                list.SetValue(Convert.ToInt32(tb_setvalue_index.Text), Convert.ToInt32(tb_setvalue_value.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            listBox1_Refresh();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            list = new MyList<int>();
            label4.Text = "";
            listBox1.Items.Clear();
        }
    }
}
