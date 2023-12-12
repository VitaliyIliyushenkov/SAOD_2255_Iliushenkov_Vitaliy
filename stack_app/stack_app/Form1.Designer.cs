namespace stack_app
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.push_btn = new System.Windows.Forms.Button();
            this.pop_btn = new System.Windows.Forms.Button();
            this.peek_btn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.ForeColor = System.Drawing.Color.Chartreuse;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(122, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(121, 486);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // push_btn
            // 
            this.push_btn.Location = new System.Drawing.Point(12, 69);
            this.push_btn.Name = "push_btn";
            this.push_btn.Size = new System.Drawing.Size(100, 40);
            this.push_btn.TabIndex = 2;
            this.push_btn.Text = "Push";
            this.push_btn.UseVisualStyleBackColor = true;
            this.push_btn.Click += new System.EventHandler(this.push_btn_Click);
            // 
            // pop_btn
            // 
            this.pop_btn.Location = new System.Drawing.Point(12, 161);
            this.pop_btn.Name = "pop_btn";
            this.pop_btn.Size = new System.Drawing.Size(100, 40);
            this.pop_btn.TabIndex = 3;
            this.pop_btn.Text = "Pop";
            this.pop_btn.UseVisualStyleBackColor = true;
            this.pop_btn.Click += new System.EventHandler(this.pop_btn_Click);
            // 
            // peek_btn
            // 
            this.peek_btn.Location = new System.Drawing.Point(12, 115);
            this.peek_btn.Name = "peek_btn";
            this.peek_btn.Size = new System.Drawing.Size(100, 40);
            this.peek_btn.TabIndex = 4;
            this.peek_btn.Text = "Peek";
            this.peek_btn.UseVisualStyleBackColor = true;
            this.peek_btn.Click += new System.EventHandler(this.peek_btn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Minimum = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 486);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.peek_btn);
            this.Controls.Add(this.pop_btn);
            this.Controls.Add(this.push_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "x";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button push_btn;
        private System.Windows.Forms.Button pop_btn;
        private System.Windows.Forms.Button peek_btn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

