namespace Lab03
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.Summ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Simple = new System.Windows.Forms.TextBox();
            this.Statistic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Массив отсортированный по убыванию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Элементы массива, у которых сумма \r\nпоследних 2 цифр делится на 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Сумма:";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(88, 97);
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Size = new System.Drawing.Size(47, 20);
            this.Number.TabIndex = 5;
            // 
            // Summ
            // 
            this.Summ.Location = new System.Drawing.Point(202, 97);
            this.Summ.Name = "Summ";
            this.Summ.ReadOnly = true;
            this.Summ.Size = new System.Drawing.Size(70, 20);
            this.Summ.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество простых чисел:";
            // 
            // Simple
            // 
            this.Simple.Location = new System.Drawing.Point(168, 127);
            this.Simple.Name = "Simple";
            this.Simple.ReadOnly = true;
            this.Simple.Size = new System.Drawing.Size(78, 20);
            this.Simple.TabIndex = 8;
            // 
            // Statistic
            // 
            this.Statistic.AutoSize = true;
            this.Statistic.Location = new System.Drawing.Point(16, 160);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(0, 13);
            this.Statistic.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.Statistic);
            this.Controls.Add(this.Simple);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Результаты обработки";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Summ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Simple;
        private System.Windows.Forms.Label Statistic;
    }
}