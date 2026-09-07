using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM
{
    public partial class frmAutorization : Form
    {
        int accessLevelUser;
        public frmAutorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmAutorization_Load(object sender, EventArgs e)
        {
            txtPass.MaxLength = 50;
            txtLogin.MaxLength = 50;    
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            var loginUser=txtLogin.Text;
            var passUser=txtPass.Text;
 

           dsAutorization dsAutorization1 = new dsAutorization();
            daAutorization.Fill(dsAutorization1.Пользователи);
             //string msg;
            accessLevelUser=0;
            for (int i=0; i< dsAutorization1.Пользователи.Count; i++)
            {
            if (dsAutorization1.Пользователи.Rows[i][1].ToString()==loginUser.ToString()&& dsAutorization1.Пользователи.Rows[i][2].ToString() == passUser.ToString()) 
                {
                    //msg = dsAutorization1.Пользователи.Rows[i][3].ToString();
                    accessLevelUser = i + 1;
                    break;
                }
             }
            if(accessLevelUser == 0) {
                MessageBox.Show("Пользователь с таким логином и паролем не найден в системе!\n Обратитесь в отдел главного метролога для получения доступа");    
            }   
            else
            {
                frmMain frm2 = new frmMain(accessLevelUser);
                frm2.Show();
                this.Close();
            }
        }

    }
}
