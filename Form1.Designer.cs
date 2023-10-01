namespace WindowsFormsApp4
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.random_b = new System.Windows.Forms.Button();
            this.result_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ColumnHeadersVisible = false;
            this.DGV.Location = new System.Drawing.Point(23, 61);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.Size = new System.Drawing.Size(735, 235);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // random_b
            // 
            this.random_b.Location = new System.Drawing.Point(23, 336);
            this.random_b.Name = "random_b";
            this.random_b.Size = new System.Drawing.Size(110, 23);
            this.random_b.TabIndex = 1;
            this.random_b.Text = "сгенерировать";
            this.random_b.UseVisualStyleBackColor = true;
            this.random_b.Click += new System.EventHandler(this.random_b_Click);
            // 
            // result_b
            // 
            this.result_b.Location = new System.Drawing.Point(184, 336);
            this.result_b.Name = "result_b";
            this.result_b.Size = new System.Drawing.Size(110, 23);
            this.result_b.TabIndex = 2;
            this.result_b.Text = "результат";
            this.result_b.UseVisualStyleBackColor = true;
            this.result_b.Click += new System.EventHandler(this.result_b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result_b);
            this.Controls.Add(this.random_b);
            this.Controls.Add(this.DGV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button random_b;
        private System.Windows.Forms.Button result_b;
    }
}

