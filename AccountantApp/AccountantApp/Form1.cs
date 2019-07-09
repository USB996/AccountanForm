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
    }
}
