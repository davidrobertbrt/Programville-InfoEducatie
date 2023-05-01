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
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.btnDeconectare = new System.Windows.Forms.Button();
            this.btnSetari = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnRecenzii = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.flowTeste = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.mainContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.mainContainer.Panel1.Controls.Add(this.btnDeconectare);
            this.mainContainer.Panel1.Controls.Add(this.btnSetari);
            this.mainContainer.Panel1.Controls.Add(this.btnStatistics);
            this.mainContainer.Panel1.Controls.Add(this.btnRecenzii);
            this.mainContainer.Panel1.Controls.Add(this.picLogo);
            this.mainContainer.Panel1.ForeColor = System.Drawing.SystemColors.Control;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.mainContainer.Panel2.Controls.Add(this.btnDeleteFilter);
            this.mainContainer.Panel2.Controls.Add(this.btnFilter);
            this.mainContainer.Panel2.Controls.Add(this.comboFilter);
            this.mainContainer.Panel2.Controls.Add(this.flowTeste);
            this.mainContainer.Panel2.Controls.Add(this.label1);
            this.mainContainer.Size = new System.Drawing.Size(1189, 668);
            this.mainContainer.SplitterDistance = 297;
            this.mainContainer.TabIndex = 2;
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
            this.btnDeconectare.Location = new System.Drawing.Point(0, 350);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(297, 65);
            this.btnDeconectare.TabIndex = 12;
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
            this.btnSetari.Location = new System.Drawing.Point(0, 285);
            this.btnSetari.Name = "btnSetari";
            this.btnSetari.Size = new System.Drawing.Size(297, 65);
            this.btnSetari.TabIndex = 11;
            this.btnSetari.Text = "Setări";
            this.btnSetari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetari.UseVisualStyleBackColor = false;
            this.btnSetari.Click += new System.EventHandler(this.btnSetari_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Image = global::Programville.Properties.Resources.statistica_48;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 220);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(297, 65);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "Statistica";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
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
            this.btnRecenzii.Location = new System.Drawing.Point(0, 155);
            this.btnRecenzii.Name = "btnRecenzii";
            this.btnRecenzii.Size = new System.Drawing.Size(297, 65);
            this.btnRecenzii.TabIndex = 9;
            this.btnRecenzii.Text = "Recenziile mele";
            this.btnRecenzii.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecenzii.UseVisualStyleBackColor = false;
            this.btnRecenzii.Click += new System.EventHandler(this.btnRecenzii_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::Programville.Properties.Resources.app_logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(297, 155);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // btnDeleteFilter
            // 
            this.btnDeleteFilter.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteFilter.FlatAppearance.BorderSize = 0;
            this.btnDeleteFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteFilter.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFilter.Image = global::Programville.Properties.Resources.delete_48;
            this.btnDeleteFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFilter.Location = new System.Drawing.Point(212, 133);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(181, 54);
            this.btnDeleteFilter.TabIndex = 72;
            this.btnDeleteFilter.Text = "Șterge filtru";
            this.btnDeleteFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteFilter.UseVisualStyleBackColor = false;
            this.btnDeleteFilter.Click += new System.EventHandler(this.btnDeleteFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = global::Programville.Properties.Resources.category_481;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(25, 133);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(181, 54);
            this.btnFilter.TabIndex = 71;
            this.btnFilter.Text = "Filtrează";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // comboFilter
            // 
            this.comboFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(25, 94);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(460, 33);
            this.comboFilter.TabIndex = 70;
            // 
            // flowTeste
            // 
            this.flowTeste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowTeste.AutoScroll = true;
            this.flowTeste.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTeste.Location = new System.Drawing.Point(25, 192);
            this.flowTeste.Name = "flowTeste";
            this.flowTeste.Size = new System.Drawing.Size(834, 461);
            this.flowTeste.TabIndex = 69;
            this.flowTeste.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Să trecem la acțiune!";
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
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            this.mainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSetari;
        private System.Windows.Forms.Button btnDeconectare;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.FlowLayoutPanel flowTeste;
        private System.Windows.Forms.Button btnRecenzii;
    }
}