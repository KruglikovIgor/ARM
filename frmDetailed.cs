using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM
{
    public partial class frmDetailed : Form
    {
        DataTable ListTable1 = new DataTable("List1");
        DataTable ListTableDetailed1 = new DataTable("ListDetailed1");
        public frmDetailed()
        {
            InitializeComponent();
        }

        private void frmDetailed_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(1918, 600);

            //установка шрифта ячеек DataGridView1
            dataGridViewDetailed1.DefaultCellStyle.Font = new Font("Tahoma", 15);
            //dataGridView1.Font = new Font("Tahoma", 12);
            dataGridViewDetailed1.Width = 1918;
            dataGridViewDetailed1.Height = 200;
            dataGridViewDetailed2.Width = 1918;
            dataGridViewDetailed2.Height = 200;

            //установка выравнивания по центру в ячейках DataGridView1
            dataGridViewDetailed1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Разрешение переноса строк в ячейках DataGridView1
            dataGridViewDetailed1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // Установка чередования окрвски строк (белый/ серый)
            dataGridViewDetailed1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //Установка ширины столюцов в DataGridView1
            dataGridViewDetailed1.Columns[0].Width = 50;
            dataGridViewDetailed1.Columns[1].Width = 63;
            dataGridViewDetailed1.Columns[2].Width = 220;
            dataGridViewDetailed1.Columns[3].Width = 200;
            dataGridViewDetailed1.Columns[4].Width = 400;
            dataGridViewDetailed1.Columns[5].Width = 240;
            dataGridViewDetailed1.Columns[6].Width = 200;
            dataGridViewDetailed1.Columns[7].Width = 265;
            dataGridViewDetailed1.Columns[8].Width = 195;

            //установка шрифта ячеек DataGridView
            dataGridViewDetailed2.DefaultCellStyle.Font = new Font("Tahoma", 15);
            //dataGridView2.Font = new Font("Tahoma", 12);

            //установка выравнивания по центру в ячейках DataGridView2
            dataGridViewDetailed2.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Разрешение переноса строк в ячейках DataGridView2
            dataGridViewDetailed2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // Установка чередования окрвски строк (белый/ серый)
            dataGridViewDetailed2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //Установка ширины столюцов в DataGridView2
            dataGridViewDetailed2.Columns[0].Width = 200;
            dataGridViewDetailed2.Columns[1].Width = 200;
            dataGridViewDetailed2.Columns[2].Width = 200;
            dataGridViewDetailed2.Columns[3].Width = 200;
            dataGridViewDetailed2.Columns[4].Width = 350;
            dataGridViewDetailed2.Columns[5].Width = 300;
            dataGridViewDetailed2.Columns[6].Width = 385;

        }

        private void btnExitDetailed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
