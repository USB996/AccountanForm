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
    public partial class AccountantApp : Form
    {
        public AccountantApp()
        {
            InitializeComponent();
        }

        private void Password_bx_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void UsrNm_bx_TextChanged(object sender, EventArgs e)
        {
            UsrNm_bx.Text.PadLeft(8);
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            validator();
        }
        
        void validator()
        {
            if (UsrNm_bx.Text==""&&Password_bx.Text=="")
            {
                Error_label.Visible = true;
            }
        }

        private void Register_label_Click(object sender, EventArgs e)
        {
            Register_form register_Form = new Register_form();
            register_Form.ShowDialog();
        }
    }
}
