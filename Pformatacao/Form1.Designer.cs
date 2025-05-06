namespace Pformatacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFormatValores = new System.Windows.Forms.Button();
            this.btnOperacoesDatas = new System.Windows.Forms.Button();
            this.btnStringValores = new System.Windows.Forms.Button();
            this.btnFormatDatas = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnStringDatas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFormatValores);
            this.groupBox1.Controls.Add(this.btnOperacoesDatas);
            this.groupBox1.Controls.Add(this.btnStringValores);
            this.groupBox1.Controls.Add(this.btnFormatDatas);
            this.groupBox1.Controls.Add(this.btnDateTime);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnStringDatas);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pformatacao";
            // 
            // btnFormatValores
            // 
            this.btnFormatValores.BackColor = System.Drawing.Color.Black;
            this.btnFormatValores.Location = new System.Drawing.Point(320, 241);
            this.btnFormatValores.Name = "btnFormatValores";
            this.btnFormatValores.Size = new System.Drawing.Size(151, 33);
            this.btnFormatValores.TabIndex = 12;
            this.btnFormatValores.Text = "Format - Valores";
            this.btnFormatValores.UseVisualStyleBackColor = false;
            this.btnFormatValores.Click += new System.EventHandler(this.btnFormatValores_Click);
            // 
            // btnOperacoesDatas
            // 
            this.btnOperacoesDatas.BackColor = System.Drawing.Color.Black;
            this.btnOperacoesDatas.Location = new System.Drawing.Point(163, 241);
            this.btnOperacoesDatas.Name = "btnOperacoesDatas";
            this.btnOperacoesDatas.Size = new System.Drawing.Size(151, 33);
            this.btnOperacoesDatas.TabIndex = 11;
            this.btnOperacoesDatas.Text = "Operações - Datas";
            this.btnOperacoesDatas.UseVisualStyleBackColor = false;
            this.btnOperacoesDatas.Click += new System.EventHandler(this.btnOperacoesDatas_Click);
            // 
            // btnStringValores
            // 
            this.btnStringValores.BackColor = System.Drawing.Color.Black;
            this.btnStringValores.Location = new System.Drawing.Point(6, 241);
            this.btnStringValores.Name = "btnStringValores";
            this.btnStringValores.Size = new System.Drawing.Size(151, 33);
            this.btnStringValores.TabIndex = 10;
            this.btnStringValores.Text = "ToString - Valores";
            this.btnStringValores.UseVisualStyleBackColor = false;
            this.btnStringValores.Click += new System.EventHandler(this.btnStringValores_Click);
            // 
            // btnFormatDatas
            // 
            this.btnFormatDatas.BackColor = System.Drawing.Color.Black;
            this.btnFormatDatas.Location = new System.Drawing.Point(320, 202);
            this.btnFormatDatas.Name = "btnFormatDatas";
            this.btnFormatDatas.Size = new System.Drawing.Size(151, 33);
            this.btnFormatDatas.TabIndex = 9;
            this.btnFormatDatas.Text = "Format - Datas";
            this.btnFormatDatas.UseVisualStyleBackColor = false;
            this.btnFormatDatas.Click += new System.EventHandler(this.btnFormatDatas_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.BackColor = System.Drawing.Color.Black;
            this.btnDateTime.Location = new System.Drawing.Point(163, 202);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(151, 33);
            this.btnDateTime.TabIndex = 8;
            this.btnDateTime.Text = "Métodos DateTime";
            this.btnDateTime.UseVisualStyleBackColor = false;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 28);
            this.monthCalendar1.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnStringDatas
            // 
            this.btnStringDatas.BackColor = System.Drawing.Color.Black;
            this.btnStringDatas.Location = new System.Drawing.Point(6, 202);
            this.btnStringDatas.Name = "btnStringDatas";
            this.btnStringDatas.Size = new System.Drawing.Size(151, 33);
            this.btnStringDatas.TabIndex = 0;
            this.btnStringDatas.Text = "ToString - Datas";
            this.btnStringDatas.UseVisualStyleBackColor = false;
            this.btnStringDatas.Click += new System.EventHandler(this.btnStringDatas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(501, 310);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStringDatas;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnFormatValores;
        private System.Windows.Forms.Button btnOperacoesDatas;
        private System.Windows.Forms.Button btnStringValores;
        private System.Windows.Forms.Button btnFormatDatas;
        private System.Windows.Forms.Button btnDateTime;
    }
}

