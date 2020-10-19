﻿namespace View.views {
    partial class UserManagement {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.clId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.centerPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 706);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // centerPanel
            // 
            this.centerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.centerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.centerPanel.Controls.Add(this.txtSearch);
            this.centerPanel.Controls.Add(this.label2);
            this.centerPanel.Controls.Add(this.lstUsers);
            this.centerPanel.Controls.Add(this.btnAddUser);
            this.centerPanel.Controls.Add(this.label1);
            this.centerPanel.Location = new System.Drawing.Point(201, 73);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(492, 560);
            this.centerPanel.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 116);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter by email";
            // 
            // lstUsers
            // 
            this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clId,
            this.clEmail,
            this.clFirstName,
            this.clLastName,
            this.clTickets});
            this.lstUsers.HideSelection = false;
            this.lstUsers.Location = new System.Drawing.Point(15, 160);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(2);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(459, 370);
            this.lstUsers.TabIndex = 3;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            // 
            // clId
            // 
            this.clId.Text = "ID";
            this.clId.Width = 42;
            // 
            // clEmail
            // 
            this.clEmail.Text = "Email";
            this.clEmail.Width = 122;
            // 
            // clFirstName
            // 
            this.clFirstName.Text = "Firstname";
            this.clFirstName.Width = 110;
            // 
            // clLastName
            // 
            this.clLastName.Text = "Lastname";
            this.clLastName.Width = 126;
            // 
            // clTickets
            // 
            this.clTickets.Text = "# tickets";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(344, 77);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(116, 31);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "+ ADD NEW USER";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Management";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserManagement";
            this.Size = new System.Drawing.Size(895, 706);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ColumnHeader clId;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clFirstName;
        private System.Windows.Forms.ColumnHeader clLastName;
        private System.Windows.Forms.ColumnHeader clTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
    }
}