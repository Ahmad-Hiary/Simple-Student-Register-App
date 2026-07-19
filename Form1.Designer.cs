namespace Simple_manage_student_page
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDInfo = new System.Windows.Forms.TextBox();
            this.txtNameInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGradeInfo = new System.Windows.Forms.TextBox();
            this.txtPhoneInfo = new System.Windows.Forms.TextBox();
            this.rbFemaleInfo = new System.Windows.Forms.RadioButton();
            this.rbMaleInfo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbbGender = new System.Windows.Forms.Label();
            this.lbbGrade = new System.Windows.Forms.Label();
            this.lbbPhone = new System.Windows.Forms.Label();
            this.lbbEmail = new System.Windows.Forms.Label();
            this.lbbName = new System.Windows.Forms.Label();
            this.lbbId = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // txtIDInfo
            // 
            this.txtIDInfo.BackColor = System.Drawing.Color.Purple;
            this.txtIDInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDInfo.ForeColor = System.Drawing.Color.White;
            this.txtIDInfo.Location = new System.Drawing.Point(94, 48);
            this.txtIDInfo.Name = "txtIDInfo";
            this.txtIDInfo.Size = new System.Drawing.Size(137, 32);
            this.txtIDInfo.TabIndex = 1;
            this.txtIDInfo.TextChanged += new System.EventHandler(this.txtIDInfo_TextChanged);
            this.txtIDInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDInfo_KeyPress);
            this.txtIDInfo.Validating += new System.ComponentModel.CancelEventHandler(this.txtIDInfo_Validating);
            // 
            // txtNameInfo
            // 
            this.txtNameInfo.BackColor = System.Drawing.Color.Purple;
            this.txtNameInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameInfo.ForeColor = System.Drawing.Color.White;
            this.txtNameInfo.Location = new System.Drawing.Point(94, 92);
            this.txtNameInfo.Name = "txtNameInfo";
            this.txtNameInfo.Size = new System.Drawing.Size(183, 32);
            this.txtNameInfo.TabIndex = 3;
            this.txtNameInfo.TextChanged += new System.EventHandler(this.txtNameInfo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // txtEmailInfo
            // 
            this.txtEmailInfo.BackColor = System.Drawing.Color.Purple;
            this.txtEmailInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailInfo.ForeColor = System.Drawing.Color.White;
            this.txtEmailInfo.Location = new System.Drawing.Point(94, 135);
            this.txtEmailInfo.Name = "txtEmailInfo";
            this.txtEmailInfo.Size = new System.Drawing.Size(269, 32);
            this.txtEmailInfo.TabIndex = 5;
            this.txtEmailInfo.TextChanged += new System.EventHandler(this.txtEmailInfo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grade   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGradeInfo);
            this.groupBox1.Controls.Add(this.txtPhoneInfo);
            this.groupBox1.Controls.Add(this.rbFemaleInfo);
            this.groupBox1.Controls.Add(this.rbMaleInfo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmailInfo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNameInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(65, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info :";
            // 
            // txtGradeInfo
            // 
            this.txtGradeInfo.BackColor = System.Drawing.Color.Purple;
            this.txtGradeInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeInfo.ForeColor = System.Drawing.Color.White;
            this.txtGradeInfo.Location = new System.Drawing.Point(477, 90);
            this.txtGradeInfo.Name = "txtGradeInfo";
            this.txtGradeInfo.Size = new System.Drawing.Size(137, 32);
            this.txtGradeInfo.TabIndex = 16;
            this.txtGradeInfo.TextChanged += new System.EventHandler(this.txtGradeInfo_TextChanged);
            this.txtGradeInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradeInfo_KeyPress);
            this.txtGradeInfo.Leave += new System.EventHandler(this.txtGradeInfo_Leave);
            this.txtGradeInfo.Validating += new System.ComponentModel.CancelEventHandler(this.txtGradeInfo_Validating);
            // 
            // txtPhoneInfo
            // 
            this.txtPhoneInfo.BackColor = System.Drawing.Color.Purple;
            this.txtPhoneInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneInfo.ForeColor = System.Drawing.Color.White;
            this.txtPhoneInfo.Location = new System.Drawing.Point(477, 50);
            this.txtPhoneInfo.Name = "txtPhoneInfo";
            this.txtPhoneInfo.Size = new System.Drawing.Size(137, 32);
            this.txtPhoneInfo.TabIndex = 15;
            this.txtPhoneInfo.TextChanged += new System.EventHandler(this.txtPhoneInfo_TextChanged);
            this.txtPhoneInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneInfo_KeyPress);
            this.txtPhoneInfo.Leave += new System.EventHandler(this.txtPhoneInfo_Leave);
            this.txtPhoneInfo.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneInfo_Validating);
            // 
            // rbFemaleInfo
            // 
            this.rbFemaleInfo.AutoSize = true;
            this.rbFemaleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemaleInfo.Location = new System.Drawing.Point(543, 143);
            this.rbFemaleInfo.Name = "rbFemaleInfo";
            this.rbFemaleInfo.Size = new System.Drawing.Size(74, 20);
            this.rbFemaleInfo.TabIndex = 14;
            this.rbFemaleInfo.Text = "Female";
            this.rbFemaleInfo.UseVisualStyleBackColor = true;
            this.rbFemaleInfo.CheckedChanged += new System.EventHandler(this.rbFemaleInfo_CheckedChanged_1);
            // 
            // rbMaleInfo
            // 
            this.rbMaleInfo.AutoSize = true;
            this.rbMaleInfo.Checked = true;
            this.rbMaleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaleInfo.Location = new System.Drawing.Point(479, 142);
            this.rbMaleInfo.Name = "rbMaleInfo";
            this.rbMaleInfo.Size = new System.Drawing.Size(58, 20);
            this.rbMaleInfo.TabIndex = 13;
            this.rbMaleInfo.TabStop = true;
            this.rbMaleInfo.Text = "Male";
            this.rbMaleInfo.UseVisualStyleBackColor = true;
            this.rbMaleInfo.CheckedChanged += new System.EventHandler(this.rbMaleInfo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gender :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbbGender);
            this.groupBox2.Controls.Add(this.lbbGrade);
            this.groupBox2.Controls.Add(this.lbbPhone);
            this.groupBox2.Controls.Add(this.lbbEmail);
            this.groupBox2.Controls.Add(this.lbbName);
            this.groupBox2.Controls.Add(this.lbbId);
            this.groupBox2.Controls.Add(this.lbGender);
            this.groupBox2.Controls.Add(this.lbGrade);
            this.groupBox2.Controls.Add(this.lbPhone);
            this.groupBox2.Controls.Add(this.lbEmail);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Controls.Add(this.lbId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1098, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 666);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Card";
            // 
            // lbbGender
            // 
            this.lbbGender.AutoSize = true;
            this.lbbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbGender.Location = new System.Drawing.Point(106, 555);
            this.lbbGender.Name = "lbbGender";
            this.lbbGender.Size = new System.Drawing.Size(69, 20);
            this.lbbGender.TabIndex = 30;
            this.lbbGender.Text = "Name :";
            // 
            // lbbGrade
            // 
            this.lbbGrade.AutoSize = true;
            this.lbbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbGrade.Location = new System.Drawing.Point(106, 512);
            this.lbbGrade.Name = "lbbGrade";
            this.lbbGrade.Size = new System.Drawing.Size(69, 20);
            this.lbbGrade.TabIndex = 29;
            this.lbbGrade.Text = "Name :";
            // 
            // lbbPhone
            // 
            this.lbbPhone.AutoSize = true;
            this.lbbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbPhone.Location = new System.Drawing.Point(106, 474);
            this.lbbPhone.Name = "lbbPhone";
            this.lbbPhone.Size = new System.Drawing.Size(69, 20);
            this.lbbPhone.TabIndex = 28;
            this.lbbPhone.Text = "Name :";
            // 
            // lbbEmail
            // 
            this.lbbEmail.AutoSize = true;
            this.lbbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbEmail.Location = new System.Drawing.Point(106, 432);
            this.lbbEmail.Name = "lbbEmail";
            this.lbbEmail.Size = new System.Drawing.Size(62, 18);
            this.lbbEmail.TabIndex = 27;
            this.lbbEmail.Text = "Name :";
            // 
            // lbbName
            // 
            this.lbbName.AutoSize = true;
            this.lbbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbName.Location = new System.Drawing.Point(104, 388);
            this.lbbName.Name = "lbbName";
            this.lbbName.Size = new System.Drawing.Size(69, 20);
            this.lbbName.TabIndex = 26;
            this.lbbName.Text = "Name :";
            // 
            // lbbId
            // 
            this.lbbId.AutoSize = true;
            this.lbbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbId.Location = new System.Drawing.Point(175, 339);
            this.lbbId.Name = "lbbId";
            this.lbbId.Size = new System.Drawing.Size(69, 20);
            this.lbbId.TabIndex = 12;
            this.lbbId.Text = "Name :";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(116, 555);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(0, 25);
            this.lbGender.TabIndex = 25;
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.Location = new System.Drawing.Point(116, 508);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(0, 25);
            this.lbGrade.TabIndex = 24;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(116, 470);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(0, 25);
            this.lbPhone.TabIndex = 23;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(116, 428);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 25);
            this.lbEmail.TabIndex = 22;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(116, 384);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 25);
            this.lbName.TabIndex = 21;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(116, 334);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 25);
            this.lbId.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 550);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Gender :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Phone :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Grade  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Email  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(745, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(745, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(744, 182);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 334);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1017, 365);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(55, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 42);
            this.panel1.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(906, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Grade";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(705, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Phone";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(381, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(112, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "ID";
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1500, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Student Managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDInfo;
        private System.Windows.Forms.TextBox txtNameInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbFemaleInfo;
        private System.Windows.Forms.RadioButton rbMaleInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtGradeInfo;
        private System.Windows.Forms.TextBox txtPhoneInfo;
        private System.Windows.Forms.Label lbbGender;
        private System.Windows.Forms.Label lbbGrade;
        private System.Windows.Forms.Label lbbPhone;
        private System.Windows.Forms.Label lbbEmail;
        private System.Windows.Forms.Label lbbName;
        private System.Windows.Forms.Label lbbId;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider ep1;
    }
}

