using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treee
{
    public partial class Form1 : Form
    {
        MyBinaryTree<string, int> tree = new MyBinaryTree<string, int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void tb_conclusion_Refresh()
        {
            tb_conclusion.Clear();
            foreach (var item in tree)
            {
                tb_conclusion.Text += "{" + item + "}";
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                tree.Insert(tb_insert_key.Text, Convert.ToInt32(tb_insert_value.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            tb_conclusion_Refresh();
        }

        private void btn_contain_Click(object sender, EventArgs e)
        {
            try
            {
                tb_contains.Text = 
                    tree.Contains(Convert.ToInt32(tb_contains.Text)).ToString();
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                tree.Delete(Convert.ToInt32(tb_delete.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            tb_conclusion_Refresh();
        }

        private void btn_across_Click(object sender, EventArgs e)
        {
            try
            {
                tb_conclusion.Clear();
                foreach (var item in tree.Across())
                {
                    tb_conclusion.Text += "{" + item.Value + "}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btn_CLR_Click(object sender, EventArgs e)
        {
            try
            {
                tb_conclusion.Clear();
                foreach (var item in tree.CLR())
                {
                    tb_conclusion.Text += "{" + item.Value + "}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btn_LCR_Click(object sender, EventArgs e)
        {
            try
            {
                tb_conclusion.Clear();
                foreach (var item in tree.LCR())
                {
                    tb_conclusion.Text += "{" + item.Value + "}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btn_RCL_Click(object sender, EventArgs e)
        {
            try
            {
                tb_conclusion.Clear();
                foreach (var item in tree.RCL())
                {
                    tb_conclusion.Text += "{" + item.Value + "}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btn_ValueByKey_Click(object sender, EventArgs e)
        {
            try
            {
                tb_ValueByKey.Text = tree.ValueByKey(tb_ValueByKey.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btn_KeyByValue_Click(object sender, EventArgs e)
        {
            try
            {
                tb_KeyByValue.Text = tree.KeyByValue(Convert.ToInt32(tb_KeyByValue.Text));
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

        private void btn_ContainsKey_Click(object sender, EventArgs e)
        {
            try
            {
                tb_ContainsKey.Text = tree.ContainsKey(tb_ContainsKey.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btn_ContainsValue_Click(object sender, EventArgs e)
        {
            try
            {
                tb_ContainsValue.Text = tree.ContainsValue(Convert.ToInt32(tb_ContainsValue.Text)).ToString();
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
    }
}
