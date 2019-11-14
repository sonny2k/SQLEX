namespace FamilyTree
{
    partial class AddNewMemberForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbtnLiving = new System.Windows.Forms.RadioButton();
            this.rbtnDeceased = new System.Windows.Forms.RadioButton();
            this.rbtnUnknown = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBirthplace = new System.Windows.Forms.Label();
            this.txtBirthplace = new System.Windows.Forms.TextBox();
            this.lblCurrentliving = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblFather = new System.Windows.Forms.Label();
            this.lblMother = new System.Windows.Forms.Label();
            this.lblSpouse = new System.Windows.Forms.Label();
            this.txtCurrentliving = new System.Windows.Forms.TextBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.cbbFather = new System.Windows.Forms.ComboBox();
            this.cbbMother = new System.Windows.Forms.ComboBox();
            this.cbbSpouse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Fullname";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(88, 9);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(220, 20);
            this.txtFullname.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 57);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(80, 55);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 3;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(144, 55);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 4;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(12, 95);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 5;
            this.lblBirthday.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // rbtnLiving
            // 
            this.rbtnLiving.AutoSize = true;
            this.rbtnLiving.Location = new System.Drawing.Point(80, 145);
            this.rbtnLiving.Name = "rbtnLiving";
            this.rbtnLiving.Size = new System.Drawing.Size(53, 17);
            this.rbtnLiving.TabIndex = 7;
            this.rbtnLiving.TabStop = true;
            this.rbtnLiving.Text = "Living";
            this.rbtnLiving.UseVisualStyleBackColor = true;
            // 
            // rbtnDeceased
            // 
            this.rbtnDeceased.AutoSize = true;
            this.rbtnDeceased.Location = new System.Drawing.Point(144, 145);
            this.rbtnDeceased.Name = "rbtnDeceased";
            this.rbtnDeceased.Size = new System.Drawing.Size(74, 17);
            this.rbtnDeceased.TabIndex = 8;
            this.rbtnDeceased.TabStop = true;
            this.rbtnDeceased.Text = "Deceased";
            this.rbtnDeceased.UseVisualStyleBackColor = true;
            // 
            // rbtnUnknown
            // 
            this.rbtnUnknown.AutoSize = true;
            this.rbtnUnknown.Location = new System.Drawing.Point(237, 145);
            this.rbtnUnknown.Name = "rbtnUnknown";
            this.rbtnUnknown.Size = new System.Drawing.Size(71, 17);
            this.rbtnUnknown.TabIndex = 9;
            this.rbtnUnknown.TabStop = true;
            this.rbtnUnknown.Text = "Unknown";
            this.rbtnUnknown.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 149);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // lblBirthplace
            // 
            this.lblBirthplace.AutoSize = true;
            this.lblBirthplace.Location = new System.Drawing.Point(12, 182);
            this.lblBirthplace.Name = "lblBirthplace";
            this.lblBirthplace.Size = new System.Drawing.Size(54, 13);
            this.lblBirthplace.TabIndex = 11;
            this.lblBirthplace.Text = "Birthplace";
            // 
            // txtBirthplace
            // 
            this.txtBirthplace.Location = new System.Drawing.Point(88, 179);
            this.txtBirthplace.Name = "txtBirthplace";
            this.txtBirthplace.Size = new System.Drawing.Size(220, 20);
            this.txtBirthplace.TabIndex = 12;
            // 
            // lblCurrentliving
            // 
            this.lblCurrentliving.AutoSize = true;
            this.lblCurrentliving.Location = new System.Drawing.Point(13, 225);
            this.lblCurrentliving.Name = "lblCurrentliving";
            this.lblCurrentliving.Size = new System.Drawing.Size(68, 13);
            this.lblCurrentliving.TabIndex = 13;
            this.lblCurrentliving.Text = "Current living";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(12, 259);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(62, 13);
            this.lblOccupation.TabIndex = 14;
            this.lblOccupation.Text = "Occupation";
            // 
            // lblFather
            // 
            this.lblFather.AutoSize = true;
            this.lblFather.Location = new System.Drawing.Point(12, 295);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(37, 13);
            this.lblFather.TabIndex = 15;
            this.lblFather.Text = "Father";
            // 
            // lblMother
            // 
            this.lblMother.AutoSize = true;
            this.lblMother.Location = new System.Drawing.Point(12, 325);
            this.lblMother.Name = "lblMother";
            this.lblMother.Size = new System.Drawing.Size(40, 13);
            this.lblMother.TabIndex = 16;
            this.lblMother.Text = "Mother";
            // 
            // lblSpouse
            // 
            this.lblSpouse.AutoSize = true;
            this.lblSpouse.Location = new System.Drawing.Point(12, 356);
            this.lblSpouse.Name = "lblSpouse";
            this.lblSpouse.Size = new System.Drawing.Size(43, 13);
            this.lblSpouse.TabIndex = 17;
            this.lblSpouse.Text = "Spouse";
            // 
            // txtCurrentliving
            // 
            this.txtCurrentliving.Location = new System.Drawing.Point(88, 225);
            this.txtCurrentliving.Name = "txtCurrentliving";
            this.txtCurrentliving.Size = new System.Drawing.Size(220, 20);
            this.txtCurrentliving.TabIndex = 18;
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(88, 259);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(220, 20);
            this.txtOccupation.TabIndex = 19;
            // 
            // cbbFather
            // 
            this.cbbFather.FormattingEnabled = true;
            this.cbbFather.Location = new System.Drawing.Point(88, 292);
            this.cbbFather.Name = "cbbFather";
            this.cbbFather.Size = new System.Drawing.Size(220, 21);
            this.cbbFather.TabIndex = 20;
            // 
            // cbbMother
            // 
            this.cbbMother.FormattingEnabled = true;
            this.cbbMother.Location = new System.Drawing.Point(88, 322);
            this.cbbMother.Name = "cbbMother";
            this.cbbMother.Size = new System.Drawing.Size(220, 21);
            this.cbbMother.TabIndex = 21;
            // 
            // cbbSpouse
            // 
            this.cbbSpouse.FormattingEnabled = true;
            this.cbbSpouse.Location = new System.Drawing.Point(88, 353);
            this.cbbSpouse.Name = "cbbSpouse";
            this.cbbSpouse.Size = new System.Drawing.Size(220, 21);
            this.cbbSpouse.TabIndex = 22;
            // 
            // AddNewMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 387);
            this.Controls.Add(this.cbbSpouse);
            this.Controls.Add(this.cbbMother);
            this.Controls.Add(this.cbbFather);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.txtCurrentliving);
            this.Controls.Add(this.lblSpouse);
            this.Controls.Add(this.lblMother);
            this.Controls.Add(this.lblFather);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.lblCurrentliving);
            this.Controls.Add(this.txtBirthplace);
            this.Controls.Add(this.lblBirthplace);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rbtnUnknown);
            this.Controls.Add(this.rbtnDeceased);
            this.Controls.Add(this.rbtnLiving);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.lblName);
            this.Name = "AddNewMemberForm";
            this.Text = "Input personal information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbtnLiving;
        private System.Windows.Forms.RadioButton rbtnDeceased;
        private System.Windows.Forms.RadioButton rbtnUnknown;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBirthplace;
        private System.Windows.Forms.TextBox txtBirthplace;
        private System.Windows.Forms.Label lblCurrentliving;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblFather;
        private System.Windows.Forms.Label lblMother;
        private System.Windows.Forms.Label lblSpouse;
        private System.Windows.Forms.TextBox txtCurrentliving;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.ComboBox cbbFather;
        private System.Windows.Forms.ComboBox cbbMother;
        private System.Windows.Forms.ComboBox cbbSpouse;
    }
}