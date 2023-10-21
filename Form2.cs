using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_userName.Text;
            string password = txt_password.Text;

            if (username == "admin" && password == "admin")
            {
                this.Close();
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //this.Close();

        }
    }
}
