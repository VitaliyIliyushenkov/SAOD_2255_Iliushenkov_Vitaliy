namespace treee
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_contain = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_insert_key = new System.Windows.Forms.TextBox();
            this.tb_contains = new System.Windows.Forms.TextBox();
            this.tb_delete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_conclusion = new System.Windows.Forms.TextBox();
            this.btn_CLR = new System.Windows.Forms.Button();
            this.btn_LCR = new System.Windows.Forms.Button();
            this.btn_RCL = new System.Windows.Forms.Button();
            this.btn_across = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_insert_value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ValueByKey = new System.Windows.Forms.Button();
            this.tb_ValueByKey = new System.Windows.Forms.TextBox();
            this.tb_KeyByValue = new System.Windows.Forms.TextBox();
            this.btn_KeyByValue = new System.Windows.Forms.Button();
            this.tb_ContainsKey = new System.Windows.Forms.TextBox();
            this.btn_ContainsKey = new System.Windows.Forms.Button();
            this.tb_ContainsValue = new System.Windows.Forms.TextBox();
            this.btn_ContainsValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(13, 21);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Добавить";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_contain
            // 
            this.btn_contain.Location = new System.Drawing.Point(13, 114);
            this.btn_contain.Name = "btn_contain";
            this.btn_contain.Size = new System.Drawing.Size(75, 23);
            this.btn_contain.TabIndex = 1;
            this.btn_contain.Text = "Поиск";
            this.btn_contain.UseVisualStyleBackColor = true;
            this.btn_contain.Click += new System.EventHandler(this.btn_contain_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(13, 144);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_insert_key
            // 
            this.tb_insert_key.Location = new System.Drawing.Point(95, 21);
            this.tb_insert_key.Name = "tb_insert_key";
            this.tb_insert_key.Size = new System.Drawing.Size(100, 22);
            this.tb_insert_key.TabIndex = 3;
            // 
            // tb_contains
            // 
            this.tb_contains.Location = new System.Drawing.Point(95, 114);
            this.tb_contains.Name = "tb_contains";
            this.tb_contains.Size = new System.Drawing.Size(100, 22);
            this.tb_contains.TabIndex = 4;
            // 
            // tb_delete
            // 
            this.tb_delete.Location = new System.Drawing.Point(95, 144);
            this.tb_delete.Name = "tb_delete";
            this.tb_delete.Size = new System.Drawing.Size(100, 22);
            this.tb_delete.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вывод";
            // 
            // tb_conclusion
            // 
            this.tb_conclusion.Location = new System.Drawing.Point(64, 236);
            this.tb_conclusion.Name = "tb_conclusion";
            this.tb_conclusion.Size = new System.Drawing.Size(674, 22);
            this.tb_conclusion.TabIndex = 7;
            // 
            // btn_CLR
            // 
            this.btn_CLR.Location = new System.Drawing.Point(64, 207);
            this.btn_CLR.Name = "btn_CLR";
            this.btn_CLR.Size = new System.Drawing.Size(132, 23);
            this.btn_CLR.TabIndex = 8;
            this.btn_CLR.Text = "Прямой обход";
            this.btn_CLR.UseVisualStyleBackColor = true;
            this.btn_CLR.Click += new System.EventHandler(this.btn_CLR_Click);
            // 
            // btn_LCR
            // 
            this.btn_LCR.Location = new System.Drawing.Point(202, 207);
            this.btn_LCR.Name = "btn_LCR";
            this.btn_LCR.Size = new System.Drawing.Size(137, 23);
            this.btn_LCR.TabIndex = 9;
            this.btn_LCR.Text = "Обратный обход";
            this.btn_LCR.UseVisualStyleBackColor = true;
            this.btn_LCR.Click += new System.EventHandler(this.btn_LCR_Click);
            // 
            // btn_RCL
            // 
            this.btn_RCL.Location = new System.Drawing.Point(345, 207);
            this.btn_RCL.Name = "btn_RCL";
            this.btn_RCL.Size = new System.Drawing.Size(127, 23);
            this.btn_RCL.TabIndex = 10;
            this.btn_RCL.Text = "Концевой обход";
            this.btn_RCL.UseVisualStyleBackColor = true;
            this.btn_RCL.Click += new System.EventHandler(this.btn_RCL_Click);
            // 
            // btn_across
            // 
            this.btn_across.Location = new System.Drawing.Point(64, 178);
            this.btn_across.Name = "btn_across";
            this.btn_across.Size = new System.Drawing.Size(132, 23);
            this.btn_across.TabIndex = 11;
            this.btn_across.Text = "Обход в ширину";
            this.btn_across.UseVisualStyleBackColor = true;
            this.btn_across.Click += new System.EventHandler(this.btn_across_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "value";
            // 
            // tb_insert_value
            // 
            this.tb_insert_value.Location = new System.Drawing.Point(202, 21);
            this.tb_insert_value.Name = "tb_insert_value";
            this.tb_insert_value.Size = new System.Drawing.Size(100, 22);
            this.tb_insert_value.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Методы словаря:";
            // 
            // btn_ValueByKey
            // 
            this.btn_ValueByKey.Location = new System.Drawing.Point(391, 19);
            this.btn_ValueByKey.Name = "btn_ValueByKey";
            this.btn_ValueByKey.Size = new System.Drawing.Size(207, 23);
            this.btn_ValueByKey.TabIndex = 17;
            this.btn_ValueByKey.Text = "Вернуть значение по ключу";
            this.btn_ValueByKey.UseVisualStyleBackColor = true;
            this.btn_ValueByKey.Click += new System.EventHandler(this.btn_ValueByKey_Click);
            // 
            // tb_ValueByKey
            // 
            this.tb_ValueByKey.Location = new System.Drawing.Point(604, 19);
            this.tb_ValueByKey.Name = "tb_ValueByKey";
            this.tb_ValueByKey.Size = new System.Drawing.Size(133, 22);
            this.tb_ValueByKey.TabIndex = 18;
            // 
            // tb_KeyByValue
            // 
            this.tb_KeyByValue.Location = new System.Drawing.Point(604, 48);
            this.tb_KeyByValue.Name = "tb_KeyByValue";
            this.tb_KeyByValue.Size = new System.Drawing.Size(134, 22);
            this.tb_KeyByValue.TabIndex = 20;
            // 
            // btn_KeyByValue
            // 
            this.btn_KeyByValue.Location = new System.Drawing.Point(391, 48);
            this.btn_KeyByValue.Name = "btn_KeyByValue";
            this.btn_KeyByValue.Size = new System.Drawing.Size(207, 23);
            this.btn_KeyByValue.TabIndex = 19;
            this.btn_KeyByValue.Text = "Вернуть ключ по значению";
            this.btn_KeyByValue.UseVisualStyleBackColor = true;
            this.btn_KeyByValue.Click += new System.EventHandler(this.btn_KeyByValue_Click);
            // 
            // tb_ContainsKey
            // 
            this.tb_ContainsKey.Location = new System.Drawing.Point(604, 77);
            this.tb_ContainsKey.Name = "tb_ContainsKey";
            this.tb_ContainsKey.Size = new System.Drawing.Size(134, 22);
            this.tb_ContainsKey.TabIndex = 22;
            // 
            // btn_ContainsKey
            // 
            this.btn_ContainsKey.Location = new System.Drawing.Point(391, 76);
            this.btn_ContainsKey.Name = "btn_ContainsKey";
            this.btn_ContainsKey.Size = new System.Drawing.Size(207, 23);
            this.btn_ContainsKey.TabIndex = 21;
            this.btn_ContainsKey.Text = "Найти эл-т по ключу";
            this.btn_ContainsKey.UseVisualStyleBackColor = true;
            this.btn_ContainsKey.Click += new System.EventHandler(this.btn_ContainsKey_Click);
            // 
            // tb_ContainsValue
            // 
            this.tb_ContainsValue.Location = new System.Drawing.Point(604, 105);
            this.tb_ContainsValue.Name = "tb_ContainsValue";
            this.tb_ContainsValue.Size = new System.Drawing.Size(134, 22);
            this.tb_ContainsValue.TabIndex = 28;
            // 
            // btn_ContainsValue
            // 
            this.btn_ContainsValue.Location = new System.Drawing.Point(391, 104);
            this.btn_ContainsValue.Name = "btn_ContainsValue";
            this.btn_ContainsValue.Size = new System.Drawing.Size(207, 23);
            this.btn_ContainsValue.TabIndex = 27;
            this.btn_ContainsValue.Text = "Найти эл-т по значению";
            this.btn_ContainsValue.UseVisualStyleBackColor = true;
            this.btn_ContainsValue.Click += new System.EventHandler(this.btn_ContainsValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 264);
            this.Controls.Add(this.tb_ContainsValue);
            this.Controls.Add(this.btn_ContainsValue);
            this.Controls.Add(this.tb_ContainsKey);
            this.Controls.Add(this.btn_ContainsKey);
            this.Controls.Add(this.tb_KeyByValue);
            this.Controls.Add(this.btn_KeyByValue);
            this.Controls.Add(this.tb_ValueByKey);
            this.Controls.Add(this.btn_ValueByKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_insert_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_across);
            this.Controls.Add(this.btn_RCL);
            this.Controls.Add(this.btn_LCR);
            this.Controls.Add(this.btn_CLR);
            this.Controls.Add(this.tb_conclusion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_delete);
            this.Controls.Add(this.tb_contains);
            this.Controls.Add(this.tb_insert_key);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_contain);
            this.Controls.Add(this.btn_insert);
            this.Name = "Form1";
            this.Text = "Дерево";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_contain;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_insert_key;
        private System.Windows.Forms.TextBox tb_contains;
        private System.Windows.Forms.TextBox tb_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_conclusion;
        private System.Windows.Forms.Button btn_CLR;
        private System.Windows.Forms.Button btn_LCR;
        private System.Windows.Forms.Button btn_RCL;
        private System.Windows.Forms.Button btn_across;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_insert_value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ValueByKey;
        private System.Windows.Forms.TextBox tb_ValueByKey;
        private System.Windows.Forms.TextBox tb_KeyByValue;
        private System.Windows.Forms.Button btn_KeyByValue;
        private System.Windows.Forms.TextBox tb_ContainsKey;
        private System.Windows.Forms.Button btn_ContainsKey;
        private System.Windows.Forms.TextBox tb_ContainsValue;
        private System.Windows.Forms.Button btn_ContainsValue;
    }
}

