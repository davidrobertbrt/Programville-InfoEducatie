
namespace Programville
{
    partial class FrmEditProfileInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditProfileInformation));
            this.lbError = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Brown;
            this.lbError.Location = new System.Drawing.Point(28, 569);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(144, 20);
            this.lbError.TabIndex = 102;
            this.lbError.Text = "Eroare necunoscută";
            this.lbError.Visible = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(28, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 49);
            this.label7.TabIndex = 101;
            this.label7.Text = "Pentru a confirma modificările, vă rugăm \r\nintroduceti parola veche";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(27, 520);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(351, 26);
            this.txtOldPassword.TabIndex = 100;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 19);
            this.label6.TabIndex = 99;
            this.label6.Text = "Confirmare parolă nouă";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 98;
            this.label5.Text = "Parolă nouă";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(131, 608);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(124, 50);
            this.btnDeleteAccount.TabIndex = 95;
            this.btnDeleteAccount.Text = "Șterge cont";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 96;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 97;
            this.label3.Text = "Prenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nume";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(261, 608);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 50);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "Salvează";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(27, 398);
            this.txtConfirmNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(351, 26);
            this.txtConfirmNewPassword.TabIndex = 92;
            this.txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(27, 334);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(351, 26);
            this.txtNewPassword.TabIndex = 91;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(27, 251);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(351, 26);
            this.txtEmail.TabIndex = 90;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(27, 184);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(351, 26);
            this.txtLastName.TabIndex = 89;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(27, 111);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(351, 26);
            this.txtFirstName.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 87;
            this.label1.Text = "Editează contul";
            // 
            // FrmEditProfileInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(404, 682);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEditProfileInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditProfileInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
    }
}