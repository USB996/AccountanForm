using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace AccountantApp
{
    public partial class Register_form : Form
    {
            List<User> users = new List<User>();
            


        public Register_form()
        {
            InitializeComponent();
            
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

            addToJson();

        }

        public void addToJson()
        {
            PasswordValidation();

            users.Add(new User()
            {
                FirstName = Name_bx.Text,
                LastName = Lst_nm_bx.Text,
                ID = ID_Bx.Text,
                UserName = usrNm_bx.Text,
                Password = Pswrd_bx.Text,
                RepeatPassword = Rpt_pswrd_bx.Text

            });

            string json = JsonConvert.SerializeObject(users);
            
            
            File.AppendAllLines(@"UsersData.txt", new string[] { json });
            if (paswrd_mach_label.Visible==true)
            {

            }
            else
            {
                Name_bx.Text = "";
                Lst_nm_bx.Text = "";
                ID_Bx.Text = "";
                Pswrd_bx.Text = "";
                Rpt_pswrd_bx.Text = "";
                usrNm_bx.Text = "";
                MessageBox.Show("Succesfully Registered");
                    
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
