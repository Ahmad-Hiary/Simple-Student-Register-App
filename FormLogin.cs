using Simple_manage_student_page.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_manage_student_page
{
    public partial class FormLogin : Form
    {
        // Path to the credentials file (adjust as needed)
        private static readonly string CredentialsFilePath =
            Path.Combine(Application.StartupPath, "credentials.txt");
        private const string Separator = "#//#";

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

        bool isPasswordVisible = true;
        private void pbEye_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                pbEye.Image = Resources.hiddenEye;
                isPasswordVisible = false;
                txtPassWord.UseSystemPasswordChar = true;
            }
            else
            {
                pbEye.Image = Resources.eye;
                isPasswordVisible = true;
                txtPassWord.UseSystemPasswordChar = false;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pbEye.Image = Resources.eye;
            txtPassWord.UseSystemPasswordChar = false;
            label4.Visible = false;
        }

        byte FailCounter = 0;

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassWord.Text) || string.IsNullOrEmpty(txtUserName.Text))
                return;

           

            if (!CheckLoginInfo())
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                FailCounter++;

                if(FailCounter==3)
                {
                    timer1.Enabled =true;
                    button1.Enabled = false;

                    FailCounter = 0;
                }
                return;
            }

            Form1 frm = new Form1();
            frm.ShowDialog();

            txtPassWord.Clear();
            txtUserName.Clear();

        }

        private bool CheckLoginInfo()
        {
            if (!File.Exists(CredentialsFilePath))
            {
                MessageBox.Show($"Credentials file not found: {CredentialsFilePath}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string enteredUser = txtUserName.Text.Trim();
            string enteredPass = txtPassWord.Text;

            var lines = File.ReadAllLines(CredentialsFilePath);

            foreach (var rawLine in lines)
            {
                var line = rawLine.Trim();
                if (string.IsNullOrEmpty(line))
                    continue;

                var parts = line.Split(new[] { Separator }, StringSplitOptions.None);
                if (parts.Length != 2)
                    continue;

                string storedUser = parts[0].Trim();
                string storedPass = parts[1].Trim();

                if (storedUser == enteredUser && storedPass == enteredPass)
                {
                    return true;
                }
            }

            return false;
        }

        private byte counter = 120;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label4.Visible = true;
            label4.Text = "Try Again in " + counter.ToString() + " Second";

            if (counter==0)
            { 
                label4.Text = "     Try Now !";
                timer1.Enabled = false;
                button1.Enabled = true;

                return;
            }
            counter--;
            
        }
    }
}