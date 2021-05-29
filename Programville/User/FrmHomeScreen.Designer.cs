namespace Programville
{
    partial class FrmHomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeScreen));
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.menuUser = new System.Windows.Forms.TabControl();
            this.tabTeste = new System.Windows.Forms.TabPage();
            this.groupTeste = new System.Windows.Forms.GroupBox();
            this.panelTeste = new System.Windows.Forms.FlowLayoutPanel();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabStatistica = new System.Windows.Forms.TabPage();
            this.lbNotFound = new System.Windows.Forms.Label();
            this.gridRezultate = new System.Windows.Forms.DataGridView();
            this.TitluTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PunctajUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSustinere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.menuUser.SuspendLayout();
            this.tabTeste.SuspendLayout();
            this.groupTeste.SuspendLayout();
            this.groupFilter.SuspendLayout();
            this.tabStatistica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezultate)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(15, 229);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(123, 18);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "email@email.com";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNume.Location = new System.Drawing.Point(13, 188);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(178, 29);
            this.lbNume.TabIndex = 2;
            this.lbNume.Text = "Nume Prenume";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Location = new System.Drawing.Point(73, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 153);
            this.panel1.TabIndex = 1;
            // 
            // picUser
            // 
            this.picUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUser.Image = global::Programville.Properties.Resources.utilizator_img;
            this.picUser.Location = new System.Drawing.Point(0, 0);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(124, 151);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.mainContainer.Panel1.Controls.Add(this.btnEditProfile);
            this.mainContainer.Panel1.Controls.Add(this.btnExit);
            this.mainContainer.Panel1.Controls.Add(this.btnChangePassword);
            this.mainContainer.Panel1.Controls.Add(this.lbEmail);
            this.mainContainer.Panel1.Controls.Add(this.lbNume);
            this.mainContainer.Panel1.Controls.Add(this.panel1);
            this.mainContainer.Panel1.ForeColor = System.Drawing.SystemColors.Control;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.mainContainer.Panel2.Controls.Add(this.menuUser);
            this.mainContainer.Size = new System.Drawing.Size(1189, 668);
            this.mainContainer.SplitterDistance = 297;
            this.mainContainer.TabIndex = 2;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.White;
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Image = global::Programville.Properties.Resources.icons8_edit_profile_32;
            this.btnEditProfile.Location = new System.Drawing.Point(115, 571);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(59, 49);
            this.btnEditProfile.TabIndex = 6;
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Programville.Properties.Resources.log_off_32;
            this.btnExit.Location = new System.Drawing.Point(207, 571);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Image = global::Programville.Properties.Resources.login_form_32;
            this.btnChangePassword.Location = new System.Drawing.Point(18, 571);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(59, 49);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // menuUser
            // 
            this.menuUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.menuUser.Controls.Add(this.tabTeste);
            this.menuUser.Controls.Add(this.tabStatistica);
            this.menuUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuUser.Location = new System.Drawing.Point(0, 0);
            this.menuUser.Name = "menuUser";
            this.menuUser.SelectedIndex = 0;
            this.menuUser.Size = new System.Drawing.Size(888, 668);
            this.menuUser.TabIndex = 0;
            // 
            // tabTeste
            // 
            this.tabTeste.Controls.Add(this.groupTeste);
            this.tabTeste.Controls.Add(this.groupFilter);
            this.tabTeste.Controls.Add(this.label2);
            this.tabTeste.Controls.Add(this.panel2);
            this.tabTeste.Location = new System.Drawing.Point(4, 4);
            this.tabTeste.Name = "tabTeste";
            this.tabTeste.Size = new System.Drawing.Size(880, 632);
            this.tabTeste.TabIndex = 1;
            this.tabTeste.Text = "Teste";
            this.tabTeste.UseVisualStyleBackColor = true;
            // 
            // groupTeste
            // 
            this.groupTeste.Controls.Add(this.panelTeste);
            this.groupTeste.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTeste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.groupTeste.Location = new System.Drawing.Point(20, 199);
            this.groupTeste.Name = "groupTeste";
            this.groupTeste.Size = new System.Drawing.Size(852, 417);
            this.groupTeste.TabIndex = 58;
            this.groupTeste.TabStop = false;
            this.groupTeste.Text = "Teste";
            // 
            // panelTeste
            // 
            this.panelTeste.AutoScroll = true;
            this.panelTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTeste.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelTeste.Location = new System.Drawing.Point(3, 26);
            this.panelTeste.Name = "panelTeste";
            this.panelTeste.Size = new System.Drawing.Size(846, 388);
            this.panelTeste.TabIndex = 64;
            this.panelTeste.WrapContents = false;
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.btnFilter);
            this.groupFilter.Controls.Add(this.comboFilter);
            this.groupFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.groupFilter.Location = new System.Drawing.Point(20, 104);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(757, 89);
            this.groupFilter.TabIndex = 57;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Alege materia din care vrei să rezolvi teste";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(611, 29);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(130, 42);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filtrează";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // comboFilter
            // 
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(20, 36);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(568, 31);
            this.comboFilter.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 34);
            this.label2.TabIndex = 56;
            this.label2.Text = "Bine ai revenit!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel2.Location = new System.Drawing.Point(20, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 1);
            this.panel2.TabIndex = 55;
            // 
            // tabStatistica
            // 
            this.tabStatistica.Controls.Add(this.lbNotFound);
            this.tabStatistica.Controls.Add(this.gridRezultate);
            this.tabStatistica.Controls.Add(this.label4);
            this.tabStatistica.Controls.Add(this.label3);
            this.tabStatistica.Controls.Add(this.label1);
            this.tabStatistica.Controls.Add(this.panel3);
            this.tabStatistica.Location = new System.Drawing.Point(4, 4);
            this.tabStatistica.Name = "tabStatistica";
            this.tabStatistica.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistica.Size = new System.Drawing.Size(880, 632);
            this.tabStatistica.TabIndex = 2;
            this.tabStatistica.Text = "Statistica";
            this.tabStatistica.UseVisualStyleBackColor = true;
            // 
            // lbNotFound
            // 
            this.lbNotFound.AutoSize = true;
            this.lbNotFound.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbNotFound.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotFound.ForeColor = System.Drawing.Color.White;
            this.lbNotFound.Location = new System.Drawing.Point(277, 355);
            this.lbNotFound.Name = "lbNotFound";
            this.lbNotFound.Size = new System.Drawing.Size(355, 38);
            this.lbNotFound.TabIndex = 64;
            this.lbNotFound.Text = "Niciun test rezolvat recent.";
            this.lbNotFound.Visible = false;
            // 
            // gridRezultate
            // 
            this.gridRezultate.AllowUserToAddRows = false;
            this.gridRezultate.AllowUserToDeleteRows = false;
            this.gridRezultate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRezultate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitluTest,
            this.EmailUser,
            this.PunctajUser,
            this.DataSustinere});
            this.gridRezultate.Location = new System.Drawing.Point(31, 142);
            this.gridRezultate.Name = "gridRezultate";
            this.gridRezultate.ReadOnly = true;
            this.gridRezultate.RowHeadersWidth = 51;
            this.gridRezultate.RowTemplate.Height = 24;
            this.gridRezultate.Size = new System.Drawing.Size(841, 443);
            this.gridRezultate.TabIndex = 63;
            // 
            // TitluTest
            // 
            this.TitluTest.HeaderText = "Titlu test";
            this.TitluTest.MinimumWidth = 6;
            this.TitluTest.Name = "TitluTest";
            this.TitluTest.ReadOnly = true;
            this.TitluTest.Width = 125;
            // 
            // EmailUser
            // 
            this.EmailUser.HeaderText = "Email utilizator";
            this.EmailUser.MinimumWidth = 6;
            this.EmailUser.Name = "EmailUser";
            this.EmailUser.ReadOnly = true;
            this.EmailUser.Width = 125;
            // 
            // PunctajUser
            // 
            this.PunctajUser.HeaderText = "Punctaj";
            this.PunctajUser.MinimumWidth = 6;
            this.PunctajUser.Name = "PunctajUser";
            this.PunctajUser.ReadOnly = true;
            this.PunctajUser.Width = 125;
            // 
            // DataSustinere
            // 
            this.DataSustinere.HeaderText = "Data sustinere";
            this.DataSustinere.MinimumWidth = 6;
            this.DataSustinere.Name = "DataSustinere";
            this.DataSustinere.ReadOnly = true;
            this.DataSustinere.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(26, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(689, 28);
            this.label4.TabIndex = 61;
            this.label4.Text = "Pentru a actualiza statistica, va trebui sa te reloghezi dupa un test rezolvat.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(565, 28);
            this.label3.TabIndex = 60;
            this.label3.Text = "Vezi notele tale recente pentru a îmbunatății performanța ta.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 34);
            this.label1.TabIndex = 58;
            this.label1.Text = "Statistica notelor";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel3.Location = new System.Drawing.Point(31, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 1);
            this.panel3.TabIndex = 57;
            // 
            // FrmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1189, 668);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panou utilizator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHomeScreen_FormClosing);
            this.Load += new System.EventHandler(this.FrmHomeScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.menuUser.ResumeLayout(false);
            this.tabTeste.ResumeLayout(false);
            this.tabTeste.PerformLayout();
            this.groupTeste.ResumeLayout(false);
            this.groupFilter.ResumeLayout(false);
            this.tabStatistica.ResumeLayout(false);
            this.tabStatistica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezultate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.TabControl menuUser;
        private System.Windows.Forms.TabPage tabTeste;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox groupTeste;
        private System.Windows.Forms.TabPage tabStatistica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridRezultate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitluTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn PunctajUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSustinere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNotFound;
        private System.Windows.Forms.FlowLayoutPanel panelTeste;
    }
}