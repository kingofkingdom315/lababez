namespace lababez
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pbox = new System.Windows.Forms.TextBox();
            this.Vbox = new System.Windows.Forms.TextBox();
            this.Tbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Abox = new System.Windows.Forms.TextBox();
            this.Lbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "T";
            // 
            // Pbox
            // 
            this.Pbox.Location = new System.Drawing.Point(12, 33);
            this.Pbox.Name = "Pbox";
            this.Pbox.Size = new System.Drawing.Size(77, 22);
            this.Pbox.TabIndex = 3;
            // 
            // Vbox
            // 
            this.Vbox.Location = new System.Drawing.Point(95, 33);
            this.Vbox.Name = "Vbox";
            this.Vbox.Size = new System.Drawing.Size(77, 22);
            this.Vbox.TabIndex = 4;
            // 
            // Tbox
            // 
            this.Tbox.Location = new System.Drawing.Point(178, 33);
            this.Tbox.Name = "Tbox";
            this.Tbox.Size = new System.Drawing.Size(77, 22);
            this.Tbox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Рассчитать ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "L";
            // 
            // Abox
            // 
            this.Abox.Location = new System.Drawing.Point(12, 132);
            this.Abox.Name = "Abox";
            this.Abox.ReadOnly = true;
            this.Abox.Size = new System.Drawing.Size(50, 22);
            this.Abox.TabIndex = 9;
            // 
            // Lbox
            // 
            this.Lbox.Location = new System.Drawing.Point(205, 132);
            this.Lbox.Name = "Lbox";
            this.Lbox.ReadOnly = true;
            this.Lbox.Size = new System.Drawing.Size(50, 22);
            this.Lbox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 171);
            this.Controls.Add(this.Lbox);
            this.Controls.Add(this.Abox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tbox);
            this.Controls.Add(this.Vbox);
            this.Controls.Add(this.Pbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pbox;
        private System.Windows.Forms.TextBox Vbox;
        private System.Windows.Forms.TextBox Tbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Abox;
        private System.Windows.Forms.TextBox Lbox;
    }
}

