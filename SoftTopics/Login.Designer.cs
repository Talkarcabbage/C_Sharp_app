﻿namespace SoftTopics
{
    partial class formLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnQuickLogin = new System.Windows.Forms.Button();
            this.txtCredentialBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(944, 434);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 106);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(736, 434);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 8;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ShortcutsEnabled = false;
            this.txtUsername.Size = new System.Drawing.Size(132, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(736, 511);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeyPress);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressedAlphaNum);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(647, 438);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(649, 514);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password: ";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(683, 689);
            this.lblSuccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 17);
            this.lblSuccess.TabIndex = 6;
            // 
            // txtPIN
            // 
            this.txtPIN.Enabled = false;
            this.txtPIN.Location = new System.Drawing.Point(736, 609);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtPIN.MaxLength = 11;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.ShortcutsEnabled = false;
            this.txtPIN.Size = new System.Drawing.Size(132, 22);
            this.txtPIN.TabIndex = 4;
            this.txtPIN.Visible = false;
            this.txtPIN.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            this.txtPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPin.Location = new System.Drawing.Point(683, 613);
            this.lblPin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(38, 17);
            this.lblPin.TabIndex = 8;
            this.lblPin.Text = "PIN: ";
            this.lblPin.Visible = false;
            this.lblPin.Click += new System.EventHandler(this.lblPin_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FlatAppearance.BorderSize = 3;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(944, 578);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 85);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit PIN";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnQuickLogin
            // 
            this.btnQuickLogin.FlatAppearance.BorderSize = 3;
            this.btnQuickLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuickLogin.Location = new System.Drawing.Point(1504, 511);
            this.btnQuickLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuickLogin.Name = "btnQuickLogin";
            this.btnQuickLogin.Size = new System.Drawing.Size(133, 106);
            this.btnQuickLogin.TabIndex = 9;
            this.btnQuickLogin.Text = "Re-Login";
            this.btnQuickLogin.UseVisualStyleBackColor = true;
            this.btnQuickLogin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCredentialBox
            // 
            this.txtCredentialBox.Location = new System.Drawing.Point(1341, 553);
            this.txtCredentialBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredentialBox.MaxLength = 13;
            this.txtCredentialBox.Name = "txtCredentialBox";
            this.txtCredentialBox.ShortcutsEnabled = false;
            this.txtCredentialBox.Size = new System.Drawing.Size(132, 22);
            this.txtCredentialBox.TabIndex = 10;
            this.txtCredentialBox.TextChanged += new System.EventHandler(this.textChangeTimeLimit);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1684, 710);
            this.Controls.Add(this.txtCredentialBox);
            this.Controls.Add(this.btnQuickLogin);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formLogin";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnQuickLogin;
        private System.Windows.Forms.TextBox txtCredentialBox;
    }
}

