namespace Student_management
{
    partial class StudentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenu));
            this.grpChoices = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.radYourCourses = new System.Windows.Forms.RadioButton();
            this.radRegister = new System.Windows.Forms.RadioButton();
            this.radDetails = new System.Windows.Forms.RadioButton();
            this.radView = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLblContact = new System.Windows.Forms.LinkLabel();
            this.grpChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChoices
            // 
            this.grpChoices.BackColor = System.Drawing.SystemColors.Control;
            this.grpChoices.Controls.Add(this.label1);
            this.grpChoices.Controls.Add(this.radEdit);
            this.grpChoices.Controls.Add(this.radYourCourses);
            this.grpChoices.Controls.Add(this.radRegister);
            this.grpChoices.Controls.Add(this.radDetails);
            this.grpChoices.Controls.Add(this.radView);
            this.grpChoices.Controls.Add(this.button2);
            this.grpChoices.Controls.Add(this.button1);
            this.grpChoices.Location = new System.Drawing.Point(112, 12);
            this.grpChoices.Name = "grpChoices";
            this.grpChoices.Size = new System.Drawing.Size(330, 302);
            this.grpChoices.TabIndex = 0;
            this.grpChoices.TabStop = false;
            this.grpChoices.Text = "Choose an option ";
            this.grpChoices.Enter += new System.EventHandler(this.grpChoices_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(91, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.Location = new System.Drawing.Point(41, 213);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(90, 17);
            this.radEdit.TabIndex = 12;
            this.radEdit.TabStop = true;
            this.radEdit.Text = "Edit your data";
            this.radEdit.UseVisualStyleBackColor = true;
            // 
            // radYourCourses
            // 
            this.radYourCourses.AutoSize = true;
            this.radYourCourses.Location = new System.Drawing.Point(41, 166);
            this.radYourCourses.Name = "radYourCourses";
            this.radYourCourses.Size = new System.Drawing.Size(111, 17);
            this.radYourCourses.TabIndex = 11;
            this.radYourCourses.TabStop = true;
            this.radYourCourses.Text = "View your courses";
            this.radYourCourses.UseVisualStyleBackColor = true;
            // 
            // radRegister
            // 
            this.radRegister.AutoSize = true;
            this.radRegister.Location = new System.Drawing.Point(41, 127);
            this.radRegister.Name = "radRegister";
            this.radRegister.Size = new System.Drawing.Size(123, 17);
            this.radRegister.TabIndex = 10;
            this.radRegister.TabStop = true;
            this.radRegister.Text = "Register for a course";
            this.radRegister.UseVisualStyleBackColor = true;
            this.radRegister.CheckedChanged += new System.EventHandler(this.radRegister_CheckedChanged);
            // 
            // radDetails
            // 
            this.radDetails.AutoSize = true;
            this.radDetails.Location = new System.Drawing.Point(41, 83);
            this.radDetails.Name = "radDetails";
            this.radDetails.Size = new System.Drawing.Size(167, 17);
            this.radDetails.TabIndex = 9;
            this.radDetails.TabStop = true;
            this.radDetails.Text = "View detials of specific course";
            this.radDetails.UseVisualStyleBackColor = true;
            this.radDetails.CheckedChanged += new System.EventHandler(this.radDetails_CheckedChanged);
            // 
            // radView
            // 
            this.radView.AutoSize = true;
            this.radView.Location = new System.Drawing.Point(41, 42);
            this.radView.Name = "radView";
            this.radView.Size = new System.Drawing.Size(168, 17);
            this.radView.TabIndex = 8;
            this.radView.TabStop = true;
            this.radView.Text = "View list of all available course";
            this.radView.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(175, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(56, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "  Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLblContact
            // 
            this.linkLblContact.AutoSize = true;
            this.linkLblContact.Location = new System.Drawing.Point(498, 319);
            this.linkLblContact.Name = "linkLblContact";
            this.linkLblContact.Size = new System.Drawing.Size(55, 13);
            this.linkLblContact.TabIndex = 1;
            this.linkLblContact.TabStop = true;
            this.linkLblContact.Text = "Feedback";
            this.linkLblContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblContact_LinkClicked);
            // 
            // StudentMenu
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(557, 337);
            this.Controls.Add(this.linkLblContact);
            this.Controls.Add(this.grpChoices);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.grpChoices.ResumeLayout(false);
            this.grpChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChoices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radDetails;
        private System.Windows.Forms.RadioButton radView;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.RadioButton radYourCourses;
        private System.Windows.Forms.RadioButton radRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLblContact;
    }
}