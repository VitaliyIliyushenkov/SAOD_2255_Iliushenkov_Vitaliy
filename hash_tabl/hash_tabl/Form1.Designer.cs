namespace hash_tabl
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.tb_add_key = new System.Windows.Forms.TextBox();
            this.tb_add_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_find_key = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_find_value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_delete_key = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 33);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(12, 89);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click_1);
            // 
            // tb_add_key
            // 
            this.tb_add_key.Location = new System.Drawing.Point(94, 33);
            this.tb_add_key.Name = "tb_add_key";
            this.tb_add_key.Size = new System.Drawing.Size(100, 22);
            this.tb_add_key.TabIndex = 2;
            // 
            // tb_add_value
            // 
            this.tb_add_value.Location = new System.Drawing.Point(201, 33);
            this.tb_add_value.Name = "tb_add_value";
            this.tb_add_value.Size = new System.Drawing.Size(100, 22);
            this.tb_add_value.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "key";
            // 
            // tb_find_key
            // 
            this.tb_find_key.Location = new System.Drawing.Point(95, 90);
            this.tb_find_key.Name = "tb_find_key";
            this.tb_find_key.Size = new System.Drawing.Size(100, 22);
            this.tb_find_key.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "=>";
            // 
            // tb_find_value
            // 
            this.tb_find_value.Location = new System.Drawing.Point(228, 90);
            this.tb_find_value.Name = "tb_find_value";
            this.tb_find_value.Size = new System.Drawing.Size(100, 22);
            this.tb_find_value.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "key";
            // 
            // tb_delete_key
            // 
            this.tb_delete_key.Location = new System.Drawing.Point(96, 145);
            this.tb_delete_key.Name = "tb_delete_key";
            this.tb_delete_key.Size = new System.Drawing.Size(100, 22);
            this.tb_delete_key.TabIndex = 12;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(13, 144);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(355, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 372);
            this.listBox1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_delete_key);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_find_value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_find_key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_add_value);
            this.Controls.Add(this.tb_add_key);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox tb_add_key;
        private System.Windows.Forms.TextBox tb_add_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_find_key;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_find_value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_delete_key;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
    }
}

