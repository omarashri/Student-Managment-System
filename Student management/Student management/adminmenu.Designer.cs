namespace Student_management
{
    partial class adminmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminmenu));
            this.radAddStudent = new System.Windows.Forms.RadioButton();
            this.radAddcourse = new System.Windows.Forms.RadioButton();
            this.radPre = new System.Windows.Forms.RadioButton();
            this.radViewst = new System.Windows.Forms.RadioButton();
            this.radViewCrs = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCnt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radAddStudent
            // 
            this.radAddStudent.AutoSize = true;
            this.radAddStudent.Location = new System.Drawing.Point(39, 29);
            this.radAddStudent.Name = "radAddStudent";
            this.radAddStudent.Size = new System.Drawing.Size(109, 17);
            this.radAddStudent.TabIndex = 0;
            this.radAddStudent.Text = "Add New Student";
            this.radAddStudent.UseVisualStyleBackColor = true;
            this.radAddStudent.CheckedChanged += new System.EventHandler(this.radAddStudent_CheckedChanged);
            // 
            // radAddcourse
            // 
            this.radAddcourse.AutoSize = true;
            this.radAddcourse.Location = new System.Drawing.Point(39, 61);
            this.radAddcourse.Name = "radAddcourse";
            this.radAddcourse.Size = new System.Drawing.Size(103, 17);
            this.radAddcourse.TabIndex = 1;
            this.radAddcourse.Text = "Add new Course";
            this.radAddcourse.UseVisualStyleBackColor = true;
            this.radAddcourse.CheckedChanged += new System.EventHandler(this.radAddcourse_CheckedChanged);
            // 
            // radPre
            // 
            this.radPre.AutoSize = true;
            this.radPre.Location = new System.Drawing.Point(39, 96);
            this.radPre.Name = "radPre";
            this.radPre.Size = new System.Drawing.Size(143, 17);
            this.radPre.TabIndex = 2;
            this.radPre.Text = "Enter Course prerequisite";
            this.radPre.UseVisualStyleBackColor = true;
            this.radPre.CheckedChanged += new System.EventHandler(this.radPre_CheckedChanged);
            // 
            // radViewst
            // 
            this.radViewst.AutoSize = true;
            this.radViewst.Location = new System.Drawing.Point(39, 134);
            this.radViewst.Name = "radViewst";
            this.radViewst.Size = new System.Drawing.Size(229, 17);
            this.radViewst.TabIndex = 3;
            this.radViewst.Text = "View List of all students in a specific course";
            this.radViewst.UseVisualStyleBackColor = true;
            this.radViewst.CheckedChanged += new System.EventHandler(this.radViewst_CheckedChanged);
            // 
            // radViewCrs
            // 
            this.radViewCrs.AutoSize = true;
            this.radViewCrs.Location = new System.Drawing.Point(39, 172);
            this.radViewCrs.Name = "radViewCrs";
            this.radViewCrs.Size = new System.Drawing.Size(340, 17);
            this.radViewCrs.TabIndex = 4;
            this.radViewCrs.Text = "View List of all courses (Finished - Progressed) of a specific student";
            this.radViewCrs.UseVisualStyleBackColor = true;
            this.radViewCrs.CheckedChanged += new System.EventHandler(this.radViewCrs_CheckedChanged);
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.Location = new System.Drawing.Point(39, 207);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(115, 17);
            this.radEdit.TabIndex = 5;
            this.radEdit.Text = "Edit all course data";
            this.radEdit.UseVisualStyleBackColor = true;
            this.radEdit.CheckedChanged += new System.EventHandler(this.radEdit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnCnt);
            this.groupBox1.Controls.Add(this.radAddcourse);
            this.groupBox1.Controls.Add(this.radEdit);
            this.groupBox1.Controls.Add(this.radAddStudent);
            this.groupBox1.Controls.Add(this.radViewCrs);
            this.groupBox1.Controls.Add(this.radPre);
            this.groupBox1.Controls.Add(this.radViewst);
            this.groupBox1.Location = new System.Drawing.Point(79, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 286);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCnt
            // 
            this.btnCnt.Location = new System.Drawing.Point(130, 240);
            this.btnCnt.Name = "btnCnt";
            this.btnCnt.Size = new System.Drawing.Size(114, 31);
            this.btnCnt.TabIndex = 6;
            this.btnCnt.Text = "&Continue";
            this.btnCnt.UseVisualStyleBackColor = true;
            this.btnCnt.Click += new System.EventHandler(this.btnCnt_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(389, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 26);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = " &Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // adminmenu
            // 
            this.AcceptButton = this.btnCnt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 342);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminmenu";
            this.Text = "adminmenu";
            this.Load += new System.EventHandler(this.adminmenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radAddStudent;
        private System.Windows.Forms.RadioButton radAddcourse;
        private System.Windows.Forms.RadioButton radPre;
        private System.Windows.Forms.RadioButton radViewst;
        private System.Windows.Forms.RadioButton radViewCrs;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCnt;
        private System.Windows.Forms.Button btnExit;
    }
}