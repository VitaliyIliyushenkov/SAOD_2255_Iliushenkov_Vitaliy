namespace Vector_app
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_setvalue = new System.Windows.Forms.Button();
            this.btn_resize = new System.Windows.Forms.Button();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.btn_shrinkto = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.tb_setvalue = new System.Windows.Forms.TextBox();
            this.tb_resize = new System.Windows.Forms.TextBox();
            this.tb_reserve = new System.Windows.Forms.TextBox();
            this.btn_random = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tb_capacity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_size = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(201, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 450);
            this.listBox1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(13, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_setvalue
            // 
            this.btn_setvalue.Location = new System.Drawing.Point(13, 43);
            this.btn_setvalue.Name = "btn_setvalue";
            this.btn_setvalue.Size = new System.Drawing.Size(75, 23);
            this.btn_setvalue.TabIndex = 2;
            this.btn_setvalue.Text = "SetValue";
            this.btn_setvalue.UseVisualStyleBackColor = true;
            this.btn_setvalue.Click += new System.EventHandler(this.btn_setvalue_Click);
            // 
            // btn_resize
            // 
            this.btn_resize.Location = new System.Drawing.Point(13, 73);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(75, 23);
            this.btn_resize.TabIndex = 3;
            this.btn_resize.Text = "Resize";
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // btn_reserve
            // 
            this.btn_reserve.Location = new System.Drawing.Point(13, 103);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(75, 23);
            this.btn_reserve.TabIndex = 4;
            this.btn_reserve.Text = "Reserve";
            this.btn_reserve.UseVisualStyleBackColor = true;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // btn_shrinkto
            // 
            this.btn_shrinkto.Location = new System.Drawing.Point(13, 133);
            this.btn_shrinkto.Name = "btn_shrinkto";
            this.btn_shrinkto.Size = new System.Drawing.Size(75, 23);
            this.btn_shrinkto.TabIndex = 5;
            this.btn_shrinkto.Text = "ShrinkToFit";
            this.btn_shrinkto.UseVisualStyleBackColor = true;
            this.btn_shrinkto.Click += new System.EventHandler(this.btn_shrinkto_Click);
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(95, 13);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(100, 22);
            this.tb_add.TabIndex = 6;
            // 
            // tb_setvalue
            // 
            this.tb_setvalue.Location = new System.Drawing.Point(95, 44);
            this.tb_setvalue.Name = "tb_setvalue";
            this.tb_setvalue.Size = new System.Drawing.Size(100, 22);
            this.tb_setvalue.TabIndex = 7;
            // 
            // tb_resize
            // 
            this.tb_resize.Location = new System.Drawing.Point(95, 74);
            this.tb_resize.Name = "tb_resize";
            this.tb_resize.Size = new System.Drawing.Size(100, 22);
            this.tb_resize.TabIndex = 8;
            // 
            // tb_reserve
            // 
            this.tb_reserve.Location = new System.Drawing.Point(95, 102);
            this.tb_reserve.Name = "tb_reserve";
            this.tb_reserve.Size = new System.Drawing.Size(100, 22);
            this.tb_reserve.TabIndex = 9;
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(13, 388);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(75, 23);
            this.btn_random.TabIndex = 10;
            this.btn_random.Text = "Random";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 416);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Minimum = 1;
            // 
            // tb_capacity
            // 
            this.tb_capacity.Location = new System.Drawing.Point(12, 228);
            this.tb_capacity.Name = "tb_capacity";
            this.tb_capacity.Size = new System.Drawing.Size(100, 22);
            this.tb_capacity.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Size";
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(12, 288);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(100, 22);
            this.tb_size.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_capacity);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.tb_reserve);
            this.Controls.Add(this.tb_resize);
            this.Controls.Add(this.tb_setvalue);
            this.Controls.Add(this.tb_add);
            this.Controls.Add(this.btn_shrinkto);
            this.Controls.Add(this.btn_reserve);
            this.Controls.Add(this.btn_resize);
            this.Controls.Add(this.btn_setvalue);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Vector";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_setvalue;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Button btn_shrinkto;
        private System.Windows.Forms.TextBox tb_add;
        private System.Windows.Forms.TextBox tb_setvalue;
        private System.Windows.Forms.TextBox tb_resize;
        private System.Windows.Forms.TextBox tb_reserve;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tb_capacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_size;
    }
}

