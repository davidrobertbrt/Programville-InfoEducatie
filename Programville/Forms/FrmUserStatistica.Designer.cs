
namespace Programville
{
    partial class FrmUserStatistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserStatistica));
            this.label1 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lbNrRecenzii = new System.Windows.Forms.Label();
            this.lbNrTeste = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridRezultate = new System.Windows.Forms.DataGridView();
            this.TitluTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PunctajUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSustinere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezultate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Statistica";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Controls.Add(this.lbNrRecenzii);
            this.panelInfo.Controls.Add(this.lbNrTeste);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.pictureBox2);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Location = new System.Drawing.Point(12, 89);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(902, 149);
            this.panelInfo.TabIndex = 18;
            // 
            // lbNrRecenzii
            // 
            this.lbNrRecenzii.AutoSize = true;
            this.lbNrRecenzii.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNrRecenzii.ForeColor = System.Drawing.Color.White;
            this.lbNrRecenzii.Location = new System.Drawing.Point(708, 71);
            this.lbNrRecenzii.Name = "lbNrRecenzii";
            this.lbNrRecenzii.Size = new System.Drawing.Size(98, 41);
            this.lbNrRecenzii.TabIndex = 5;
            this.lbNrRecenzii.Text = "99999";
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
            this.label3.Location = new System.Drawing.Point(643, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Recenzii realizate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teste rezolvate";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Programville.Properties.Resources.recenzii_48;
            this.pictureBox2.Location = new System.Drawing.Point(510, 26);
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
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(902, 28);
            this.label4.TabIndex = 66;
            this.label4.Text = "Teste rezolvate recent";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.PunctajUser,
            this.DataSustinere});
            this.gridRezultate.Location = new System.Drawing.Point(15, 300);
            this.gridRezultate.Name = "gridRezultate";
            this.gridRezultate.ReadOnly = true;
            this.gridRezultate.RowHeadersWidth = 51;
            this.gridRezultate.RowTemplate.Height = 24;
            this.gridRezultate.Size = new System.Drawing.Size(928, 403);
            this.gridRezultate.TabIndex = 67;
            // 
            // TitluTest
            // 
            this.TitluTest.HeaderText = "Titlu test";
            this.TitluTest.MinimumWidth = 6;
            this.TitluTest.Name = "TitluTest";
            this.TitluTest.ReadOnly = true;
            this.TitluTest.Width = 125;
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
            // FrmUserStatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(971, 735);
            this.Controls.Add(this.gridRezultate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmUserStatistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistica";
            this.Load += new System.EventHandler(this.FrmUserStatistica_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezultate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lbNrRecenzii;
        private System.Windows.Forms.Label lbNrTeste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridRezultate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitluTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn PunctajUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSustinere;
    }
}