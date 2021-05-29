
namespace Programville
{
    partial class FrmCreatorTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreatorTest));
            this.mainDatabaseDataSet1 = new Programville.MainDatabaseDataSet();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboMaterie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPreviewTest = new System.Windows.Forms.PictureBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNotFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDatabaseDataSet1
            // 
            this.mainDatabaseDataSet1.DataSetName = "MainDatabaseDataSet";
            this.mainDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(818, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 42);
            this.btnNext.TabIndex = 50;
            this.btnNext.Text = "Continuă";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "Descriere";
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(191, 209);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(453, 194);
            this.txtDescriere.TabIndex = 47;
            // 
            // txtTitlu
            // 
            this.txtTitlu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitlu.Location = new System.Drawing.Point(191, 144);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(453, 34);
            this.txtTitlu.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Titlu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(890, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Materie";
            // 
            // comboMaterie
            // 
            this.comboMaterie.FormattingEnabled = true;
            this.comboMaterie.Location = new System.Drawing.Point(721, 144);
            this.comboMaterie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboMaterie.Name = "comboMaterie";
            this.comboMaterie.Size = new System.Drawing.Size(226, 24);
            this.comboMaterie.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(185, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 34);
            this.label2.TabIndex = 42;
            this.label2.Text = "Informații test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(852, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Previzualizare";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.Location = new System.Drawing.Point(191, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 1);
            this.panel1.TabIndex = 54;
            // 
            // picPreviewTest
            // 
            this.picPreviewTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreviewTest.Location = new System.Drawing.Point(721, 209);
            this.picPreviewTest.Name = "picPreviewTest";
            this.picPreviewTest.Size = new System.Drawing.Size(226, 146);
            this.picPreviewTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreviewTest.TabIndex = 52;
            this.picPreviewTest.TabStop = false;
            this.picPreviewTest.Paint += new System.Windows.Forms.PaintEventHandler(this.picPreviewTest_Paint);
            // 
            // btnAddPic
            // 
            this.btnAddPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnAddPic.FlatAppearance.BorderSize = 0;
            this.btnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPic.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.ForeColor = System.Drawing.Color.White;
            this.btnAddPic.Image = global::Programville.Properties.Resources.icons8_upload_32;
            this.btnAddPic.Location = new System.Drawing.Point(721, 361);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(226, 42);
            this.btnAddPic.TabIndex = 51;
            this.btnAddPic.UseVisualStyleBackColor = false;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Programville.Properties.Resources.materiale;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // lbNotFound
            // 
            this.lbNotFound.AutoSize = true;
            this.lbNotFound.Location = new System.Drawing.Point(759, 278);
            this.lbNotFound.Name = "lbNotFound";
            this.lbNotFound.Size = new System.Drawing.Size(152, 17);
            this.lbNotFound.TabIndex = 55;
            this.lbNotFound.Text = "Nicio imagine asociata!";
            this.lbNotFound.Visible = false;
            // 
            // FrmCreatorTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 451);
            this.Controls.Add(this.lbNotFound);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picPreviewTest);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboMaterie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreatorTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panou test";
            this.Load += new System.EventHandler(this.FrmCreatorTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MainDatabaseDataSet mainDatabaseDataSet1;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboMaterie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picPreviewTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNotFound;
    }
}