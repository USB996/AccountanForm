using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountantApp
{
    public partial class Register_form : Form
    {
        

        public Register_form()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User()
            {
                FirstName = Name_bx.Text,
                LastName=Lst_nm_bx.Text,
                ID=ID_Bx.Text,
                UserName=usrNm_bx.Text,
                Password=Pswrd_bx.Text,
                RepeatPassword=Rpt_pswrd_bx.Text


            });

        }


        void PasswordValidation()
        {
            if (Pswrd_bx.Text != Rpt_pswrd_bx.Text)
            {
                paswrd_mach_label.Visible = true;
            }
            else
            {
                paswrd_mach_label.Visible = false;
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            PasswordValidation();
        }
    }
}
