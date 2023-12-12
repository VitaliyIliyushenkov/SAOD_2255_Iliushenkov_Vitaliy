namespace list_app
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_append = new System.Windows.Forms.Button();
            this.btn_prepend = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_toarray = new System.Windows.Forms.Button();
            this.btn_at = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_removeat = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.tb_append = new System.Windows.Forms.TextBox();
            this.tb_prepend = new System.Windows.Forms.TextBox();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.tb_remove = new System.Windows.Forms.TextBox();
            this.tb_at = new System.Windows.Forms.TextBox();
            this.tb_removeat = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_insert_index = new System.Windows.Forms.TextBox();
            this.tb_insert_value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_setvalue_value = new System.Windows.Forms.TextBox();
            this.tb_setvalue_index = new System.Windows.Forms.TextBox();
            this.btn_setvalue = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_append
            // 
            this.btn_append.Location = new System.Drawing.Point(13, 13);
            this.btn_append.Name = "btn_append";
            this.btn_append.Size = new System.Drawing.Size(106, 23);
            this.btn_append.TabIndex = 0;
            this.btn_append.Text = "Append";
            this.btn_append.UseVisualStyleBackColor = true;
            this.btn_append.Click += new System.EventHandler(this.btn_append_Click);
            // 
            // btn_prepend
            // 
            this.btn_prepend.Location = new System.Drawing.Point(13, 42);
            this.btn_prepend.Name = "btn_prepend";
            this.btn_prepend.Size = new System.Drawing.Size(106, 23);
            this.btn_prepend.TabIndex = 1;
            this.btn_prepend.Text = "Prepend";
            this.btn_prepend.UseVisualStyleBackColor = true;
            this.btn_prepend.Click += new System.EventHandler(this.btn_prepend_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(13, 71);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(106, 23);
            this.btn_find.TabIndex = 3;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_toarray
            // 
            this.btn_toarray.Location = new System.Drawing.Point(11, 311);
            this.btn_toarray.Name = "btn_toarray";
            this.btn_toarray.Size = new System.Drawing.Size(107, 23);
            this.btn_toarray.TabIndex = 2;
            this.btn_toarray.Text = "ToArray";
            this.btn_toarray.UseVisualStyleBackColor = true;
            this.btn_toarray.Click += new System.EventHandler(this.btn_toarray_Click);
            // 
            // btn_at
            // 
            this.btn_at.Location = new System.Drawing.Point(13, 149);
            this.btn_at.Name = "btn_at";
            this.btn_at.Size = new System.Drawing.Size(107, 23);
            this.btn_at.TabIndex = 5;
            this.btn_at.Text = "At";
            this.btn_at.UseVisualStyleBackColor = true;
            this.btn_at.Click += new System.EventHandler(this.btn_at_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(13, 120);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(106, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_removeat
            // 
            this.btn_removeat.Location = new System.Drawing.Point(13, 194);
            this.btn_removeat.Name = "btn_removeat";
            this.btn_removeat.Size = new System.Drawing.Size(107, 23);
            this.btn_removeat.TabIndex = 6;
            this.btn_removeat.Text = "RemoveAt";
            this.btn_removeat.UseVisualStyleBackColor = true;
            this.btn_removeat.Click += new System.EventHandler(this.btn_removeat_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(11, 282);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(106, 23);
            this.bt_insert.TabIndex = 7;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(12, 415);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(107, 23);
            this.btn_random.TabIndex = 8;
            this.btn_random.Text = "RandomUp";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // tb_append
            // 
            this.tb_append.Location = new System.Drawing.Point(126, 14);
            this.tb_append.Name = "tb_append";
            this.tb_append.Size = new System.Drawing.Size(100, 22);
            this.tb_append.TabIndex = 9;
            // 
            // tb_prepend
            // 
            this.tb_prepend.Location = new System.Drawing.Point(126, 44);
            this.tb_prepend.Name = "tb_prepend";
            this.tb_prepend.Size = new System.Drawing.Size(100, 22);
            this.tb_prepend.TabIndex = 10;
            // 
            // tb_find
            // 
            this.tb_find.Location = new System.Drawing.Point(126, 72);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(100, 22);
            this.tb_find.TabIndex = 11;
            // 
            // tb_remove
            // 
            this.tb_remove.Location = new System.Drawing.Point(125, 120);
            this.tb_remove.Name = "tb_remove";
            this.tb_remove.Size = new System.Drawing.Size(100, 22);
            this.tb_remove.TabIndex = 12;
            // 
            // tb_at
            // 
            this.tb_at.Location = new System.Drawing.Point(126, 150);
            this.tb_at.Name = "tb_at";
            this.tb_at.Size = new System.Drawing.Size(100, 22);
            this.tb_at.TabIndex = 13;
            // 
            // tb_removeat
            // 
            this.tb_removeat.Location = new System.Drawing.Point(126, 194);
            this.tb_removeat.Name = "tb_removeat";
            this.tb_removeat.Size = new System.Drawing.Size(100, 22);
            this.tb_removeat.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(230, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 450);
            this.listBox1.TabIndex = 15;
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(126, 415);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(100, 22);
            this.tb_size.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Кол-во эл-ов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Вывод:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Вывод:";
            // 
            // tb_insert_index
            // 
            this.tb_insert_index.Location = new System.Drawing.Point(124, 282);
            this.tb_insert_index.Name = "tb_insert_index";
            this.tb_insert_index.Size = new System.Drawing.Size(24, 22);
            this.tb_insert_index.TabIndex = 23;
            // 
            // tb_insert_value
            // 
            this.tb_insert_value.Location = new System.Drawing.Point(154, 282);
            this.tb_insert_value.Name = "tb_insert_value";
            this.tb_insert_value.Size = new System.Drawing.Size(71, 22);
            this.tb_insert_value.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "инд.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "знач.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "знач.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "инд.";
            // 
            // tb_setvalue_value
            // 
            this.tb_setvalue_value.Location = new System.Drawing.Point(154, 238);
            this.tb_setvalue_value.Name = "tb_setvalue_value";
            this.tb_setvalue_value.Size = new System.Drawing.Size(71, 22);
            this.tb_setvalue_value.TabIndex = 29;
            // 
            // tb_setvalue_index
            // 
            this.tb_setvalue_index.Location = new System.Drawing.Point(124, 238);
            this.tb_setvalue_index.Name = "tb_setvalue_index";
            this.tb_setvalue_index.Size = new System.Drawing.Size(24, 22);
            this.tb_setvalue_index.TabIndex = 28;
            // 
            // btn_setvalue
            // 
            this.btn_setvalue.Location = new System.Drawing.Point(11, 238);
            this.btn_setvalue.Name = "btn_setvalue";
            this.btn_setvalue.Size = new System.Drawing.Size(106, 23);
            this.btn_setvalue.TabIndex = 27;
            this.btn_setvalue.Text = "SetValue";
            this.btn_setvalue.UseVisualStyleBackColor = true;
            this.btn_setvalue.Click += new System.EventHandler(this.btn_setvalue_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(14, 386);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 23);
            this.btn_clear.TabIndex = 32;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_setvalue_value);
            this.Controls.Add(this.tb_setvalue_index);
            this.Controls.Add(this.btn_setvalue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_insert_value);
            this.Controls.Add(this.tb_insert_index);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tb_removeat);
            this.Controls.Add(this.tb_at);
            this.Controls.Add(this.tb_remove);
            this.Controls.Add(this.tb_find);
            this.Controls.Add(this.tb_prepend);
            this.Controls.Add(this.tb_append);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.btn_removeat);
            this.Controls.Add(this.btn_at);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_toarray);
            this.Controls.Add(this.btn_prepend);
            this.Controls.Add(this.btn_append);
            this.Name = "Form1";
            this.Text = "List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_append;
        private System.Windows.Forms.Button btn_prepend;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_toarray;
        private System.Windows.Forms.Button btn_at;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_removeat;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.TextBox tb_append;
        private System.Windows.Forms.TextBox tb_prepend;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.TextBox tb_remove;
        private System.Windows.Forms.TextBox tb_at;
        private System.Windows.Forms.TextBox tb_removeat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_insert_index;
        private System.Windows.Forms.TextBox tb_insert_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_setvalue_value;
        private System.Windows.Forms.TextBox tb_setvalue_index;
        private System.Windows.Forms.Button btn_setvalue;
        private System.Windows.Forms.Button btn_clear;
    }
}

