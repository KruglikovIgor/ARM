namespace ARM
{
    partial class frmDetailed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailed));
            this.dataGridViewDetailed1 = new System.Windows.Forms.DataGridView();
            this.idСИ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Шифр = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idНомер_в_Госреестре = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Заводской_номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Наименование_типа_СИ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тип_СИ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Диапазон_измерений = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Погрешность_измерений = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_очередного_МК = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDetailed2 = new System.Windows.Forms.DataGridView();
            this.Год_выпуска = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_поступления = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_проведения_МК = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Почта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExitDetailed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailed2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDetailed1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetailed1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetailed1.ColumnHeadersHeight = 40;
            this.dataGridViewDetailed1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDetailed1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idСИ,
            this.Шифр,
            this.idНомер_в_Госреестре,
            this.Заводской_номер,
            this.Наименование_типа_СИ,
            this.Тип_СИ,
            this.Диапазон_измерений,
            this.Погрешность_измерений,
            this.Дата_очередного_МК});
            this.dataGridViewDetailed1.Location = new System.Drawing.Point(0, 10);
            this.dataGridViewDetailed1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewDetailed1.Name = "dataGridViewDetailed1";
            this.dataGridViewDetailed1.RowTemplate.Height = 80;
            this.dataGridViewDetailed1.Size = new System.Drawing.Size(1900, 150);
            this.dataGridViewDetailed1.TabIndex = 0;
            // 
            // idСИ
            // 
            this.idСИ.HeaderText = "idСИ";
            this.idСИ.Name = "idСИ";
            // 
            // Шифр
            // 
            this.Шифр.HeaderText = "Шифр";
            this.Шифр.Name = "Шифр";
            // 
            // idНомер_в_Госреестре
            // 
            this.idНомер_в_Госреестре.HeaderText = "idНомер_в_Госреестре";
            this.idНомер_в_Госреестре.Name = "idНомер_в_Госреестре";
            // 
            // Заводской_номер
            // 
            this.Заводской_номер.HeaderText = "Заводской_номер";
            this.Заводской_номер.Name = "Заводской_номер";
            // 
            // Наименование_типа_СИ
            // 
            this.Наименование_типа_СИ.HeaderText = "Наименование_типа_СИ";
            this.Наименование_типа_СИ.Name = "Наименование_типа_СИ";
            // 
            // Тип_СИ
            // 
            this.Тип_СИ.HeaderText = "Тип_СИ";
            this.Тип_СИ.Name = "Тип_СИ";
            // 
            // Диапазон_измерений
            // 
            this.Диапазон_измерений.HeaderText = "Диапазон_измерений";
            this.Диапазон_измерений.Name = "Диапазон_измерений";
            // 
            // Погрешность_измерений
            // 
            this.Погрешность_измерений.HeaderText = "Погрешность_измерений";
            this.Погрешность_измерений.Name = "Погрешность_измерений";
            // 
            // Дата_очередного_МК
            // 
            this.Дата_очередного_МК.HeaderText = "Дата_очередного_МК";
            this.Дата_очередного_МК.Name = "Дата_очередного_МК";
            // 
            // dataGridViewDetailed2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetailed2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDetailed2.ColumnHeadersHeight = 40;
            this.dataGridViewDetailed2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDetailed2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Год_выпуска,
            this.Дата_поступления,
            this.Дата_проведения_МК,
            this.Название,
            this.Адрес,
            this.ФИО,
            this.Почта});
            this.dataGridViewDetailed2.Location = new System.Drawing.Point(0, 232);
            this.dataGridViewDetailed2.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewDetailed2.Name = "dataGridViewDetailed2";
            this.dataGridViewDetailed2.RowTemplate.Height = 80;
            this.dataGridViewDetailed2.Size = new System.Drawing.Size(1900, 150);
            this.dataGridViewDetailed2.TabIndex = 1;
            // 
            // Год_выпуска
            // 
            this.Год_выпуска.HeaderText = "Год_выпуска";
            this.Год_выпуска.Name = "Год_выпуска";
            // 
            // Дата_поступления
            // 
            this.Дата_поступления.HeaderText = "Дата_поступления";
            this.Дата_поступления.Name = "Дата_поступления";
            // 
            // Дата_проведения_МК
            // 
            this.Дата_проведения_МК.HeaderText = "Дата_проведения_МК";
            this.Дата_проведения_МК.Name = "Дата_проведения_МК";
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.Name = "Название";
            // 
            // Адрес
            // 
            this.Адрес.HeaderText = "Адрес";
            this.Адрес.Name = "Адрес";
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            // 
            // Почта
            // 
            this.Почта.HeaderText = "Почта";
            this.Почта.Name = "Почта";
            // 
            // btnExitDetailed
            // 
            this.btnExitDetailed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitDetailed.BackgroundImage")));
            this.btnExitDetailed.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitDetailed.ForeColor = System.Drawing.Color.Red;
            this.btnExitDetailed.Location = new System.Drawing.Point(857, 450);
            this.btnExitDetailed.Name = "btnExitDetailed";
            this.btnExitDetailed.Size = new System.Drawing.Size(209, 95);
            this.btnExitDetailed.TabIndex = 2;
            this.btnExitDetailed.Text = "Закрыть окно";
            this.btnExitDetailed.UseVisualStyleBackColor = true;
            this.btnExitDetailed.Click += new System.EventHandler(this.btnExitDetailed_Click);
            // 
            // frmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1898, 557);
            this.Controls.Add(this.btnExitDetailed);
            this.Controls.Add(this.dataGridViewDetailed2);
            this.Controls.Add(this.dataGridViewDetailed1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 600);
            this.Name = "frmDetailed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подробные сведения о СИ";
            this.Load += new System.EventHandler(this.frmDetailed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailed2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewDetailed1;
        public System.Windows.Forms.DataGridView dataGridViewDetailed2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСИ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Шифр;
        private System.Windows.Forms.DataGridViewTextBoxColumn idНомер_в_Госреестре;
        private System.Windows.Forms.DataGridViewTextBoxColumn Заводской_номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Наименование_типа_СИ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип_СИ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Диапазон_измерений;
        private System.Windows.Forms.DataGridViewTextBoxColumn Погрешность_измерений;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_очередного_МК;
        private System.Windows.Forms.DataGridViewTextBoxColumn Год_выпуска;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_поступления;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_проведения_МК;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Почта;
        private System.Windows.Forms.Button btnExitDetailed;
    }
}