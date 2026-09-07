namespace ARM
{
    partial class frmAddUpd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgTypeSI = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daListSI = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daTypeSI = new System.Data.SqlClient.SqlDataAdapter();
            this.dgResponsible = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daResponsible = new System.Data.SqlClient.SqlDataAdapter();
            this.dgContractor = new System.Windows.Forms.DataGridView();
            this.dgStatus = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.daContractor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
            this.daStatus = new System.Data.SqlClient.SqlDataAdapter();
            this.btnExitAddUpd = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtInventoryNumber = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtlActualVerification = new System.Windows.Forms.TextBox();
            this.txtlRegularVerification = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.lblActualVerification = new System.Windows.Forms.Label();
            this.lblRegularVerification = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblTypeSI = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblResponsible = new System.Windows.Forms.Label();
            this.lblContractor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTypeSI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResponsible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTypeSI
            // 
            this.dgTypeSI.AllowUserToAddRows = false;
            this.dgTypeSI.AllowUserToDeleteRows = false;
            this.dgTypeSI.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTypeSI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTypeSI.ColumnHeadersHeight = 40;
            this.dgTypeSI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTypeSI.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgTypeSI.Location = new System.Drawing.Point(76, 92);
            this.dgTypeSI.MultiSelect = false;
            this.dgTypeSI.Name = "dgTypeSI";
            this.dgTypeSI.RowTemplate.Height = 40;
            this.dgTypeSI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTypeSI.Size = new System.Drawing.Size(1178, 165);
            this.dgTypeSI.TabIndex = 0;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "select * from dbo.Перечень_СИ";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=ARM;Integrated Security=True;Pooling=False;En" +
    "crypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
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
            // daListSI
            // 
            this.daListSI.DeleteCommand = this.sqlDeleteCommand1;
            this.daListSI.InsertCommand = this.sqlInsertCommand1;
            this.daListSI.SelectCommand = this.sqlSelectCommand1;
            this.daListSI.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            this.daListSI.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "select * from dbo.Типы_СИ";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // daTypeSI
            // 
            this.daTypeSI.SelectCommand = this.sqlSelectCommand2;
            this.daTypeSI.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Типы_СИ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idНомер_в_Госреестре", "idНомер_в_Госреестре"),
                        new System.Data.Common.DataColumnMapping("Наименование_типа_СИ", "Наименование_типа_СИ"),
                        new System.Data.Common.DataColumnMapping("Тип_СИ", "Тип_СИ"),
                        new System.Data.Common.DataColumnMapping("Погрешность_измерений", "Погрешность_измерений"),
                        new System.Data.Common.DataColumnMapping("Диапазон_измерений", "Диапазон_измерений")})});
            // 
            // dgResponsible
            // 
            this.dgResponsible.AllowUserToAddRows = false;
            this.dgResponsible.AllowUserToDeleteRows = false;
            this.dgResponsible.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResponsible.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgResponsible.ColumnHeadersHeight = 40;
            this.dgResponsible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResponsible.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgResponsible.Location = new System.Drawing.Point(76, 360);
            this.dgResponsible.Name = "dgResponsible";
            this.dgResponsible.RowTemplate.Height = 40;
            this.dgResponsible.Size = new System.Drawing.Size(800, 165);
            this.dgResponsible.TabIndex = 1;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "select * from dbo.Ответственные";
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idОтветственный", System.Data.SqlDbType.TinyInt, 0, "idОтветственный"),
            new System.Data.SqlClient.SqlParameter("@ФИО", System.Data.SqlDbType.NVarChar, 0, "ФИО"),
            new System.Data.SqlClient.SqlParameter("@Почта", System.Data.SqlDbType.NVarChar, 0, "Почта")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idОтветственный", System.Data.SqlDbType.TinyInt, 0, "idОтветственный"),
            new System.Data.SqlClient.SqlParameter("@ФИО", System.Data.SqlDbType.NVarChar, 0, "ФИО"),
            new System.Data.SqlClient.SqlParameter("@Почта", System.Data.SqlDbType.NVarChar, 0, "Почта"),
            new System.Data.SqlClient.SqlParameter("@Original_idОтветственный", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idОтветственный", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ФИО", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ФИО", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Почта", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Почта", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[Ответственные] WHERE (([idОтветственный] = @Original_idОтветст" +
    "венный) AND ([ФИО] = @Original_ФИО) AND ([Почта] = @Original_Почта))";
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_idОтветственный", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idОтветственный", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ФИО", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ФИО", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Почта", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Почта", System.Data.DataRowVersion.Original, null)});
            // 
            // daResponsible
            // 
            this.daResponsible.DeleteCommand = this.sqlDeleteCommand2;
            this.daResponsible.InsertCommand = this.sqlInsertCommand2;
            this.daResponsible.SelectCommand = this.sqlSelectCommand3;
            this.daResponsible.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Ответственные", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idОтветственный", "idОтветственный"),
                        new System.Data.Common.DataColumnMapping("ФИО", "ФИО"),
                        new System.Data.Common.DataColumnMapping("Почта", "Почта")})});
            this.daResponsible.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // dgContractor
            // 
            this.dgContractor.AllowUserToAddRows = false;
            this.dgContractor.AllowUserToDeleteRows = false;
            this.dgContractor.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgContractor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgContractor.ColumnHeadersHeight = 40;
            this.dgContractor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgContractor.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgContractor.Location = new System.Drawing.Point(1017, 360);
            this.dgContractor.Name = "dgContractor";
            this.dgContractor.RowTemplate.Height = 40;
            this.dgContractor.Size = new System.Drawing.Size(800, 165);
            this.dgContractor.TabIndex = 2;
            // 
            // dgStatus
            // 
            this.dgStatus.AllowUserToAddRows = false;
            this.dgStatus.AllowUserToDeleteRows = false;
            this.dgStatus.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgStatus.ColumnHeadersHeight = 40;
            this.dgStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStatus.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgStatus.Location = new System.Drawing.Point(1353, 92);
            this.dgStatus.Name = "dgStatus";
            this.dgStatus.RowTemplate.Height = 40;
            this.dgStatus.Size = new System.Drawing.Size(464, 165);
            this.dgStatus.TabIndex = 3;
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "select * from dbo.Место_проведения_поверки";
            this.sqlSelectCommand4.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.sqlConnection1;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idМесто_проведения_поверки", System.Data.SqlDbType.TinyInt, 0, "idМесто_проведения_поверки"),
            new System.Data.SqlClient.SqlParameter("@Название", System.Data.SqlDbType.NVarChar, 0, "Название"),
            new System.Data.SqlClient.SqlParameter("@Адрес", System.Data.SqlDbType.NVarChar, 0, "Адрес")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlConnection1;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idМесто_проведения_поверки", System.Data.SqlDbType.TinyInt, 0, "idМесто_проведения_поверки"),
            new System.Data.SqlClient.SqlParameter("@Название", System.Data.SqlDbType.NVarChar, 0, "Название"),
            new System.Data.SqlClient.SqlParameter("@Адрес", System.Data.SqlDbType.NVarChar, 0, "Адрес"),
            new System.Data.SqlClient.SqlParameter("@Original_idМесто_проведения_поверки", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idМесто_проведения_поверки", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Название", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Название", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Адрес", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Адрес", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = "DELETE FROM [dbo].[Место_проведения_поверки] WHERE (([idМесто_проведения_поверки]" +
    " = @Original_idМесто_проведения_поверки) AND ([Название] = @Original_Название) A" +
    "ND ([Адрес] = @Original_Адрес))";
            this.sqlDeleteCommand3.Connection = this.sqlConnection1;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_idМесто_проведения_поверки", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idМесто_проведения_поверки", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Название", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Название", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Адрес", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Адрес", System.Data.DataRowVersion.Original, null)});
            // 
            // daContractor
            // 
            this.daContractor.DeleteCommand = this.sqlDeleteCommand3;
            this.daContractor.InsertCommand = this.sqlInsertCommand3;
            this.daContractor.SelectCommand = this.sqlSelectCommand4;
            this.daContractor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Место_проведения_поверки", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idМесто_проведения_поверки", "idМесто_проведения_поверки"),
                        new System.Data.Common.DataColumnMapping("Название", "Название"),
                        new System.Data.Common.DataColumnMapping("Адрес", "Адрес")})});
            this.daContractor.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "select * from dbo.Статус_СИ";
            this.sqlSelectCommand5.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand4
            // 
            this.sqlInsertCommand4.CommandText = "INSERT INTO [dbo].[Статус_СИ] ([idСтатус], [Шифр], [Комментарий]) VALUES (@idСтат" +
    "ус, @Шифр, @Комментарий);\r\nSELECT idСтатус, Шифр, Комментарий FROM Статус_СИ WHE" +
    "RE (idСтатус = @idСтатус)";
            this.sqlInsertCommand4.Connection = this.sqlConnection1;
            this.sqlInsertCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idСтатус", System.Data.SqlDbType.TinyInt, 0, "idСтатус"),
            new System.Data.SqlClient.SqlParameter("@Шифр", System.Data.SqlDbType.NVarChar, 0, "Шифр"),
            new System.Data.SqlClient.SqlParameter("@Комментарий", System.Data.SqlDbType.NVarChar, 0, "Комментарий")});
            // 
            // sqlUpdateCommand4
            // 
            this.sqlUpdateCommand4.CommandText = resources.GetString("sqlUpdateCommand4.CommandText");
            this.sqlUpdateCommand4.Connection = this.sqlConnection1;
            this.sqlUpdateCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idСтатус", System.Data.SqlDbType.TinyInt, 0, "idСтатус"),
            new System.Data.SqlClient.SqlParameter("@Шифр", System.Data.SqlDbType.NVarChar, 0, "Шифр"),
            new System.Data.SqlClient.SqlParameter("@Комментарий", System.Data.SqlDbType.NVarChar, 0, "Комментарий"),
            new System.Data.SqlClient.SqlParameter("@Original_idСтатус", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idСтатус", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Шифр", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Шифр", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Комментарий", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Комментарий", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand4
            // 
            this.sqlDeleteCommand4.CommandText = "DELETE FROM [dbo].[Статус_СИ] WHERE (([idСтатус] = @Original_idСтатус) AND ([Шифр" +
    "] = @Original_Шифр) AND ([Комментарий] = @Original_Комментарий))";
            this.sqlDeleteCommand4.Connection = this.sqlConnection1;
            this.sqlDeleteCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_idСтатус", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "idСтатус", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Шифр", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Шифр", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Комментарий", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Комментарий", System.Data.DataRowVersion.Original, null)});
            // 
            // daStatus
            // 
            this.daStatus.DeleteCommand = this.sqlDeleteCommand4;
            this.daStatus.InsertCommand = this.sqlInsertCommand4;
            this.daStatus.SelectCommand = this.sqlSelectCommand5;
            this.daStatus.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Статус_СИ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idСтатус", "idСтатус"),
                        new System.Data.Common.DataColumnMapping("Шифр", "Шифр"),
                        new System.Data.Common.DataColumnMapping("Комментарий", "Комментарий")})});
            this.daStatus.UpdateCommand = this.sqlUpdateCommand4;
            // 
            // btnExitAddUpd
            // 
            this.btnExitAddUpd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitAddUpd.BackgroundImage")));
            this.btnExitAddUpd.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitAddUpd.ForeColor = System.Drawing.Color.Red;
            this.btnExitAddUpd.Location = new System.Drawing.Point(853, 839);
            this.btnExitAddUpd.Name = "btnExitAddUpd";
            this.btnExitAddUpd.Size = new System.Drawing.Size(209, 95);
            this.btnExitAddUpd.TabIndex = 4;
            this.btnExitAddUpd.Text = "Закрыть окно";
            this.btnExitAddUpd.UseVisualStyleBackColor = true;
            this.btnExitAddUpd.Click += new System.EventHandler(this.btnExitAddUpd_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpd.BackgroundImage")));
            this.btnUpd.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpd.ForeColor = System.Drawing.Color.Red;
            this.btnUpd.Location = new System.Drawing.Point(1202, 839);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(209, 95);
            this.btnUpd.TabIndex = 5;
            this.btnUpd.Text = "Сохранить изменения";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(533, 839);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 95);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить запись";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSerialNumber.Location = new System.Drawing.Point(76, 652);
            this.txtSerialNumber.Multiline = true;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(242, 51);
            this.txtSerialNumber.TabIndex = 7;
            this.txtSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSerialNumber.Location = new System.Drawing.Point(87, 598);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(219, 24);
            this.lblSerialNumber.TabIndex = 8;
            this.lblSerialNumber.Text = "Заводской номер СИ";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInventory.Location = new System.Drawing.Point(365, 598);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(246, 24);
            this.lblInventory.TabIndex = 9;
            this.lblInventory.Text = "Инвентарный номер СИ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYear.Location = new System.Drawing.Point(695, 598);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(167, 24);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Год выпуска СИ";
            // 
            // txtInventoryNumber
            // 
            this.txtInventoryNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtInventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInventoryNumber.Location = new System.Drawing.Point(369, 652);
            this.txtInventoryNumber.Multiline = true;
            this.txtInventoryNumber.Name = "txtInventoryNumber";
            this.txtInventoryNumber.Size = new System.Drawing.Size(242, 51);
            this.txtInventoryNumber.TabIndex = 11;
            this.txtInventoryNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtYear.Location = new System.Drawing.Point(665, 652);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(242, 51);
            this.txtYear.TabIndex = 12;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtlActualVerification
            // 
            this.txtlActualVerification.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtlActualVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtlActualVerification.Location = new System.Drawing.Point(1556, 652);
            this.txtlActualVerification.Multiline = true;
            this.txtlActualVerification.Name = "txtlActualVerification";
            this.txtlActualVerification.Size = new System.Drawing.Size(242, 51);
            this.txtlActualVerification.TabIndex = 15;
            this.txtlActualVerification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtlRegularVerification
            // 
            this.txtlRegularVerification.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtlRegularVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtlRegularVerification.Location = new System.Drawing.Point(1250, 649);
            this.txtlRegularVerification.Multiline = true;
            this.txtlRegularVerification.Name = "txtlRegularVerification";
            this.txtlRegularVerification.Size = new System.Drawing.Size(242, 51);
            this.txtlRegularVerification.TabIndex = 14;
            this.txtlRegularVerification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtArrival
            // 
            this.txtArrival.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtArrival.Location = new System.Drawing.Point(956, 652);
            this.txtArrival.Multiline = true;
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(242, 51);
            this.txtArrival.TabIndex = 13;
            this.txtArrival.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblActualVerification
            // 
            this.lblActualVerification.AutoSize = true;
            this.lblActualVerification.BackColor = System.Drawing.Color.Transparent;
            this.lblActualVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActualVerification.Location = new System.Drawing.Point(1540, 598);
            this.lblActualVerification.Name = "lblActualVerification";
            this.lblActualVerification.Size = new System.Drawing.Size(277, 48);
            this.lblActualVerification.TabIndex = 18;
            this.lblActualVerification.Text = "Фактическая дата поверки\r\n(формат: дд-мм-гггг)";
            this.lblActualVerification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegularVerification
            // 
            this.lblRegularVerification.AutoSize = true;
            this.lblRegularVerification.BackColor = System.Drawing.Color.Transparent;
            this.lblRegularVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegularVerification.Location = new System.Drawing.Point(1246, 598);
            this.lblRegularVerification.Name = "lblRegularVerification";
            this.lblRegularVerification.Size = new System.Drawing.Size(260, 48);
            this.lblRegularVerification.TabIndex = 17;
            this.lblRegularVerification.Text = "Дата очередной поверки\r\n(формат: дд-мм-гггг)";
            this.lblRegularVerification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.BackColor = System.Drawing.Color.Transparent;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArrival.Location = new System.Drawing.Point(968, 598);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(230, 48);
            this.lblArrival.TabIndex = 16;
            this.lblArrival.Text = "Дата поступления СИ \r\n(формат: дд-мм-гггг)";
            this.lblArrival.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeSI
            // 
            this.lblTypeSI.AutoSize = true;
            this.lblTypeSI.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypeSI.Location = new System.Drawing.Point(562, 43);
            this.lblTypeSI.Name = "lblTypeSI";
            this.lblTypeSI.Size = new System.Drawing.Size(249, 24);
            this.lblTypeSI.TabIndex = 19;
            this.lblTypeSI.Text = "Номер СИ в Госреестре";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(1531, 43);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 24);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Статус СИ";
            // 
            // lblResponsible
            // 
            this.lblResponsible.AutoSize = true;
            this.lblResponsible.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResponsible.Location = new System.Drawing.Point(367, 314);
            this.lblResponsible.Name = "lblResponsible";
            this.lblResponsible.Size = new System.Drawing.Size(230, 24);
            this.lblResponsible.TabIndex = 21;
            this.lblResponsible.Text = "Ответственный за СИ";
            // 
            // lblContractor
            // 
            this.lblContractor.AutoSize = true;
            this.lblContractor.BackColor = System.Drawing.Color.Transparent;
            this.lblContractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContractor.Location = new System.Drawing.Point(1305, 314);
            this.lblContractor.Name = "lblContractor";
            this.lblContractor.Size = new System.Drawing.Size(321, 24);
            this.lblContractor.TabIndex = 22;
            this.lblContractor.Text = "Место проведения поверки СИ";
            // 
            // frmAddUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1902, 991);
            this.Controls.Add(this.lblContractor);
            this.Controls.Add(this.lblResponsible);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTypeSI);
            this.Controls.Add(this.lblActualVerification);
            this.Controls.Add(this.lblRegularVerification);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.txtlActualVerification);
            this.Controls.Add(this.txtlRegularVerification);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtInventoryNumber);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnExitAddUpd);
            this.Controls.Add(this.dgStatus);
            this.Controls.Add(this.dgContractor);
            this.Controls.Add(this.dgResponsible);
            this.Controls.Add(this.dgTypeSI);
            this.Name = "frmAddUpd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Редактирование записи о СИ";
            this.Load += new System.EventHandler(this.frmAddUpd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTypeSI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResponsible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTypeSI;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daListSI;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter daTypeSI;
        private System.Windows.Forms.DataGridView dgResponsible;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daResponsible;
        private System.Windows.Forms.DataGridView dgContractor;
        private System.Windows.Forms.DataGridView dgStatus;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter daContractor;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
        private System.Data.SqlClient.SqlDataAdapter daStatus;
        private System.Windows.Forms.Button btnExitAddUpd;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtInventoryNumber;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtlActualVerification;
        private System.Windows.Forms.TextBox txtlRegularVerification;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.Label lblActualVerification;
        private System.Windows.Forms.Label lblRegularVerification;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblTypeSI;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblResponsible;
        private System.Windows.Forms.Label lblContractor;
    }
}