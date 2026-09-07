namespace ARM
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеЗапиямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьБДТиповСИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьБДОтветственныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьБДМестПоверкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dsDataSet1 = new ARM.dsDataSet();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter3 = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=ARM;Integrated Security=True;Pooling=False;En" +
    "crypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(719, 63);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeight = 40;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Location = new System.Drawing.Point(0, 324);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 50;
            this.dataGridView2.Size = new System.Drawing.Size(719, 63);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.управлениеЗапиямиToolStripMenuItem,
            this.редакторБДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // управлениеЗапиямиToolStripMenuItem
            // 
            this.управлениеЗапиямиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.добавитьToolStripMenuItem});
            this.управлениеЗапиямиToolStripMenuItem.Name = "управлениеЗапиямиToolStripMenuItem";
            this.управлениеЗапиямиToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.управлениеЗапиямиToolStripMenuItem.Text = "Управление записями";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьToolStripMenuItem.Text = "Редактировать";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редакторБДToolStripMenuItem
            // 
            this.редакторБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьБДТиповСИToolStripMenuItem,
            this.редактироватьБДОтветственныхToolStripMenuItem,
            this.редактироватьБДМестПоверкиToolStripMenuItem});
            this.редакторБДToolStripMenuItem.Name = "редакторБДToolStripMenuItem";
            this.редакторБДToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.редакторБДToolStripMenuItem.Text = "Редактор БД";
            // 
            // редактироватьБДТиповСИToolStripMenuItem
            // 
            this.редактироватьБДТиповСИToolStripMenuItem.Name = "редактироватьБДТиповСИToolStripMenuItem";
            this.редактироватьБДТиповСИToolStripMenuItem.Size = new System.Drawing.Size(345, 22);
            this.редактироватьБДТиповСИToolStripMenuItem.Text = "Редактировать БД типов СИ";
            this.редактироватьБДТиповСИToolStripMenuItem.Click += new System.EventHandler(this.редактироватьБДТиповСИToolStripMenuItem_Click);
            // 
            // редактироватьБДОтветственныхToolStripMenuItem
            // 
            this.редактироватьБДОтветственныхToolStripMenuItem.Name = "редактироватьБДОтветственныхToolStripMenuItem";
            this.редактироватьБДОтветственныхToolStripMenuItem.Size = new System.Drawing.Size(345, 22);
            this.редактироватьБДОтветственныхToolStripMenuItem.Text = "Редактировать БД ответственных за СИ";
            this.редактироватьБДОтветственныхToolStripMenuItem.Click += new System.EventHandler(this.редактироватьБДОтветственныхToolStripMenuItem_Click);
            // 
            // редактироватьБДМестПоверкиToolStripMenuItem
            // 
            this.редактироватьБДМестПоверкиToolStripMenuItem.Name = "редактироватьБДМестПоверкиToolStripMenuItem";
            this.редактироватьБДМестПоверкиToolStripMenuItem.Size = new System.Drawing.Size(345, 22);
            this.редактироватьБДМестПоверкиToolStripMenuItem.Text = "Редактировать БД организаций- поверителей СИ";
            this.редактироватьБДМестПоверкиToolStripMenuItem.Click += new System.EventHandler(this.редактироватьБДМестПоверкиToolStripMenuItem_Click);
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Место_проведения_поверки", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Год_выпуска", "Год_выпуска"),
                        new System.Data.Common.DataColumnMapping("Дата_поступления", "Дата_поступления"),
                        new System.Data.Common.DataColumnMapping("Дата_проведения_МК", "Дата_проведения_МК"),
                        new System.Data.Common.DataColumnMapping("Название", "Название"),
                        new System.Data.Common.DataColumnMapping("Адрес", "Адрес"),
                        new System.Data.Common.DataColumnMapping("ФИО", "ФИО"),
                        new System.Data.Common.DataColumnMapping("Почта", "Почта")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Перечень_СИ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idСИ", "idСИ"),
                        new System.Data.Common.DataColumnMapping("Шифр", "Шифр"),
                        new System.Data.Common.DataColumnMapping("idНомер_в_Госреестре", "idНомер_в_Госреестре"),
                        new System.Data.Common.DataColumnMapping("Заводской_номер", "Заводской_номер"),
                        new System.Data.Common.DataColumnMapping("Наименование_типа_СИ", "Наименование_типа_СИ"),
                        new System.Data.Common.DataColumnMapping("Тип_СИ", "Тип_СИ"),
                        new System.Data.Common.DataColumnMapping("Диапазон_измерений", "Диапазон_измерений"),
                        new System.Data.Common.DataColumnMapping("Погрешность_измерений", "Погрешность_измерений"),
                        new System.Data.Common.DataColumnMapping("Дата_очередного_МК", "Дата_очередного_МК")})});
            // 
            // dsDataSet1
            // 
            this.dsDataSet1.DataSetName = "dsDataSet";
            this.dsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "select * from dbo.Перечень_СИ";
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idНомер_в_Госреестре", System.Data.SqlDbType.NVarChar, 0, "idНомер_в_Госреестре"),
            new System.Data.SqlClient.SqlParameter("@Заводской_номер", System.Data.SqlDbType.NVarChar, 0, "Заводской_номер"),
            new System.Data.SqlClient.SqlParameter("@Инвентарный_номер", System.Data.SqlDbType.Int, 0, "Инвентарный_номер"),
            new System.Data.SqlClient.SqlParameter("@Год_выпуска", System.Data.SqlDbType.Int, 0, "Год_выпуска"),
            new System.Data.SqlClient.SqlParameter("@Дата_поступления", System.Data.SqlDbType.DateTime, 0, "Дата_поступления"),
            new System.Data.SqlClient.SqlParameter("@Дата_очередного_МК", System.Data.SqlDbType.DateTime, 0, "Дата_очередного_МК"),
            new System.Data.SqlClient.SqlParameter("@Дата_проведения_МК", System.Data.SqlDbType.DateTime, 0, "Дата_проведения_МК"),
            new System.Data.SqlClient.SqlParameter("@idСтатус", System.Data.SqlDbType.TinyInt, 0, "idСтатус"),
            new System.Data.SqlClient.SqlParameter("@idМесто_проведения_поверки", System.Data.SqlDbType.TinyInt, 0, "idМесто_проведения_поверки"),
            new System.Data.SqlClient.SqlParameter("@idОтветственный", System.Data.SqlDbType.TinyInt, 0, "idОтветственный")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idНомер_в_Госреестре", System.Data.SqlDbType.NVarChar, 0, "idНомер_в_Госреестре"),
            new System.Data.SqlClient.SqlParameter("@Заводской_номер", System.Data.SqlDbType.NVarChar, 0, "Заводской_номер"),
            new System.Data.SqlClient.SqlParameter("@Инвентарный_номер", System.Data.SqlDbType.Int, 0, "Инвентарный_номер"),
            new System.Data.SqlClient.SqlParameter("@Год_выпуска", System.Data.SqlDbType.Int, 0, "Год_выпуска"),
            new System.Data.SqlClient.SqlParameter("@Дата_поступления", System.Data.SqlDbType.DateTime, 0, "Дата_поступления"),
            new System.Data.SqlClient.SqlParameter("@Дата_очередного_МК", System.Data.SqlDbType.DateTime, 0, "Дата_очередного_МК"),
            new System.Data.SqlClient.SqlParameter("@Дата_проведения_МК", System.Data.SqlDbType.DateTime, 0, "Дата_проведения_МК"),
            new System.Data.SqlClient.SqlParameter("@idСтатус", System.Data.SqlDbType.TinyInt, 0, "idСтатус"),
            new System.Data.SqlClient.SqlParameter("@idМесто_проведения_поверки", System.Data.SqlDbType.TinyInt, 0, "idМесто_проведения_поверки"),
            new System.Data.SqlClient.SqlParameter("@idОтветственный", System.Data.SqlDbType.TinyInt, 0, "idОтветственный"),
            new System.Data.SqlClient.SqlParameter("@Original_idНомер_в_Госреестре", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idНомер_в_Госреестре", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Заводской_номер", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Заводской_номер", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Инвентарный_номер", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Инвентарный_номер", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Инвентарный_номер", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Инвентарный_номер", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Год_выпуска", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Год_выпуска", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Дата_поступления", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата_поступления", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Дата_поступления", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата_поступления", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Дата_очередного_МК", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата_очередного_МК", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Дата_проведения_МК", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата_проведения_МК", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_idСтатус", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "idСтатус", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_idСтатус", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idСтатус", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_idМесто_проведения_поверки", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "idМесто_проведения_поверки", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_idМесто_проведения_поверки", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idМесто_проведения_поверки", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_idОтветственный", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "idОтветственный", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_idОтветственный", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idОтветственный", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_idСИ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idСИ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@idСИ", System.Data.SqlDbType.Int, 4, "idСИ")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_idНомер_в_Госреестре", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idНомер_в_Госреестре", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Заводской_номер", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Заводской_номер", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Инвентарный_номер", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Инвентарный_номер", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Инвентарный_номер", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Инвентарный_номер", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Год_выпуска", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Год_выпуска", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Дата_поступления", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата_поступления", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Дата_поступления", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата_поступления", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Дата_очередного_МК", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата_очередного_МК", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Дата_проведения_МК", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата_проведения_МК", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_idСтатус", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "idСтатус", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_idСтатус", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idСтатус", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_idМесто_проведения_поверки", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "idМесто_проведения_поверки", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_idМесто_проведения_поверки", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idМесто_проведения_поверки", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_idОтветственный", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "idОтветственный", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_idОтветственный", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idОтветственный", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_idСИ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idСИ", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter3
            // 
            this.sqlDataAdapter3.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter3.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter3.SelectCommand = this.sqlSelectCommand3;
            this.sqlDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Перечень_СИ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idНомер_в_Госреестре", "idНомер_в_Госреестре"),
                        new System.Data.Common.DataColumnMapping("Заводской_номер", "Заводской_номер"),
                        new System.Data.Common.DataColumnMapping("Инвентарный_номер", "Инвентарный_номер"),
                        new System.Data.Common.DataColumnMapping("Год_выпуска", "Год_выпуска"),
                        new System.Data.Common.DataColumnMapping("Дата_поступления", "Дата_поступления"),
                        new System.Data.Common.DataColumnMapping("Дата_очередного_МК", "Дата_очередного_МК"),
                        new System.Data.Common.DataColumnMapping("Дата_проведения_МК", "Дата_проведения_МК"),
                        new System.Data.Common.DataColumnMapping("idСтатус", "idСтатус"),
                        new System.Data.Common.DataColumnMapping("idМесто_проведения_поверки", "idМесто_проведения_поверки"),
                        new System.Data.Common.DataColumnMapping("idОтветственный", "idОтветственный"),
                        new System.Data.Common.DataColumnMapping("idСИ", "idСИ")})});
            this.sqlDataAdapter3.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 445);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Перечень СИ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеЗапиямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьБДТиповСИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьБДОтветственныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьБДМестПоверкиToolStripMenuItem;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private dsDataSet dsDataSet1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter3;
    }
}