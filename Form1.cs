using Simple_manage_student_page.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_manage_student_page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void txtIDInfo_TextChanged(object sender, EventArgs e)
        {
            lbbId.Text = txtIDInfo.Text;
        }

        private void txtNameInfo_TextChanged(object sender, EventArgs e)
        {
            lbbName.Text = txtNameInfo.Text;
        }

        private void txtEmailInfo_TextChanged(object sender, EventArgs e)
        {
            lbbEmail.Text = txtEmailInfo.Text;
        }

        private void txtPhoneInfo_TextChanged(object sender, EventArgs e)
        {
            lbbPhone.Text = txtPhoneInfo.Text;
        }

        private void txtGradeInfo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGradeInfo.Text))
            {
                lbbGrade.Text = "";

            }
            else
            {
                lbbGrade.Text = txtGradeInfo.Text+"%";
            }

        }

        private void rbMaleInfo_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rbMaleInfo.Checked)
            {
                lbbGender.Text = rbMaleInfo.Checked ? "Male" : "Female";
                lbbGender.Text = "Male";
                pictureBox1.Image = Properties.Resources.Maleee;
            }
        }

        private void rbFemaleInfo_CheckedChanged(object sender, EventArgs e)
        {
            lbbGender.Text = rbFemaleInfo.Checked ? "Female" : "Male";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbbId.Text = "";
            lbbName.Text = "";
            lbbEmail.Text = "";
            lbbPhone.Text = "";
            lbbGrade.Text = "";
            lbbGender.Text = "Male";

            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Email", 250);
            listView1.Columns.Add("Phone", 150);
            listView1.Columns.Add("Grade", 80);
            listView1.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDInfo.Text) || string.IsNullOrEmpty(txtNameInfo.Text))
                return;

            ListViewItem Item = new ListViewItem(txtIDInfo.Text.Trim());

            

            Item.SubItems.Add(txtNameInfo.Text);
            Item.SubItems.Add(txtEmailInfo.Text);
            Item.SubItems.Add(txtPhoneInfo.Text);
            Item.SubItems.Add(txtGradeInfo.Text+"%");
            listView1.Items.Add(Item);

            Reset();



        }

        void Reset()
        {
            txtIDInfo.Clear();
            txtNameInfo.Clear();
            txtGradeInfo.Clear();
            txtEmailInfo.Clear();
            txtPhoneInfo.Clear();
            lbbGrade.Text = " ";
            lbbGender.Text = "Male";


            rbMaleInfo.Checked = true;

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void rbFemaleInfo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbFemaleInfo.Checked)
            {
                lbbGender.Text = "Female";
                lbbGender.Text = "Female";
                pictureBox1.Image = Properties.Resources.Female;
            }
        }


        private void txtIDInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || txtIDInfo.Text.Length>4)
            {
                txtIDInfo.Focus();
                e.Handled = true;
                ep1.SetError(txtIDInfo, "Must Contains 5 Digits");

            }
            else
            {
                ep1.SetError(txtIDInfo, "");
            }
        }
        private void txtIDInfo_Validating(object sender, CancelEventArgs e)
        {
            if (txtIDInfo.Text.Length<4)
            {
                txtIDInfo.Focus();
                ep1.SetError(txtIDInfo, "ID Digits Must Count 5 Digits");

            }
            else
            {
                ep1.SetError(txtIDInfo, "");
            }
        }



        private void txtGradeInfo_Validating(object sender, CancelEventArgs e)
        {
            if(int.TryParse(txtGradeInfo.Text,out int grade))
            {
                if (grade > 100||grade <0)
                {
                    txtGradeInfo.Focus();

                    ep1.SetError(txtGradeInfo, "Grade Must Be between 0 and 100 !");
                }
            }
            else
            {
                txtGradeInfo.Focus();
                ep1.SetError(txtPhoneInfo, "");
            }
            

        }
        private void txtGradeInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtGradeInfo.Focus();
                e.Handled = true;
                ep1.SetError(txtGradeInfo, "Must Contains Digits !");
            }

            if(txtGradeInfo.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                ep1.SetError(txtGradeInfo, "Grade Must Be between 0 and 100 !");
            }
            ep1.SetError(txtPhoneInfo, "");
        }


        private void txtPhoneInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtPhoneInfo.Focus();
                e.Handled = true;
                ep1.SetError(txtPhoneInfo, "It Must contains digits");

            }

            if (txtPhoneInfo.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            ep1.SetError(txtPhoneInfo, "");
        }
        private void txtPhoneInfo_Validating(object sender, CancelEventArgs e)
               {
                   if (txtPhoneInfo.Text.Length > 10 || txtPhoneInfo.Text.Length < 10)
                   {
                       txtPhoneInfo.Focus();
        
                       ep1.SetError(txtPhoneInfo, "Must be 10 Digits !");
        
                   }
                   else
                   {
                       ep1.SetError(txtPhoneInfo, "");
                   }
        
                   
               }
        private void txtPhoneInfo_Leave(object sender, EventArgs e)
        {
            ep1.SetError(txtPhoneInfo, "");
        }

        private void txtGradeInfo_Leave(object sender, EventArgs e)
        {
            ep1.SetError(txtGradeInfo, "");
        }
    }
}
