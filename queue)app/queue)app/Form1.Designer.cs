namespace queue_app
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
            this.enqueue_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dequeue_btn = new System.Windows.Forms.Button();
            this.peek_btn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.ForeColor = System.Drawing.Color.Yellow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(118, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 520);
            this.listBox1.TabIndex = 0;
            // 
            // enqueue_btn
            // 
            this.enqueue_btn.Location = new System.Drawing.Point(12, 70);
            this.enqueue_btn.Name = "enqueue_btn";
            this.enqueue_btn.Size = new System.Drawing.Size(100, 46);
            this.enqueue_btn.TabIndex = 1;
            this.enqueue_btn.Text = "Enqueue";
            this.enqueue_btn.UseVisualStyleBackColor = true;
            this.enqueue_btn.Click += new System.EventHandler(this.enqueue_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dequeue_btn
            // 
            this.dequeue_btn.Location = new System.Drawing.Point(12, 122);
            this.dequeue_btn.Name = "dequeue_btn";
            this.dequeue_btn.Size = new System.Drawing.Size(100, 46);
            this.dequeue_btn.TabIndex = 4;
            this.dequeue_btn.Text = "Dequeue";
            this.dequeue_btn.UseVisualStyleBackColor = true;
            this.dequeue_btn.Click += new System.EventHandler(this.dequeue_btn_Click);
            // 
            // peek_btn
            // 
            this.peek_btn.Location = new System.Drawing.Point(12, 174);
            this.peek_btn.Name = "peek_btn";
            this.peek_btn.Size = new System.Drawing.Size(100, 46);
            this.peek_btn.TabIndex = 5;
            this.peek_btn.Text = "Peek";
            this.peek_btn.UseVisualStyleBackColor = true;
            this.peek_btn.Click += new System.EventHandler(this.peek_btn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Minimum = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 520);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.peek_btn);
            this.Controls.Add(this.dequeue_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enqueue_btn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button enqueue_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dequeue_btn;
        private System.Windows.Forms.Button peek_btn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

