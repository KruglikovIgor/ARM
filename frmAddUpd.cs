using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace ARM
{
    public partial class frmAddUpd : Form
    {
        private int a, id;
        dsAppUpd dsAppUpd1=new dsAppUpd();

        public frmAddUpd(int x,int y)
        {
            InitializeComponent();
            id = y;
        }

        private void frmAddUpd_Load(object sender, EventArgs e)
        {
            daListSI.Fill(dsAppUpd1.Перечень_СИ);
            daTypeSI.Fill(dsAppUpd1.Типы_СИ);
            daContractor.Fill(dsAppUpd1.Место_проведения_поверки);
            daResponsible.Fill(dsAppUpd1.Ответственные);
            daStatus.Fill(dsAppUpd1.Статус_СИ);

            dgResponsible.DataSource = dsAppUpd1.Ответственные;
            dgResponsible.Columns[0].Width = 150;
            dgResponsible.Columns[1].Width = 295;
            dgResponsible.Columns[2].Width = 295;

            dgTypeSI.DataSource = dsAppUpd1.Типы_СИ;
            dgTypeSI.Columns[0].Width = 200;
            dgTypeSI.Columns[1].Width = 297;
            dgTypeSI.Columns[2].Width = 200;
            dgTypeSI.Columns[3].Width = 210;
            dgTypeSI.Columns[4].Width = 210;

            dgContractor.DataSource = dsAppUpd1.Место_проведения_поверки;
            dgContractor.Columns[0].Width = 250;
            dgContractor.Columns[1].Width = 210;
            dgContractor.Columns[2].Width = 280;

            dgStatus.DataSource = dsAppUpd1.Статус_СИ;
            dgStatus.Columns[0].Width = 90;
            dgStatus.Columns[1].Width = 70;
            dgStatus.Columns[2].Width = 243;

            if (id == 0)
            {
               LoadData();
            }
            else
            {
                LoadData(id);
            }

            //dsAppUpd.Перечень_СИRow Row = (dsAppUpd.Перечень_СИRow)dsAppUpd1.Перечень_СИ.FindByidСИ(id);
            //txtSerialNumber.Text = Row.Заводской_номер;
            //txtInventoryNumber.Text = Row.Инвентарный_номер.ToString(); 
            //txtYear.Text = Row.Год_выпуска.ToString();
            //txtArrival.Text = Row.Дата_поступления.ToString("dd.MM.yyyy");
            //txtlRegularVerification.Text = Row.Дата_очередного_МК.ToString("dd.MM.yyyy");
            //txtlActualVerification.Text = Row.Дата_проведения_МК.ToString("dd.MM.yyyy") ;

            //dgResponsible.Rows[Row.idОтветственный-1].Selected = true;
            //dgResponsible.CurrentCell = dgResponsible[0, Row.idОтветственный - 1];
            //dgResponsible.FirstDisplayedScrollingRowIndex = Row.idОтветственный-1;
 
            //dgContractor.Rows[Row.idМесто_проведения_поверки-1].Selected = true;
            //dgContractor.CurrentCell = dgContractor[0, Row.idМесто_проведения_поверки - 1];
            //dgContractor.FirstDisplayedScrollingRowIndex = Row.idМесто_проведения_поверки - 1;

            //dgStatus.Rows[Row.idСтатус - 1].Selected = true;
            //dgStatus.CurrentCell = dgStatus[0, Row.idСтатус - 1];
            //dgStatus.FirstDisplayedScrollingRowIndex = Row.idСтатус-1;

            //dsAppUpd.Типы_СИRow RowTypeSI = (dsAppUpd.Типы_СИRow)dsAppUpd1.Типы_СИ.FindByidНомер_в_Госреестре(Row.idНомер_в_Госреестре);
            //int index =dsAppUpd1.Типы_СИ.Rows.IndexOf(RowTypeSI);
            //dgTypeSI.ClearSelection();
            //dgTypeSI.Rows[index].Selected = true;
            //dgTypeSI.CurrentCell = dgTypeSI[0, index];
            //dgTypeSI.FirstDisplayedScrollingRowIndex = index;
        }
        private void LoadData()
        {
            btnUpd.Visible = false;
            txtSerialNumber.Text = "";
            txtInventoryNumber.Text = "";
            txtYear.Text = "";
            txtArrival.Text = "";
            txtlRegularVerification.Text = "";
            txtlActualVerification.Text = "";
        }

        private void LoadData(int x)
        {
            btnAdd.Visible = false;
            id = x;
            dsAppUpd.Перечень_СИRow RowLoad = (dsAppUpd.Перечень_СИRow)dsAppUpd1.Перечень_СИ.FindByidСИ(id);
            txtSerialNumber.Text = RowLoad.Заводской_номер;
            txtInventoryNumber.Text = RowLoad.Инвентарный_номер.ToString();
            txtYear.Text = RowLoad.Год_выпуска.ToString();
            txtArrival.Text = RowLoad.Дата_поступления.ToString("dd.MM.yyyy");
            txtlRegularVerification.Text = RowLoad.Дата_очередного_МК.ToString("dd.MM.yyyy");
            txtlActualVerification.Text = RowLoad.Дата_проведения_МК.ToString("dd.MM.yyyy");

            dgResponsible.Rows[RowLoad.idОтветственный - 1].Selected = true;
            dgResponsible.CurrentCell = dgResponsible[0, RowLoad.idОтветственный - 1];
            dgResponsible.FirstDisplayedScrollingRowIndex = RowLoad.idОтветственный - 1;

            dgContractor.Rows[RowLoad.idМесто_проведения_поверки - 1].Selected = true;
            dgContractor.CurrentCell = dgContractor[0, RowLoad.idМесто_проведения_поверки - 1];
            dgContractor.FirstDisplayedScrollingRowIndex = RowLoad.idМесто_проведения_поверки - 1;

            dgStatus.Rows[RowLoad.idСтатус - 1].Selected = true;
            dgStatus.CurrentCell = dgStatus[0, RowLoad.idСтатус - 1];
            dgStatus.FirstDisplayedScrollingRowIndex = RowLoad.idСтатус - 1;

            dsAppUpd.Типы_СИRow RowTypeSI = (dsAppUpd.Типы_СИRow)dsAppUpd1.Типы_СИ.FindByidНомер_в_Госреестре(RowLoad.idНомер_в_Госреестре);
            int index = dsAppUpd1.Типы_СИ.Rows.IndexOf(RowTypeSI);
            dgTypeSI.ClearSelection();
            dgTypeSI.Rows[index].Selected = true;
            dgTypeSI.CurrentCell = dgTypeSI[0, index];
            dgTypeSI.FirstDisplayedScrollingRowIndex = index;
        }

        private void btnExitAddUpd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a = dgTypeSI.CurrentRow.Index;
            string idType = dgTypeSI.Rows[a].Cells[0].Value.ToString();
            int inventNumber = Convert.ToInt32(txtInventoryNumber.Text);
            int year = Convert.ToInt32(txtYear.Text);
            String dateString1 = txtArrival.Text;
            DateTime date1 = DateTime.ParseExact(dateString1, "dd.MM.yyyy",System.Globalization.CultureInfo.InvariantCulture);
            String dateString2 = txtlRegularVerification.Text;
            DateTime date2 = DateTime.ParseExact(dateString2, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            String dateString3 = txtlActualVerification.Text;
            DateTime date3 = DateTime.ParseExact(dateString3, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            byte idStatus = Convert.ToByte(dgStatus.Rows[dgStatus.CurrentRow.Index].Cells[0].Value);
            byte idContractor = Convert.ToByte(dgContractor.Rows[dgContractor.CurrentRow.Index].Cells[0].Value);
            byte ididResponsible = Convert.ToByte(dgResponsible.Rows[dgResponsible.CurrentRow.Index].Cells[0].Value);

            dsAppUpd.Перечень_СИRow NewRow = (dsAppUpd.Перечень_СИRow)dsAppUpd1.Перечень_СИ.NewRow();
            NewRow.idНомер_в_Госреестре = idType;
            NewRow.Заводской_номер = txtSerialNumber.Text;
            NewRow.Инвентарный_номер = inventNumber;
            NewRow.Год_выпуска = year;
            NewRow.Дата_поступления =date1;
            NewRow.Дата_очередного_МК = date2;
            NewRow.Дата_проведения_МК = date3;
            NewRow.idСтатус = idStatus;
            NewRow.idМесто_проведения_поверки = idContractor;
            NewRow.idОтветственный = ididResponsible;
            try
            {
                dsAppUpd1.Перечень_СИ.Rows.Add(NewRow);
                MessageBox.Show( "Запись успешно добавлена в базу данных");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось добавить запись в базу данных");
            }
            daListSI.Update(dsAppUpd1);

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            int a = dgTypeSI.CurrentRow.Index;
            string idType = dgTypeSI.Rows[a].Cells[0].Value.ToString();


            int inventNumber = Convert.ToInt32(txtInventoryNumber.Text);
            int year = Convert.ToInt32(txtYear.Text);
            String dateString1 = txtArrival.Text;
            DateTime date1 = DateTime.ParseExact(dateString1, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            String dateString2 = txtlRegularVerification.Text;
            DateTime date2 = DateTime.ParseExact(dateString2, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            String dateString3 = txtlActualVerification.Text;
            DateTime date3 = DateTime.ParseExact(dateString3, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            byte idStatus = Convert.ToByte(dgStatus.Rows[dgStatus.CurrentCell.RowIndex].Cells[0].Value);
            byte idContractor = Convert.ToByte(dgContractor.Rows[dgContractor.CurrentCell.RowIndex].Cells[0].Value);
            byte ididResponsible = Convert.ToByte(dgResponsible.Rows[dgResponsible.CurrentCell.RowIndex].Cells[0].Value);
            dsAppUpd.Перечень_СИRow RowUpd = (dsAppUpd.Перечень_СИRow)dsAppUpd1.Перечень_СИ.FindByidСИ(id);
            RowUpd.idНомер_в_Госреестре = idType;
            RowUpd.Заводской_номер = txtSerialNumber.Text;
            RowUpd.Инвентарный_номер = inventNumber;
            RowUpd.Год_выпуска = year;
            RowUpd.Дата_поступления = date1;
            RowUpd.Дата_очередного_МК = date2;
            RowUpd.Дата_проведения_МК = date3;
            RowUpd.idСтатус = idStatus;
            RowUpd.idМесто_проведения_поверки = idContractor;
            RowUpd.idОтветственный = ididResponsible;

            daListSI.Update(dsAppUpd1);
            MessageBox.Show("Изменения успешно внесены в базу данных");
        }
    }
}
