using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hash_tabl
{
    public partial class Form1 : Form
    {
        MyHashTable<string, int> hashtable = new MyHashTable<string, int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void tb_conclusion_Refresh()
        {
            listBox1.Items.Clear();
            foreach (var item in hashtable)
            {
                listBox1.Items.Add("{ Key = " + item.Key + ", Value = " + item.Value + " }");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                hashtable.Add(tb_add_key.Text, Convert.ToInt32(tb_add_value.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            tb_conclusion_Refresh();
        }

        private void btn_find_Click_1(object sender, EventArgs e)
        {
            try
            {
                tb_find_value.Text = hashtable.Find(tb_find_key.Text).Value.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                hashtable.Delete(tb_delete_key.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            } 

            tb_conclusion_Refresh();
        }
    }
}
