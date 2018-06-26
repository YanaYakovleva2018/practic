namespace Lab04
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
            this.Least = new System.Windows.Forms.Label();
            this.DgvOrigin = new System.Windows.Forms.DataGridView();
            this.DgvSort = new System.Windows.Forms.DataGridView();
            this.DgvCentre = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCentre)).BeginInit();
            this.SuspendLayout();
            // 
            // Least
            // 
            this.Least.AutoSize = true;
            this.Least.Location = new System.Drawing.Point(30, 22);
            this.Least.Name = "Least";
            this.Least.Size = new System.Drawing.Size(0, 13);
            this.Least.TabIndex = 0;
            // 
            // DgvOrigin
            // 
            this.DgvOrigin.AllowUserToAddRows = false;
            this.DgvOrigin.AllowUserToDeleteRows = false;
            this.DgvOrigin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrigin.Location = new System.Drawing.Point(1, 100);
            this.DgvOrigin.Name = "DgvOrigin";
            this.DgvOrigin.ReadOnly = true;
            this.DgvOrigin.Size = new System.Drawing.Size(240, 150);
            this.DgvOrigin.TabIndex = 1;
            // 
            // DgvSort
            // 
            this.DgvSort.AllowUserToAddRows = false;
            this.DgvSort.AllowUserToDeleteRows = false;
            this.DgvSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSort.Location = new System.Drawing.Point(271, 100);
            this.DgvSort.Name = "DgvSort";
            this.DgvSort.ReadOnly = true;
            this.DgvSort.Size = new System.Drawing.Size(240, 150);
            this.DgvSort.TabIndex = 2;
            // 
            // DgvCentre
            // 
            this.DgvCentre.AllowUserToAddRows = false;
            this.DgvCentre.AllowUserToDeleteRows = false;
            this.DgvCentre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCentre.Location = new System.Drawing.Point(531, 100);
            this.DgvCentre.Name = "DgvCentre";
            this.DgvCentre.ReadOnly = true;
            this.DgvCentre.Size = new System.Drawing.Size(240, 150);
            this.DgvCentre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Исходная матрица";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отсортированные строки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отцентрированная";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(796, 283);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvCentre);
            this.Controls.Add(this.DgvSort);
            this.Controls.Add(this.DgvOrigin);
            this.Controls.Add(this.Least);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Результаты обработки";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCentre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Least;
        private System.Windows.Forms.DataGridView DgvOrigin;
        private System.Windows.Forms.DataGridView DgvSort;
        private System.Windows.Forms.DataGridView DgvCentre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}