
namespace Programville
{
    partial class FrmRezolvaTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRezolvaTest));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelVariante = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbIntrebari = new System.Windows.Forms.Label();
            this.picImagineCerinta = new System.Windows.Forms.PictureBox();
            this.txtCerinta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagineCerinta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Programville.Properties.Resources.question_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 716);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel3.Location = new System.Drawing.Point(218, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 1);
            this.panel3.TabIndex = 54;
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.lbTest.Location = new System.Drawing.Point(212, 32);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(126, 34);
            this.lbTest.TabIndex = 53;
            this.lbTest.Text = "Titlu test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cerință";
            // 
            // panelVariante
            // 
            this.panelVariante.AutoScroll = true;
            this.panelVariante.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelVariante.Location = new System.Drawing.Point(218, 345);
            this.panelVariante.Name = "panelVariante";
            this.panelVariante.Size = new System.Drawing.Size(846, 278);
            this.panelVariante.TabIndex = 58;
            this.panelVariante.WrapContents = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::Programville.Properties.Resources.icons8_right_48;
            this.btnNext.Location = new System.Drawing.Point(275, 629);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 42);
            this.btnNext.TabIndex = 60;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = global::Programville.Properties.Resources.icons8_left_48;
            this.btnPrev.Location = new System.Drawing.Point(218, 629);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(51, 42);
            this.btnPrev.TabIndex = 59;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(840, 629);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(194, 42);
            this.btnSend.TabIndex = 61;
            this.btnSend.Text = "Trimite răspunsul";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbIntrebari
            // 
            this.lbIntrebari.AutoSize = true;
            this.lbIntrebari.Font = new System.Drawing.Font("Lato Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntrebari.Location = new System.Drawing.Point(217, 66);
            this.lbIntrebari.Name = "lbIntrebari";
            this.lbIntrebari.Size = new System.Drawing.Size(121, 18);
            this.lbIntrebari.TabIndex = 62;
            this.lbIntrebari.Text = "Întrebarea X din Y";
            // 
            // picImagineCerinta
            // 
            this.picImagineCerinta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagineCerinta.Location = new System.Drawing.Point(840, 137);
            this.picImagineCerinta.Name = "picImagineCerinta";
            this.picImagineCerinta.Size = new System.Drawing.Size(224, 179);
            this.picImagineCerinta.TabIndex = 64;
            this.picImagineCerinta.TabStop = false;
            // 
            // txtCerinta
            // 
            this.txtCerinta.BackColor = System.Drawing.SystemColors.Control;
            this.txtCerinta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCerinta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerinta.Location = new System.Drawing.Point(218, 137);
            this.txtCerinta.Multiline = true;
            this.txtCerinta.Name = "txtCerinta";
            this.txtCerinta.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCerinta.Size = new System.Drawing.Size(616, 179);
            this.txtCerinta.TabIndex = 63;
            // 
            // FrmRezolvaTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 716);
            this.Controls.Add(this.picImagineCerinta);
            this.Controls.Add(this.txtCerinta);
            this.Controls.Add(this.lbIntrebari);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panelVariante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRezolvaTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezolva test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRezolvaTest_FormClosing);
            this.Load += new System.EventHandler(this.FrmRezolvaTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagineCerinta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel panelVariante;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbIntrebari;
        private System.Windows.Forms.PictureBox picImagineCerinta;
        private System.Windows.Forms.TextBox txtCerinta;
    }
}