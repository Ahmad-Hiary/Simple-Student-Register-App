using Simple_manage_student_page.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_manage_student_page
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textPassWord_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassWord.Text))
                pbEye.Visible = false;
            else
                pbEye.Visible = true;
        }


        bool isEye = true;
        private void pbEye_Click(object sender, EventArgs e)
        {
            if(isEye)
            {
                pbEye.Image = Resources.hiddenEye;
                isEye = false;
                txtPassWord.UseSystemPasswordChar = true;

            }
            else
            {
                pbEye.Image = Resources.eye;
                isEye = true;

                txtPassWord.UseSystemPasswordChar = false;
            }



        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pbEye.Image = Resources.eye;
            txtPassWord.UseSystemPasswordChar = false;
        }
    }
}
