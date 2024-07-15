
namespace _4th_sem_proj_beta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.loginpic = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.noaccount = new System.Windows.Forms.Label();
            this.labelsignup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginpic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(70, 255);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(97, 25);
            this.labelpassword.TabIndex = 1;
            this.labelpassword.Text = "Password";
            this.labelpassword.Click += new System.EventHandler(this.labelpassword_Click);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(70, 147);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(59, 25);
            this.labelemail.TabIndex = 2;
            this.labelemail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(75, 175);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 37);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBoxemail_TextChanged);
            // 
            // loginpic
            // 
            this.loginpic.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginpic.Image = ((System.Drawing.Image)(resources.GetObject("loginpic.Image")));
            this.loginpic.Location = new System.Drawing.Point(477, 0);
            this.loginpic.Name = "loginpic";
            this.loginpic.Size = new System.Drawing.Size(491, 675);
            this.loginpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginpic.TabIndex = 4;
            this.loginpic.TabStop = false;
            this.loginpic.Click += new System.EventHandler(this.loginpic_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(75, 283);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(334, 37);
            this.txtPassword.TabIndex = 5;
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.Gold;
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(75, 428);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(334, 51);
            this.loginbutton.TabIndex = 6;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // noaccount
            // 
            this.noaccount.AutoSize = true;
            this.noaccount.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noaccount.Location = new System.Drawing.Point(79, 502);
            this.noaccount.Name = "noaccount";
            this.noaccount.Size = new System.Drawing.Size(231, 27);
            this.noaccount.TabIndex = 7;
            this.noaccount.Text = "Don\'t have an account?";
            this.noaccount.Click += new System.EventHandler(this.noaccount_Click);
            // 
            // labelsignup
            // 
            this.labelsignup.AutoSize = true;
            this.labelsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelsignup.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelsignup.Location = new System.Drawing.Point(302, 502);
            this.labelsignup.Name = "labelsignup";
            this.labelsignup.Size = new System.Drawing.Size(97, 27);
            this.labelsignup.TabIndex = 8;
            this.labelsignup.Text = "SIGN UP";
            this.labelsignup.Click += new System.EventHandler(this.labelsignup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(968, 675);
            this.Controls.Add(this.labelsignup);
            this.Controls.Add(this.noaccount);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.loginpic);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelpassword);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loginpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox loginpic;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label noaccount;
        private System.Windows.Forms.Label labelsignup;
    }
}