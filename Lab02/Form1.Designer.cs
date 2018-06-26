namespace Lab02
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Error = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextC = new System.Windows.Forms.TextBox();
            this.TextB = new System.Windows.Forms.TextBox();
            this.TextA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InClass = new System.Windows.Forms.Button();
            this.InMethod = new System.Windows.Forms.Button();
            this.InHandler = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextX2 = new System.Windows.Forms.TextBox();
            this.TextX1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Error);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextC);
            this.groupBox1.Controls.Add(this.TextB);
            this.groupBox1.Controls.Add(this.TextA);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коэффициенты Квадратного Уравнения";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.IndianRed;
            this.Error.Location = new System.Drawing.Point(178, 21);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 13);
            this.Error.TabIndex = 7;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(49, 77);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Очистить\r\n ";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "c=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "b=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a=";
            // 
            // TextC
            // 
            this.TextC.Location = new System.Drawing.Point(311, 82);
            this.TextC.Name = "TextC";
            this.TextC.Size = new System.Drawing.Size(100, 20);
            this.TextC.TabIndex = 2;
            this.TextC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextC_KeyDown);
            this.TextC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextC_KeyPress);
            // 
            // TextB
            // 
            this.TextB.Location = new System.Drawing.Point(181, 59);
            this.TextB.Name = "TextB";
            this.TextB.Size = new System.Drawing.Size(100, 20);
            this.TextB.TabIndex = 1;
            this.TextB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextB_KeyDown);
            this.TextB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextB_KeyPress);
            // 
            // TextA
            // 
            this.TextA.Location = new System.Drawing.Point(49, 37);
            this.TextA.Name = "TextA";
            this.TextA.Size = new System.Drawing.Size(100, 20);
            this.TextA.TabIndex = 0;
            this.TextA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextA_KeyDown);
            this.TextA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextA_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.InClass);
            this.groupBox2.Controls.Add(this.InMethod);
            this.groupBox2.Controls.Add(this.InHandler);
            this.groupBox2.Location = new System.Drawing.Point(27, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Способы Решения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "-В методе  класса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "- В методе формы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "- В обработчике";
            // 
            // InClass
            // 
            this.InClass.Location = new System.Drawing.Point(27, 110);
            this.InClass.Name = "InClass";
            this.InClass.Size = new System.Drawing.Size(75, 23);
            this.InClass.TabIndex = 2;
            this.InClass.Text = "Способ 3";
            this.InClass.UseVisualStyleBackColor = true;
            this.InClass.Click += new System.EventHandler(this.InClass_Click);
            // 
            // InMethod
            // 
            this.InMethod.Location = new System.Drawing.Point(27, 71);
            this.InMethod.Name = "InMethod";
            this.InMethod.Size = new System.Drawing.Size(75, 23);
            this.InMethod.TabIndex = 1;
            this.InMethod.Text = "Способ 2";
            this.InMethod.UseVisualStyleBackColor = true;
            this.InMethod.Click += new System.EventHandler(this.InMethod_Click);
            // 
            // InHandler
            // 
            this.InHandler.Location = new System.Drawing.Point(27, 28);
            this.InHandler.Name = "InHandler";
            this.InHandler.Size = new System.Drawing.Size(75, 23);
            this.InHandler.TabIndex = 0;
            this.InHandler.Text = "Способ 1";
            this.InHandler.UseVisualStyleBackColor = true;
            this.InHandler.Click += new System.EventHandler(this.InHandler_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextX2);
            this.groupBox3.Controls.Add(this.TextX1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(295, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 97);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // TextX2
            // 
            this.TextX2.Location = new System.Drawing.Point(53, 61);
            this.TextX2.Name = "TextX2";
            this.TextX2.ReadOnly = true;
            this.TextX2.Size = new System.Drawing.Size(133, 20);
            this.TextX2.TabIndex = 3;
            // 
            // TextX1
            // 
            this.TextX1.Location = new System.Drawing.Point(54, 21);
            this.TextX1.Name = "TextX1";
            this.TextX1.ReadOnly = true;
            this.TextX1.Size = new System.Drawing.Size(132, 20);
            this.TextX1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "X2 =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "X1 =";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Red;
            this.Close.Location = new System.Drawing.Point(295, 284);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(161, 33);
            this.Close.TabIndex = 3;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(510, 344);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Решение квадратного уравнения";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextC;
        private System.Windows.Forms.TextBox TextB;
        private System.Windows.Forms.TextBox TextA;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InClass;
        private System.Windows.Forms.Button InMethod;
        private System.Windows.Forms.Button InHandler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TextX2;
        private System.Windows.Forms.TextBox TextX1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Close;
    }
}

