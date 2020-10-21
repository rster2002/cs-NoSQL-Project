namespace View.components {
    partial class LoginComponent {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.loginComponentTLP = new System.Windows.Forms.TableLayoutPanel();
            this.LogLBLTitle = new System.Windows.Forms.Label();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.lblwarning = new System.Windows.Forms.Label();
            this.loginComponentTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginComponentTLP
            // 
            this.loginComponentTLP.ColumnCount = 3;
            this.loginComponentTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.loginComponentTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.loginComponentTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.loginComponentTLP.Controls.Add(this.LogLBLTitle, 1, 0);
            this.loginComponentTLP.Controls.Add(this.TBUserName, 1, 2);
            this.loginComponentTLP.Controls.Add(this.label1, 1, 1);
            this.loginComponentTLP.Controls.Add(this.TBpassword, 1, 4);
            this.loginComponentTLP.Controls.Add(this.label2, 1, 3);
            this.loginComponentTLP.Controls.Add(this.BtnLogin, 1, 6);
            this.loginComponentTLP.Controls.Add(this.lblwarning, 1, 5);
            this.loginComponentTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginComponentTLP.Location = new System.Drawing.Point(0, 0);
            this.loginComponentTLP.Margin = new System.Windows.Forms.Padding(2);
            this.loginComponentTLP.Name = "loginComponentTLP";
            this.loginComponentTLP.RowCount = 7;
            this.loginComponentTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.loginComponentTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.loginComponentTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.loginComponentTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.loginComponentTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.loginComponentTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.loginComponentTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.loginComponentTLP.Size = new System.Drawing.Size(346, 396);
            this.loginComponentTLP.TabIndex = 0;
            // 
            // LogLBLTitle
            // 
            this.LogLBLTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogLBLTitle.AutoSize = true;
            this.LogLBLTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLBLTitle.Location = new System.Drawing.Point(105, 0);
            this.LogLBLTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogLBLTitle.Name = "LogLBLTitle";
            this.LogLBLTitle.Size = new System.Drawing.Size(134, 59);
            this.LogLBLTitle.TabIndex = 1;
            this.LogLBLTitle.Text = "The Garden Group";
            this.LogLBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBUserName
            // 
            this.TBUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBUserName.Location = new System.Drawing.Point(105, 117);
            this.TBUserName.Margin = new System.Windows.Forms.Padding(2, 19, 2, 19);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(134, 20);
            this.TBUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // TBpassword
            // 
            this.TBpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBpassword.Location = new System.Drawing.Point(105, 215);
            this.TBpassword.Margin = new System.Windows.Forms.Padding(2, 19, 2, 19);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.Size = new System.Drawing.Size(134, 20);
            this.TBpassword.TabIndex = 2;
            this.TBpassword.UseSystemPasswordChar = true;
            this.TBpassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBpassword_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wachtwoord:";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(105, 296);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(134, 98);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblwarning.ForeColor = System.Drawing.Color.Crimson;
            this.lblwarning.Location = new System.Drawing.Point(105, 255);
            this.lblwarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(134, 39);
            this.lblwarning.TabIndex = 6;
            this.lblwarning.Text = "Gebruikersnaam of wachtwoord is incorrect";
            // 
            // LoginComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginComponentTLP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginComponent";
            this.Size = new System.Drawing.Size(346, 396);
            this.loginComponentTLP.ResumeLayout(false);
            this.loginComponentTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel loginComponentTLP;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.Label LogLBLTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label lblwarning;
    }
}
