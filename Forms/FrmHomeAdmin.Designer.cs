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
            this.btnDeconectare = new System.Windows.Forms.Button();
            this.btnSetari = new System.Windows.Forms.Button();
            this.btnRecenzii = new System.Windows.Forms.Button();
            this.btnStudenti = new System.Windows.Forms.Button();
            this.btnMaterii = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.gridRezultate = new System.Windows.Forms.DataGridView();
            this.TitluTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PunctajUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSustinere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezultate)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.mainContainer.Panel1.Controls.Add(this.btnDeconectare);
            this.mainContainer.Panel1.Controls.Add(this.btnSetari);
            this.mainContainer.Panel1.Controls.Add(this.btnRecenzii);
            this.mainContainer.Panel1.Controls.Add(this.btnStudenti);
            this.mainContainer.Panel1.Controls.Add(this.btnMaterii);
            this.mainContainer.Panel1.Controls.Add(this.btnTest);
            this.mainContainer.Panel1.Controls.Add(this.picLogo);
            this.mainContainer.Panel1.ForeColor = System.Drawing.SystemColors.Control;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.mainContainer.Panel2.Controls.Add(this.gridRezultate);
            this.mainContainer.Panel2.Controls.Add(this.label5);
            this.mainContainer.Panel2.Controls.Add(this.label4);
            this.mainContainer.Panel2.Controls.Add(this.label1);
            this.mainContainer.Panel2.Controls.Add(this.panelInfo);
            this.mainContainer.Size = new System.Drawing.Size(1147, 627);
            this.mainContainer.SplitterDistance = 245;
            this.mainContainer.TabIndex = 1;
            // 
            // btnDeconectare
            // 
            this.btnDeconectare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDeconectare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeconectare.FlatAppearance.BorderSize = 0;
            this.btnDeconectare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconectare.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconectare.Image = global::Programville.Properties.Resources.log_off_48;
            this.btnDeconectare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconectare.Location = new System.Drawing.Point(0, 480);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(245, 65);
            this.btnDeconectare.TabIndex = 7;
            this.btnDeconectare.Text = "Deconectare";
            this.btnDeconectare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeconectare.UseVisualStyleBackColor = false;
            this.btnDeconectare.Click += new System.EventHandler(this.btnDeconectare_Click);
            // 
            // btnSetari
            // 
            this.btnSetari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.btnSetari.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetari.FlatAppearance.BorderSize = 0;
            this.btnSetari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetari.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetari.Image = global::Programville.Properties.Resources.setari_48;
            this.btnSetari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetari.Location = new System.Drawing.Point(0, 415);
            this.btnSetari.Name = "btnSetari";
            this.btnSetari.Size = new System.Drawing.Size(245, 65);
            this.btnSetari.TabIndex = 6;
            this.btnSetari.Text = "Setări";
            this.btnSetari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetari.UseVisualStyleBackColor = false;
            this.btnSetari.Click += new System.EventHandler(this.btnSetari_Click);
            // 
            // btnRecenzii
            // 
            this.btnRecenzii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.btnRecenzii.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecenzii.FlatAppearance.BorderSize = 0;
            this.btnRecenzii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecenzii.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecenzii.Image = global::Programville.Properties.Resources.recenzii_48;
            this.btnRecenzii.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecenzii.Location = new System.Drawing.Point(0, 350);
            this.btnRecenzii.Name = "btnRecenzii";
            this.btnRecenzii.Size = new System.Drawing.Size(245, 65);
            this.btnRecenzii.TabIndex = 5;
            this.btnRecenzii.Text = "Recenzii";
            this.btnRecenzii.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecenzii.UseVisualStyleBackColor = false;
            this.btnRecenzii.Click += new System.EventHandler(this.btnRecenzii_Click);
            // 
            // btnStudenti
            // 
            this.btnStudenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.btnStudenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudenti.FlatAppearance.BorderSize = 0;
            this.btnStudenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudenti.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudenti.Image = global::Programville.Properties.Resources.students_48;
            this.btnStudenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudenti.Location = new System.Drawing.Point(0, 285);
            this.btnStudenti.Name = "btnStudenti";
            this.btnStudenti.Size = new System.Drawing.Size(245, 65);
            this.btnStudenti.TabIndex = 4;
            this.btnStudenti.Text = "Studenti";
            this.btnStudenti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudenti.UseVisualStyleBackColor = false;
            this.btnStudenti.Click += new System.EventHandler(this.btnStudenti_Click);
            // 
            // btnMaterii
            // 
            this.btnMaterii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.btnMaterii.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterii.FlatAppearance.BorderSize = 0;
            this.btnMaterii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterii.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterii.Image = global::Programville.Properties.Resources.category_48;
            this.btnMaterii.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterii.Location = new System.Drawing.Point(0, 220);
            this.btnMaterii.Name = "btnMaterii";
            this.btnMaterii.Size = new System.Drawing.Size(245, 65);
            this.btnMaterii.TabIndex = 3;
            this.btnMaterii.Text = "Materii";
            this.btnMaterii.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaterii.UseVisualStyleBackColor = false;
            this.btnMaterii.Click += new System.EventHandler(this.btnMaterii_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Image = global::Programville.Properties.Resources.test_48;
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(0, 155);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(245, 65);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Teste";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::Programville.Properties.Resources.app_logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(245, 155);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // gridRezultate
            // 
            this.gridRezultate.AllowUserToAddRows = false;
            this.gridRezultate.AllowUserToDeleteRows = false;
            this.gridRezultate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRezultate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRezultate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitluTest,
            this.Email,
            this.PunctajUser,
            this.DataSustinere});
            this.gridRezultate.Location = new System.Drawing.Point(57, 353);
            this.gridRezultate.Name = "gridRezultate";
            this.gridRezultate.ReadOnly = true;
            this.gridRezultate.RowHeadersWidth = 51;
            this.gridRezultate.RowTemplate.Height = 24;
            this.gridRezultate.Size = new System.Drawing.Size(770, 242);
            this.gridRezultate.TabIndex = 68;
            // 
            // TitluTest
            // 
            this.TitluTest.HeaderText = "Titlu test";
            this.TitluTest.MinimumWidth = 6;
            this.TitluTest.Name = "TitluTest";
            this.TitluTest.ReadOnly = true;
            this.TitluTest.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rezultate recente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Statistica aplicației";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bine ați revenit!";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Controls.Add(this.lbNrUtilizatori);
            this.panelInfo.Controls.Add(this.lbNrTeste);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.pictureBox2);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Location = new System.Drawing.Point(57, 158);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(770, 149);
            this.panelInfo.TabIndex = 0;
            // 
            // lbNrUtilizatori
            // 
            this.lbNrUtilizatori.AutoSize = true;
            this.lbNrUtilizatori.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNrUtilizatori.ForeColor = System.Drawing.Color.White;
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
            this.lbNrTeste.ForeColor = System.Drawing.Color.White;
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
            this.label3.ForeColor = System.Drawing.Color.White;
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
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teste create";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Programville.Properties.Resources.students_481;
            this.pictureBox2.Location = new System.Drawing.Point(379, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Programville.Properties.Resources.test_48;
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
            this.ClientSize = new System.Drawing.Size(1147, 627);
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
            this.mainContainer.Panel2.ResumeLayout(false);
            this.mainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezultate)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNrUtilizatori;
        private System.Windows.Forms.Label lbNrTeste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnMaterii;
        private System.Windows.Forms.Button btnStudenti;
        private System.Windows.Forms.Button btnRecenzii;
        private System.Windows.Forms.Button btnSetari;
        private System.Windows.Forms.Button btnDeconectare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRezultate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitluTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PunctajUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSustinere;
    }
}