namespace View.views {
    partial class LoginView {
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
            this.centerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.centerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.centerPanel.Location = new System.Drawing.Point(288, 42);
            this.centerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(538, 611);
            this.centerPanel.TabIndex = 1;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.centerPanel);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(1114, 695);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel centerPanel;
    }
}
