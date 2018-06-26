namespace Lab03
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
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.OpenButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ArrMin = new System.Windows.Forms.NumericUpDown();
            this.ArrMax = new System.Windows.Forms.NumericUpDown();
            this.ArrSize = new System.Windows.Forms.NumericUpDown();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SaveRes = new System.Windows.Forms.Button();
            this.OpenRes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArrMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Title = "Открыть файл";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(119, 19);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Save
            // 
            this.Save.Title = "Сохранение";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.OpenButton);
            this.groupBox1.Location = new System.Drawing.Point(33, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия с F1(только массив)";
            // 
            // SaveButton
            // 
            this.SaveButton.CausesValidation = false;
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(7, 18);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ArrMin);
            this.groupBox2.Controls.Add(this.ArrMax);
            this.groupBox2.Controls.Add(this.ArrSize);
            this.groupBox2.Location = new System.Drawing.Point(33, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры массива";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Минимальное \r\nзначение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Максимальное \r\nзначение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер массива";
            // 
            // ArrMin
            // 
            this.ArrMin.Location = new System.Drawing.Point(17, 81);
            this.ArrMin.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.ArrMin.Name = "ArrMin";
            this.ArrMin.ReadOnly = true;
            this.ArrMin.Size = new System.Drawing.Size(74, 20);
            this.ArrMin.TabIndex = 2;
            this.ArrMin.ValueChanged += new System.EventHandler(this.ArrMin_ValueChanged);
            // 
            // ArrMax
            // 
            this.ArrMax.Location = new System.Drawing.Point(17, 55);
            this.ArrMax.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ArrMax.Name = "ArrMax";
            this.ArrMax.ReadOnly = true;
            this.ArrMax.Size = new System.Drawing.Size(74, 20);
            this.ArrMax.TabIndex = 1;
            this.ArrMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ArrMax.ValueChanged += new System.EventHandler(this.ArrMax_ValueChanged);
            // 
            // ArrSize
            // 
            this.ArrSize.Location = new System.Drawing.Point(17, 25);
            this.ArrSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ArrSize.Name = "ArrSize";
            this.ArrSize.ReadOnly = true;
            this.ArrSize.Size = new System.Drawing.Size(74, 20);
            this.ArrSize.TabIndex = 0;
            this.ArrSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(353, 51);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.Size = new System.Drawing.Size(231, 170);
            this.Dgv.TabIndex = 3;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(261, 25);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(313, 20);
            this.TextBox.TabIndex = 4;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(261, 65);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 5;
            this.Generate.Text = "Генерация";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Enabled = false;
            this.ResultButton.Location = new System.Drawing.Point(264, 238);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(75, 23);
            this.ResultButton.TabIndex = 6;
            this.ResultButton.Text = "Результаты";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OpenRes);
            this.groupBox3.Controls.Add(this.SaveRes);
            this.groupBox3.Location = new System.Drawing.Point(33, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 61);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия с F2(массив и результаты)";
            // 
            // SaveRes
            // 
            this.SaveRes.Enabled = false;
            this.SaveRes.Location = new System.Drawing.Point(7, 30);
            this.SaveRes.Name = "SaveRes";
            this.SaveRes.Size = new System.Drawing.Size(75, 23);
            this.SaveRes.TabIndex = 0;
            this.SaveRes.Text = "Сохранить";
            this.SaveRes.UseVisualStyleBackColor = true;
            this.SaveRes.Click += new System.EventHandler(this.SaveRes_Click);
            // 
            // OpenRes
            // 
            this.OpenRes.Location = new System.Drawing.Point(119, 29);
            this.OpenRes.Name = "OpenRes";
            this.OpenRes.Size = new System.Drawing.Size(75, 23);
            this.OpenRes.TabIndex = 1;
            this.OpenRes.Text = "Открыть";
            this.OpenRes.UseVisualStyleBackColor = true;
            this.OpenRes.Click += new System.EventHandler(this.OpenRes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Массив";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = " - Получить результаты обработки массива";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(596, 282);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Работа с массивом и файлами";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArrMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog Open;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.SaveFileDialog Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ArrMin;
        private System.Windows.Forms.NumericUpDown ArrMax;
        private System.Windows.Forms.NumericUpDown ArrSize;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button OpenRes;
        private System.Windows.Forms.Button SaveRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

