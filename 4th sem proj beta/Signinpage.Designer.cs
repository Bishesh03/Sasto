
namespace _4th_sem_proj_beta
{
    partial class Signinpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signinpage));
            this.signupbutton = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.loginpic = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelsignupemail = new System.Windows.Forms.Label();
            this.labelsignuppwd = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelsignupName = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelsignupphone = new System.Windows.Forms.Label();
            this.labelsignup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginpic)).BeginInit();
            this.SuspendLayout();
            // 
            // signupbutton
            // 
            this.signupbutton.BackColor = System.Drawing.Color.Gold;
            this.signupbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbutton.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.Color.White;
            this.signupbutton.Location = new System.Drawing.Point(145, 507);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(174, 51);
            this.signupbutton.TabIndex = 15;
            this.signupbutton.Text = "Sign Up";
            this.signupbutton.UseVisualStyleBackColor = false;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            this.signupbutton.Enter += new System.EventHandler(this.signupbutton_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(75, 325);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(334, 37);
            this.txtPassword.TabIndex = 14;
            // 
            // loginpic
            // 
            this.loginpic.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginpic.Image = ((System.Drawing.Image)(resources.GetObject("loginpic.Image")));
            this.loginpic.Location = new System.Drawing.Point(477, 0);
            this.loginpic.Name = "loginpic";
            this.loginpic.Size = new System.Drawing.Size(491, 675);
            this.loginpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginpic.TabIndex = 13;
            this.loginpic.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(75, 232);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 37);
            this.txtEmail.TabIndex = 12;
            // 
            // labelsignupemail
            // 
            this.labelsignupemail.AutoSize = true;
            this.labelsignupemail.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsignupemail.Location = new System.Drawing.Point(70, 204);
            this.labelsignupemail.Name = "labelsignupemail";
            this.labelsignupemail.Size = new System.Drawing.Size(59, 25);
            this.labelsignupemail.TabIndex = 11;
            this.labelsignupemail.Text = "Email";
            // 
            // labelsignuppwd
            // 
            this.labelsignuppwd.AutoSize = true;
            this.labelsignuppwd.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsignuppwd.Location = new System.Drawing.Point(70, 297);
            this.labelsignuppwd.Name = "labelsignuppwd";
            this.labelsignuppwd.Size = new System.Drawing.Size(97, 25);
            this.labelsignuppwd.TabIndex = 10;
            this.labelsignuppwd.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(75, 144);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 37);
            this.txtName.TabIndex = 18;
            this.txtName.TextChanged += new System.EventHandler(this.textBoxsignupname_TextChanged);
            // 
            // labelsignupName
            // 
            this.labelsignupName.AutoSize = true;
            this.labelsignupName.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsignupName.Location = new System.Drawing.Point(70, 116);
            this.labelsignupName.Name = "labelsignupName";
            this.labelsignupName.Size = new System.Drawing.Size(64, 25);
            this.labelsignupName.TabIndex = 17;
            this.labelsignupName.Text = "Name";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(75, 417);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(334, 37);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // labelsignupphone
            // 
            this.labelsignupphone.AutoSize = true;
            this.labelsignupphone.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsignupphone.Location = new System.Drawing.Point(70, 389);
            this.labelsignupphone.Name = "labelsignupphone";
            this.labelsignupphone.Size = new System.Drawing.Size(153, 25);
            this.labelsignupphone.TabIndex = 20;
            this.labelsignupphone.Text = "Mobile Number";
            // 
            // labelsignup
            // 
            this.labelsignup.AutoSize = true;
            this.labelsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelsignup.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelsignup.Location = new System.Drawing.Point(161, 561);
            this.labelsignup.Name = "labelsignup";
            this.labelsignup.Size = new System.Drawing.Size(142, 27);
            this.labelsignup.TabIndex = 22;
            this.labelsignup.Text = "Back to login";
            this.labelsignup.Click += new System.EventHandler(this.labelsignup_Click);
            // 
            // Signinpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 675);
            this.Controls.Add(this.labelsignup);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.labelsignupphone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelsignupName);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.loginpic);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelsignupemail);
            this.Controls.Add(this.labelsignuppwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signinpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "neww";
            this.Load += new System.EventHandler(this.Signinpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox loginpic;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelsignupemail;
        private System.Windows.Forms.Label labelsignuppwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelsignupName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label labelsignupphone;
        private System.Windows.Forms.Label labelsignup;
    }
}