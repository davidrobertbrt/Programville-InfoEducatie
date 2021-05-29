namespace Programville
{
    partial class ManageUtilizatori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUtilizatori));
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnPromovare = new System.Windows.Forms.Button();
            this.listUtilizatori = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNotFound = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.Firebrick;
            this.btnStergere.FlatAppearance.BorderSize = 0;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.Location = new System.Drawing.Point(261, 356);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(114, 45);
            this.btnStergere.TabIndex = 17;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnPromovare
            // 
            this.btnPromovare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnPromovare.FlatAppearance.BorderSize = 0;
            this.btnPromovare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromovare.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromovare.ForeColor = System.Drawing.Color.White;
            this.btnPromovare.Location = new System.Drawing.Point(381, 356);
            this.btnPromovare.Name = "btnPromovare";
            this.btnPromovare.Size = new System.Drawing.Size(114, 45);
            this.btnPromovare.TabIndex = 16;
            this.btnPromovare.Text = "Promovează";
            this.btnPromovare.UseVisualStyleBackColor = false;
            this.btnPromovare.Click += new System.EventHandler(this.btnPromovare_Click);
            // 
            // listUtilizatori
            // 
            this.listUtilizatori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUtilizatori.FormattingEnabled = true;
            this.listUtilizatori.ItemHeight = 20;
            this.listUtilizatori.Location = new System.Drawing.Point(143, 96);
            this.listUtilizatori.Name = "listUtilizatori";
            this.listUtilizatori.Size = new System.Drawing.Size(361, 244);
            this.listUtilizatori.TabIndex = 15;
            this.listUtilizatori.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listUtilizatori_Format);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(137, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Utilizatori";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Programville.Properties.Resources.administrare_users;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lbNotFound
            // 
            this.lbNotFound.AutoSize = true;
            this.lbNotFound.Location = new System.Drawing.Point(240, 213);
            this.lbNotFound.Name = "lbNotFound";
            this.lbNotFound.Size = new System.Drawing.Size(156, 19);
            this.lbNotFound.TabIndex = 20;
            this.lbNotFound.Text = "Niciun student adaugat!";
            this.lbNotFound.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.Location = new System.Drawing.Point(143, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 1);
            this.panel1.TabIndex = 58;
            // 
            // ManageUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbNotFound);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnPromovare);
            this.Controls.Add(this.listUtilizatori);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageUtilizatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrează utilizatorii...";
            this.Load += new System.EventHandler(this.ManageUtilizatori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnPromovare;
        private System.Windows.Forms.ListBox listUtilizatori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNotFound;
        private System.Windows.Forms.Panel panel1;
    }
}