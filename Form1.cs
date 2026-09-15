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



        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Email", 250);
            listView1.Columns.Add("Phone", 150);
            listView1.Columns.Add("Gender", 80);
            listView1.Columns.Add("Year", 85); 
            listView1.Columns.Add("Grade", 80);
            listView1.HeaderStyle = ColumnHeaderStyle.None;
        }


        bool CheckAddRecordRules()
        {
            if (string.IsNullOrWhiteSpace(txtIDInfo.Text) ||
       string.IsNullOrWhiteSpace(txtNameInfo.Text) ||
       string.IsNullOrWhiteSpace(txtEmailInfo.Text) ||
       string.IsNullOrWhiteSpace(txtPhoneInfo.Text) ||
       string.IsNullOrWhiteSpace(txtYear.Text) ||
       string.IsNullOrWhiteSpace(txtGradeInfo.Text))
            {
                return false;
            }

            return true;
        }
        private void AddPicture_Click(object sender, EventArgs e)
        {
            if (CheckAddRecordRules())
                return;

            ListViewItem Item = new ListViewItem(txtIDInfo.Text.Trim());

            

            Item.SubItems.Add(txtNameInfo.Text);

            Item.SubItems.Add(txtEmailInfo.Text);

            Item.SubItems.Add(txtPhoneInfo.Text);

            if(rbFemaleInfo.Checked)
                Item.SubItems.Add("Female");
            else
                Item.SubItems.Add("Male");

            Item.SubItems.Add(txtYear.Text);

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
            txtYear.Clear();


            rbMaleInfo.Checked = true;

        }
       
        private void DeletePicture_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
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
            if (txtIDInfo.Text.Length!=5)
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
                ep1.SetError(txtGradeInfo, "");
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
            ep1.SetError(txtGradeInfo, "");
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


        private ListViewItem selectedItemForEdit = null;
        private void EditPicture_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
                return;

            selectedItemForEdit = listView1.SelectedItems[0];


            txtIDInfo.Text = selectedItemForEdit.Text;
            txtNameInfo.Text = selectedItemForEdit.SubItems[1].Text;
            txtEmailInfo.Text = selectedItemForEdit.SubItems[2].Text;
            txtPhoneInfo.Text = selectedItemForEdit.SubItems[3].Text;
            rbFemaleInfo.Checked = selectedItemForEdit.SubItems[3].Text == "Female" ? true : false;
            txtYear.Text = selectedItemForEdit.SubItems[5].Text;
            txtGradeInfo.Text = selectedItemForEdit.SubItems[6].Text.TrimEnd('%');

            listView1.Items.Remove(listView1.SelectedItems[0]);

        }

        
        private void listView1_MouseDoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem selectedItem = listView1.SelectedItems[0];

            FormStudentCard card = new FormStudentCard();
            card.SetStudentInfo(
                selectedItem.Text,
                selectedItem.SubItems[1].Text,
                selectedItem.SubItems[2].Text,
                selectedItem.SubItems[3].Text,
                selectedItem.SubItems[4].Text,
                selectedItem.SubItems[5].Text,
                selectedItem.SubItems[6].Text
            );
            card.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }
}
