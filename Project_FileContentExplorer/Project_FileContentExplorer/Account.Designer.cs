﻿namespace Project_FileContentExplorer
{
    partial class Account
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SingUp_Btn = new System.Windows.Forms.Button();
            this.PW_Text = new System.Windows.Forms.TextBox();
            this.SignIn_Btn = new System.Windows.Forms.Button();
            this.ID_Text = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.SingUp_Btn);
            this.panel2.Controls.Add(this.PW_Text);
            this.panel2.Controls.Add(this.SignIn_Btn);
            this.panel2.Controls.Add(this.ID_Text);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 601);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(193, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "ACCOUNT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "PASSWORD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(103, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(141, 406);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 30);
            this.button7.TabIndex = 18;
            this.button7.Text = "Forgot your Account?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // SingUp_Btn
            // 
            this.SingUp_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(180)))), ((int)(((byte)(82)))));
            this.SingUp_Btn.FlatAppearance.BorderSize = 0;
            this.SingUp_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingUp_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingUp_Btn.ForeColor = System.Drawing.Color.White;
            this.SingUp_Btn.Location = new System.Drawing.Point(256, 354);
            this.SingUp_Btn.Name = "SingUp_Btn";
            this.SingUp_Btn.Size = new System.Drawing.Size(85, 25);
            this.SingUp_Btn.TabIndex = 16;
            this.SingUp_Btn.Text = "SIGN UP";
            this.SingUp_Btn.UseVisualStyleBackColor = false;
            this.SingUp_Btn.Click += new System.EventHandler(this.SingUp_Btn_Click);
            // 
            // PW_Text
            // 
            this.PW_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.PW_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW_Text.ForeColor = System.Drawing.Color.White;
            this.PW_Text.Location = new System.Drawing.Point(141, 297);
            this.PW_Text.Name = "PW_Text";
            this.PW_Text.PasswordChar = '*';
            this.PW_Text.Size = new System.Drawing.Size(200, 24);
            this.PW_Text.TabIndex = 14;
            // 
            // SignIn_Btn
            // 
            this.SignIn_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(50)))), ((int)(((byte)(170)))));
            this.SignIn_Btn.FlatAppearance.BorderSize = 0;
            this.SignIn_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Btn.ForeColor = System.Drawing.Color.White;
            this.SignIn_Btn.Location = new System.Drawing.Point(141, 354);
            this.SignIn_Btn.Name = "SignIn_Btn";
            this.SignIn_Btn.Size = new System.Drawing.Size(85, 25);
            this.SignIn_Btn.TabIndex = 15;
            this.SignIn_Btn.Text = "SIGN IN";
            this.SignIn_Btn.UseVisualStyleBackColor = false;
            this.SignIn_Btn.Click += new System.EventHandler(this.SignIn_Btn_Click);
            // 
            // ID_Text
            // 
            this.ID_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ID_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Text.ForeColor = System.Drawing.Color.White;
            this.ID_Text.Location = new System.Drawing.Point(141, 240);
            this.ID_Text.Name = "ID_Text";
            this.ID_Text.Size = new System.Drawing.Size(200, 24);
            this.ID_Text.TabIndex = 13;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.Text = "Account";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button SingUp_Btn;
        private System.Windows.Forms.TextBox PW_Text;
        private System.Windows.Forms.Button SignIn_Btn;
        private System.Windows.Forms.TextBox ID_Text;
    }
}