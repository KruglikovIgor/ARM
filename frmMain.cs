using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM
{
    public partial class frmMain : Form
    {
        int idSI;

        // создание экземпляра таблицы
        DataTable ListTable = new DataTable("List");
        DataTable ListTableDetailed = new DataTable("ListDetailed");
        dsARMDataSet armDataSet1 = new dsARMDataSet();
        dsDataSet armDataSet2 = new dsDataSet();

        //   //метод, возвращающий выбранный в сетке CustomersRow:
        private dsDataSet.Перечень_СИRow GetSelectedRow()
        {
            int SelectedCustomerID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            dsDataSet.Перечень_СИRow SelectedRow = armDataSet2.Перечень_СИ.FindByidСИ(SelectedCustomerID);
            return SelectedRow;
        }


        public frmMain(int x)
        {
            InitializeComponent();
            if (x == 1) 
            { 
                управлениеЗапиямиToolStripMenuItem.Visible = false;
                редакторБДToolStripMenuItem.Visible=false;
            }
            if (x == 2)
            {
                редакторБДToolStripMenuItem.Visible = false;
            }
            armDataSet1.Tables.Add(ListTable);
            armDataSet1.Tables.Add(ListTableDetailed);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(1918, 1030);
            dataGridView1.Width = 1918;
            dataGridView1.Height = 940;

            dsDataSet.Перечень_СИRow NewRow = (dsDataSet.Перечень_СИRow)armDataSet2.Перечень_СИ.NewRow();
            // создание столбцов для таблицы ListTable и ListTableDetailed
            DataColumn idСИ = new DataColumn("idСИ", Type.GetType("System.Int32"));
            DataColumn Статус_СИ = new DataColumn("Шифр", Type.GetType("System.String"));
            DataColumn idНомер_в_Госреестре = new DataColumn("idНомер_в_Госреестре", Type.GetType("System.String"));
            DataColumn Заводской_номер = new DataColumn("Заводской_номер", Type.GetType("System.String"));
            DataColumn Наименование_типа_СИ = new DataColumn("Наименование_типа_СИ", Type.GetType("System.String"));
            DataColumn Тип_СИ = new DataColumn("Тип_СИ", Type.GetType("System.String"));
            DataColumn Диапазон_измерений = new DataColumn("Диапазон_измерений", Type.GetType("System.String"));
            DataColumn Погрешность_измерений = new DataColumn("Погрешность_измерений", Type.GetType("System.String"));
            DataColumn Дата_очередного_МК = new DataColumn("Дата_очередного_МК", Type.GetType("System.DateTime"));
            DataColumn Год_выпуска = new DataColumn("Год_выпуска", Type.GetType("System.Int32"));
            DataColumn Дата_поступления = new DataColumn("Дата_поступления", Type.GetType("System.DateTime"));
            DataColumn Дата_проведения_МК = new DataColumn("Дата_проведения_МК", Type.GetType("System.DateTime"));
            DataColumn Название = new DataColumn("Название", Type.GetType("System.String"));
            DataColumn Адрес = new DataColumn("Адрес", Type.GetType("System.String"));
            DataColumn ФИО = new DataColumn("ФИО", Type.GetType("System.String"));
            DataColumn Почта = new DataColumn("Почта", Type.GetType("System.String"));

            // добавление столбцов в таблицу ListTable
            ListTable.Columns.Add(idСИ);
            ListTable.Columns.Add(Статус_СИ);
            ListTable.Columns.Add(idНомер_в_Госреестре);
            ListTable.Columns.Add(Заводской_номер);
            ListTable.Columns.Add(Наименование_типа_СИ);
            ListTable.Columns.Add(Тип_СИ);
            ListTable.Columns.Add(Диапазон_измерений);
            ListTable.Columns.Add(Погрешность_измерений);
            ListTable.Columns.Add(Дата_очередного_МК);

            // добавление столбцов в таблицу ListTableDetailed
            ListTableDetailed.Columns.Add(Год_выпуска);
            ListTableDetailed.Columns.Add(Дата_поступления);
            ListTableDetailed.Columns.Add(Дата_проведения_МК);
            ListTableDetailed.Columns.Add(Название);
            ListTableDetailed.Columns.Add(Адрес);
            ListTableDetailed.Columns.Add(ФИО);
            ListTableDetailed.Columns.Add(Почта);

            dataGridView1.DataSource = ListTable;
            sqlDataAdapter1.Fill(ListTable);
            sqlDataAdapter3.Fill(armDataSet1.Перечень_СИ);


            //установка шрифта ячеек DataGridView1
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
            //dataGridView1.Font = new Font("Tahoma", 12);

            //установка выравнивания по центру в ячейках DataGridView1
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Разрешение переноса строк в ячейках DataGridView1
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // Установка чередования окрвски строк (белый/ серый)
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //Установка ширины столюцов в DataGridView1
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 63;
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 400;
            dataGridView1.Columns[5].Width = 240;
            dataGridView1.Columns[6].Width = 200;
            dataGridView1.Columns[7].Width = 265;
            dataGridView1.Columns[8].Width = 195;

            dataGridView2.DataSource = ListTableDetailed;
            sqlDataAdapter2.Fill(ListTableDetailed);
            //установка шрифта ячеек DataGridView
            dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 15);
            //dataGridView2.Font = new Font("Tahoma", 12);

            //установка выравнивания по центру в ячейках DataGridView2
            dataGridView2.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Разрешение переноса строк в ячейках DataGridView2
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // Установка чередования окрвски строк (белый/ серый)
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //Установка ширины столюцов в DataGridView2
            dataGridView2.Columns[0].Width = 200;
            dataGridView2.Columns[1].Width = 200;
            dataGridView2.Columns[2].Width = 200;
            dataGridView2.Columns[3].Width = 200;
            dataGridView2.Columns[4].Width = 350;
            dataGridView2.Columns[5].Width = 300;
            dataGridView2.Columns[6].Width = 385;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                //DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // String[] DataGridTemp;

                frmDetailed frm2 = new frmDetailed();
                // Получаем данные из выбранной строки
                DataGridViewRow rw = dataGridView1.Rows[e.RowIndex];


                frm2.dataGridViewDetailed1.Rows.Add(rw.Cells[0].Value,
                                                rw.Cells[1].Value,
                                                rw.Cells[2].Value,
                                                rw.Cells[3].Value,
                                                rw.Cells[4].Value,
                                                rw.Cells[5].Value,
                                                rw.Cells[6].Value,
                                                rw.Cells[7].Value,
                                                rw.Cells[8].Value);

                DataGridViewRow rw2 = dataGridView2.Rows[e.RowIndex];
                frm2.dataGridViewDetailed2.Rows.Add(rw2.Cells[0].Value,
                                                rw2.Cells[1].Value,
                                                rw2.Cells[2].Value,
                                                rw2.Cells[3].Value,
                                                rw2.Cells[4].Value,
                                                rw2.Cells[5].Value,
                                                rw2.Cells[6].Value);

                frm2.Show();

            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            int b = (int)dataGridView1.Rows[a].Cells[0].Value;

            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);

            dsARMDataSet.Перечень_СИRow Row = (dsARMDataSet.Перечень_СИRow)armDataSet1.Перечень_СИ.FindByidСИ(b);
            Row.Delete();

            sqlDataAdapter3.Update(armDataSet1);
           MessageBox.Show("Выбранная запись удалена");

        }

        private void редактироватьБДТиповСИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEdit frmEdit = new frmEdit(0);
            frmEdit.Show();
        }

        private void редактироватьБДОтветственныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEdit frmEdit = new frmEdit(1);
            frmEdit.Show();
        }

        private void редактироватьБДМестПоверкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEdit frmEdit = new frmEdit(2);
            frmEdit.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int a = dataGridView1.CurrentRow.Index;
            int b = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

            dsARMDataSet.Перечень_СИRow rowUpd = (dsARMDataSet.Перечень_СИRow)armDataSet1.Перечень_СИ.FindByidСИ(b);
           
            //MessageBox.Show("idСИ=" + rowUpd.idСИ.ToString());

            frmAddUpd frmAddUpd = new frmAddUpd(1,rowUpd.idСИ);
            frmAddUpd.Text = "Редактирование записи";
            frmAddUpd.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpd frmAddUpd = new frmAddUpd(0,0);
            frmAddUpd.Text = "Добавление записи";
            frmAddUpd.Show();
        }
    }

}