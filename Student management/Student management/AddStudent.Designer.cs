namespace Student_management
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSaved = new System.Windows.Forms.Label();
            this.btnAddSt = new System.Windows.Forms.Button();
            this.btnAddInProgress = new System.Windows.Forms.Button();
            this.btnAddFinished = new System.Windows.Forms.Button();
            this.txtInProgress = new System.Windows.Forms.TextBox();
            this.txtfinished = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWrngID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWrngID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblSaved);
            this.groupBox1.Controls.Add(this.btnAddSt);
            this.groupBox1.Controls.Add(this.btnAddInProgress);
            this.groupBox1.Controls.Add(this.btnAddFinished);
            this.groupBox1.Controls.Add(this.txtInProgress);
            this.groupBox1.Controls.Add(this.txtfinished);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(339, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "*Type \"_\" if no courses In Progress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(339, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "*Type \"_\"  if no Finished courses";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaved.ForeColor = System.Drawing.Color.Red;
            this.lblSaved.Location = new System.Drawing.Point(323, 103);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(0, 20);
            this.lblSaved.TabIndex = 14;
            // 
            // btnAddSt
            // 
            this.btnAddSt.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSt.Image")));
            this.btnAddSt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSt.Location = new System.Drawing.Point(202, 253);
            this.btnAddSt.Name = "btnAddSt";
            this.btnAddSt.Size = new System.Drawing.Size(106, 23);
            this.btnAddSt.TabIndex = 3;
            this.btnAddSt.Text = "Add Student";
            this.btnAddSt.UseVisualStyleBackColor = true;
            this.btnAddSt.Click += new System.EventHandler(this.btnAddSt_Click);
            // 
            // btnAddInProgress
            // 
            this.btnAddInProgress.Image = ((System.Drawing.Image)(resources.GetObject("btnAddInProgress.Image")));
            this.btnAddInProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddInProgress.Location = new System.Drawing.Point(259, 206);
            this.btnAddInProgress.Name = "btnAddInProgress";
            this.btnAddInProgress.Size = new System.Drawing.Size(64, 23);
            this.btnAddInProgress.TabIndex = 13;
            this.btnAddInProgress.Text = "  Add";
            this.btnAddInProgress.UseVisualStyleBackColor = true;
            this.btnAddInProgress.Click += new System.EventHandler(this.btnAddInProgress_Click);
            // 
            // btnAddFinished
            // 
            this.btnAddFinished.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFinished.Image")));
            this.btnAddFinished.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFinished.Location = new System.Drawing.Point(258, 175);
            this.btnAddFinished.Name = "btnAddFinished";
            this.btnAddFinished.Size = new System.Drawing.Size(65, 23);
            this.btnAddFinished.TabIndex = 12;
            this.btnAddFinished.Text = "  Add";
            this.btnAddFinished.UseVisualStyleBackColor = true;
            this.btnAddFinished.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInProgress
            // 
            this.txtInProgress.Location = new System.Drawing.Point(149, 208);
            this.txtInProgress.Name = "txtInProgress";
            this.txtInProgress.Size = new System.Drawing.Size(100, 20);
            this.txtInProgress.TabIndex = 11;
            // 
            // txtfinished
            // 
            this.txtfinished.Location = new System.Drawing.Point(149, 177);
            this.txtfinished.Name = "txtfinished";
            this.txtfinished.Size = new System.Drawing.Size(100, 20);
            this.txtfinished.TabIndex = 10;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(149, 140);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(149, 103);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(149, 67);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Courses in progress :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Finished courses :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Academic year :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(109, 306);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "  Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(463, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "  Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWrngID
            // 
            this.lblWrngID.AutoSize = true;
            this.lblWrngID.ForeColor = System.Drawing.Color.Red;
            this.lblWrngID.Location = new System.Drawing.Point(269, 74);
            this.lblWrngID.Name = "lblWrngID";
            this.lblWrngID.Size = new System.Drawing.Size(0, 13);
            this.lblWrngID.TabIndex = 16;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 343);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddSt;
        private System.Windows.Forms.Button btnAddInProgress;
        private System.Windows.Forms.Button btnAddFinished;
        private System.Windows.Forms.TextBox txtInProgress;
        private System.Windows.Forms.TextBox txtfinished;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWrngID;
    }
}