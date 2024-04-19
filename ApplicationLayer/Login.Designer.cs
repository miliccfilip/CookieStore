
namespace PresentationLayer
{
    partial class Login
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
            this.labelTittle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Tai Le", 37.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTittle.Location = new System.Drawing.Point(40, 39);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(292, 80);
            this.labelTittle.TabIndex = 0;
            this.labelTittle.Text = "PRIJAVA";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelUsername.Location = new System.Drawing.Point(73, 144);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(201, 43);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(74, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "PASSWORD";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.Location = new System.Drawing.Point(74, 201);
            this.tbUsername.MaxLength = 42767;
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(209, 47);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(74, 332);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(211, 47);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(53, 407);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(263, 65);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "PRIJAVI SE";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(378, 522);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelTittle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button buttonLogin;
    }
}