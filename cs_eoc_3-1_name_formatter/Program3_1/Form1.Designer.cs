namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNameOutput = new System.Windows.Forms.Label();
            this.btnFormat1 = new System.Windows.Forms.Button();
            this.btnFormat2 = new System.Windows.Forms.Button();
            this.btnFormat3 = new System.Windows.Forms.Button();
            this.btnFormat4 = new System.Windows.Forms.Button();
            this.btnFormat5 = new System.Windows.Forms.Button();
            this.btnFormat6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(221, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(221, 39);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtMiddleName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(221, 66);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(221, 92);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(16, 12);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(190, 23);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First name: ";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Location = new System.Drawing.Point(16, 39);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(190, 23);
            this.lblMiddleName.TabIndex = 5;
            this.lblMiddleName.Text = "Middle name:";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(16, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(190, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(16, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Preferred title (Mr., Mrs., Ms., Dr., etc.):";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNameOutput
            // 
            this.lblNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameOutput.Location = new System.Drawing.Point(16, 126);
            this.lblNameOutput.Name = "lblNameOutput";
            this.lblNameOutput.Size = new System.Drawing.Size(315, 23);
            this.lblNameOutput.TabIndex = 8;
            this.lblNameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFormat1
            // 
            this.btnFormat1.Location = new System.Drawing.Point(12, 165);
            this.btnFormat1.Name = "btnFormat1";
            this.btnFormat1.Size = new System.Drawing.Size(75, 23);
            this.btnFormat1.TabIndex = 9;
            this.btnFormat1.Text = "Format 1";
            this.btnFormat1.UseVisualStyleBackColor = true;
            this.btnFormat1.Click += new System.EventHandler(this.btnFormat1_Click);
            // 
            // btnFormat2
            // 
            this.btnFormat2.Location = new System.Drawing.Point(93, 165);
            this.btnFormat2.Name = "btnFormat2";
            this.btnFormat2.Size = new System.Drawing.Size(75, 23);
            this.btnFormat2.TabIndex = 10;
            this.btnFormat2.Text = "Format 2";
            this.btnFormat2.UseVisualStyleBackColor = true;
            this.btnFormat2.Click += new System.EventHandler(this.btnFormat2_Click);
            // 
            // btnFormat3
            // 
            this.btnFormat3.Location = new System.Drawing.Point(174, 165);
            this.btnFormat3.Name = "btnFormat3";
            this.btnFormat3.Size = new System.Drawing.Size(75, 23);
            this.btnFormat3.TabIndex = 11;
            this.btnFormat3.Text = "Format 3";
            this.btnFormat3.UseVisualStyleBackColor = true;
            this.btnFormat3.Click += new System.EventHandler(this.btnFormat3_Click);
            // 
            // btnFormat4
            // 
            this.btnFormat4.Location = new System.Drawing.Point(256, 165);
            this.btnFormat4.Name = "btnFormat4";
            this.btnFormat4.Size = new System.Drawing.Size(75, 23);
            this.btnFormat4.TabIndex = 12;
            this.btnFormat4.Text = "Format 4";
            this.btnFormat4.UseVisualStyleBackColor = true;
            this.btnFormat4.Click += new System.EventHandler(this.btnFormat4_Click);
            // 
            // btnFormat5
            // 
            this.btnFormat5.Location = new System.Drawing.Point(53, 194);
            this.btnFormat5.Name = "btnFormat5";
            this.btnFormat5.Size = new System.Drawing.Size(75, 23);
            this.btnFormat5.TabIndex = 13;
            this.btnFormat5.Text = "Format 5";
            this.btnFormat5.UseVisualStyleBackColor = true;
            this.btnFormat5.Click += new System.EventHandler(this.btnFormat5_Click);
            // 
            // btnFormat6
            // 
            this.btnFormat6.Location = new System.Drawing.Point(210, 194);
            this.btnFormat6.Name = "btnFormat6";
            this.btnFormat6.Size = new System.Drawing.Size(75, 23);
            this.btnFormat6.TabIndex = 14;
            this.btnFormat6.Text = "Format 6";
            this.btnFormat6.UseVisualStyleBackColor = true;
            this.btnFormat6.Click += new System.EventHandler(this.btnFormat6_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 226);
            this.Controls.Add(this.btnFormat6);
            this.Controls.Add(this.btnFormat5);
            this.Controls.Add(this.btnFormat4);
            this.Controls.Add(this.btnFormat3);
            this.Controls.Add(this.btnFormat2);
            this.Controls.Add(this.btnFormat1);
            this.Controls.Add(this.lblNameOutput);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "frmMain";
            this.Text = "Program3_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNameOutput;
        private System.Windows.Forms.Button btnFormat1;
        private System.Windows.Forms.Button btnFormat2;
        private System.Windows.Forms.Button btnFormat3;
        private System.Windows.Forms.Button btnFormat4;
        private System.Windows.Forms.Button btnFormat5;
        private System.Windows.Forms.Button btnFormat6;
    }
}

