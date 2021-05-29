namespace Programville
{
    partial class FrmHomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeAdmin));
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lbNotFound = new System.Windows.Forms.Label();
            this.gridRezultate = new System.Windows.Forms.DataGridView();
            this.TitluTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PunctajUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSustinere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testeOp = new System.Windows.Forms.ToolStripMenuItem();
            this.materiiOp = new System.Windows.Forms.ToolStripMenuItem();
            this.administrareOp = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lbNrUtilizatori = new System.Windows.Forms.Label();
            this.lbNrTeste = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezultate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.mainContainer.Panel2.Controls.Add(this.lbNotFound);
            this.mainContainer.Panel2.Controls.Add(this.gridRezultate);
            this.mainContainer.Panel2.Controls.Add(this.label1);
            this.mainContainer.Panel2.Controls.Add(this.panel3);
            this.mainContainer.Panel2.Controls.Add(this.menuStrip1);
            this.mainContainer.Panel2.Controls.Add(this.panelInfo);
            this.mainContainer.Size = new System.Drawing.Size(1124, 594);
            this.mainContainer.SplitterDistance = 281;
            this.mainContainer.TabIndex = 1;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.White;
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Image = global::Programville.Properties.Resources.icons8_edit_profile_32;
            this.btnEditProfile.Location = new System.Drawing.Point(109, 496);
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
            this.btnExit.Location = new System.Drawing.Point(195, 496);
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
            this.btnChangePassword.Location = new System.Drawing.Point(17, 496);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(59, 49);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(14, 233);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(193, 18);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "john.doe@programville.com";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNume.Location = new System.Drawing.Point(12, 188);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(114, 29);
            this.lbNume.TabIndex = 2;
            this.lbNume.Text = "John Doe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Location = new System.Drawing.Point(73, 24);
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
            // lbNotFound
            // 
            this.lbNotFound.AutoSize = true;
            this.lbNotFound.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbNotFound.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotFound.ForeColor = System.Drawing.Color.White;
            this.lbNotFound.Location = new System.Drawing.Point(232, 399);
            this.lbNotFound.Name = "lbNotFound";
            this.lbNotFound.Size = new System.Drawing.Size(355, 38);
            this.lbNotFound.TabIndex = 63;
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
            this.gridRezultate.Location = new System.Drawing.Point(25, 257);
            this.gridRezultate.Name = "gridRezultate";
            this.gridRezultate.ReadOnly = true;
            this.gridRezultate.RowHeadersWidth = 51;
            this.gridRezultate.RowTemplate.Height = 24;
            this.gridRezultate.Size = new System.Drawing.Size(770, 307);
            this.gridRezultate.TabIndex = 62;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Rezultate recente";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel3.Location = new System.Drawing.Point(21, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 1);
            this.panel3.TabIndex = 59;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeOp,
            this.materiiOp,
            this.administrareOp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testeOp
            // 
            this.testeOp.Name = "testeOp";
            this.testeOp.Size = new System.Drawing.Size(57, 24);
            this.testeOp.Text = "Teste";
            this.testeOp.Click += new System.EventHandler(this.testeOp_Click);
            // 
            // materiiOp
            // 
            this.materiiOp.Name = "materiiOp";
            this.materiiOp.Size = new System.Drawing.Size(70, 24);
            this.materiiOp.Text = "Materii";
            this.materiiOp.Click += new System.EventHandler(this.materiiOp_Click);
            // 
            // administrareOp
            // 
            this.administrareOp.Name = "administrareOp";
            this.administrareOp.Size = new System.Drawing.Size(108, 24);
            this.administrareOp.Text = "Administrare";
            this.administrareOp.Click += new System.EventHandler(this.administrareOp_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lbNrUtilizatori);
            this.panelInfo.Controls.Add(this.lbNrTeste);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.pictureBox2);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Location = new System.Drawing.Point(25, 56);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(770, 149);
            this.panelInfo.TabIndex = 0;
            // 
            // lbNrUtilizatori
            // 
            this.lbNrUtilizatori.AutoSize = true;
            this.lbNrUtilizatori.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNrUtilizatori.Location = new System.Drawing.Point(577, 71);
            this.lbNrUtilizatori.Name = "lbNrUtilizatori";
            this.lbNrUtilizatori.Size = new System.Drawing.Size(98, 41);
            this.lbNrUtilizatori.TabIndex = 5;
            this.lbNrUtilizatori.Text = "99999";
            // 
            // lbNrTeste
            // 
            this.lbNrTeste.AutoSize = true;
            this.lbNrTeste.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNrTeste.Location = new System.Drawing.Point(183, 71);
            this.lbNrTeste.Name = "lbNrTeste";
            this.lbNrTeste.Size = new System.Drawing.Size(98, 41);
            this.lbNrTeste.TabIndex = 4;
            this.lbNrTeste.Text = "99999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Utilizatori inregistrati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teste create";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Programville.Properties.Resources.statistic_users;
            this.pictureBox2.Location = new System.Drawing.Point(379, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Programville.Properties.Resources.test_image;
            this.pictureBox1.Location = new System.Drawing.Point(23, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 594);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmHomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panou de control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHomeAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FrmHomeAdmin_Load);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            this.mainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezultate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeOp;
        private System.Windows.Forms.ToolStripMenuItem materiiOp;
        private System.Windows.Forms.ToolStripMenuItem administrareOp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNrUtilizatori;
        private System.Windows.Forms.Label lbNrTeste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRezultate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitluTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn PunctajUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSustinere;
        private System.Windows.Forms.Label lbNotFound;
    }
}