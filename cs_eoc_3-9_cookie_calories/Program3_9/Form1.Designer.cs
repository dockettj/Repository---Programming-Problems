namespace Program3_9
{
    partial class frmCookieCalories
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
            this.lblCookiesAte = new System.Windows.Forms.Label();
            this.txtCookiesAte = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCookiesAte
            // 
            this.lblCookiesAte.AutoSize = true;
            this.lblCookiesAte.Location = new System.Drawing.Point(13, 13);
            this.lblCookiesAte.Name = "lblCookiesAte";
            this.lblCookiesAte.Size = new System.Drawing.Size(117, 13);
            this.lblCookiesAte.TabIndex = 0;
            this.lblCookiesAte.Text = "Number of cookies ate:";
            // 
            // txtCookiesAte
            // 
            this.txtCookiesAte.Location = new System.Drawing.Point(128, 13);
            this.txtCookiesAte.Name = "txtCookiesAte";
            this.txtCookiesAte.Size = new System.Drawing.Size(100, 20);
            this.txtCookiesAte.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(234, 11);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(13, 43);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(296, 23);
            this.lblOutput.TabIndex = 3;
            // 
            // frmCookieCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 80);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCookiesAte);
            this.Controls.Add(this.lblCookiesAte);
            this.Name = "frmCookieCalories";
            this.Text = "Program3_9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCookiesAte;
        private System.Windows.Forms.TextBox txtCookiesAte;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOutput;
    }
}

