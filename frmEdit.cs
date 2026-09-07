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
    public partial class frmEdit : Form
    {
        dsEditBD dsEditBD1 = new dsEditBD();

        public frmEdit()
        {
            InitializeComponent();

        }

        public frmEdit(int x)
        {
            InitializeComponent();
            // Установка чередования окрвски строк (белый/ серый)
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            if (x == 0)
            {
                this.Text = "Редактор базы данных типов СИ";
                dataGridView1.DataSource = dsEditBD1.Типы_СИ;
                daEditTypeSI.Fill(dsEditBD1.Типы_СИ);


                //Установка ширины столбцов в DataGridView1
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 350;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 220;
                dataGridView1.Columns[4].Width = 200;

            }
            else
            {
                if (x == 1)
                {
                this.Text = "Редактор базы ответственных за СИ";
                    dataGridView1.DataSource = dsEditBD1.Ответственные;
                    daEditResponsible.Fill(dsEditBD1.Ответственные);

                    // Установка чередования окрвски строк (белый/ серый)
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    //Установка ширины столбцов в DataGridView1
                    dataGridView1.Columns[0].Width = 200;
                    dataGridView1.Columns[1].Width = 450;
                    dataGridView1.Columns[2].Width = 450;
                }
                else
                {
                this.Text = "Редактор базы организаций- поверителей СИ";
                    dataGridView1.DataSource = dsEditBD1.Место_проведения_поверки;
                    daEditContractors.Fill(dsEditBD1.Место_проведения_поверки);

                    // Установка чередования окрвски строк (белый/ серый)
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    //Установка ширины столбцов в DataGridView1
                    dataGridView1.Columns[0].Width = 200;
                    dataGridView1.Columns[1].Width = 450;
                    dataGridView1.Columns[2].Width = 450;
                }
            }


        }

        private void btnExitEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            daEditTypeSI.Update(dsEditBD1);
            daEditResponsible.Update(dsEditBD1);
            daEditContractors.Update(dsEditBD1);           

        }
    }
}
