
namespace Programville
{
    partial class EditorIntrebari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorIntrebari));
            this.txtCerinta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNextAll = new System.Windows.Forms.Button();
            this.btnPrevAll = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.panelVariante = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadImagine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbIntrebari = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picImagineCerinta = new System.Windows.Forms.PictureBox();
            this.btnFinal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagineCerinta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCerinta
            // 
            this.txtCerinta.BackColor = System.Drawing.SystemColors.Control;
            this.txtCerinta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCerinta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerinta.Location = new System.Drawing.Point(227, 112);
            this.txtCerinta.Multiline = true;
            this.txtCerinta.Name = "txtCerinta";
            this.txtCerinta.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCerinta.Size = new System.Drawing.Size(616, 179);
            this.txtCerinta.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(221, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 34);
            this.label2.TabIndex = 35;
            this.label2.Text = "Întrebare";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnNextAll);
            this.panel1.Controls.Add(this.btnPrevAll);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAddAnswer);
            this.panel1.Controls.Add(this.panelVariante);
            this.panel1.Location = new System.Drawing.Point(227, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 349);
            this.panel1.TabIndex = 49;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Ivory;
            this.btnDelete.Image = global::Programville.Properties.Resources.icons8_trash_32;
            this.btnDelete.Location = new System.Drawing.Point(379, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 48);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Șterge un răspuns";
            // 
            // btnNextAll
            // 
            this.btnNextAll.BackColor = System.Drawing.Color.Transparent;
            this.btnNextAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextAll.Font = new System.Drawing.Font("Lato Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAll.Location = new System.Drawing.Point(183, 290);
            this.btnNextAll.Name = "btnNextAll";
            this.btnNextAll.Size = new System.Drawing.Size(50, 47);
            this.btnNextAll.TabIndex = 57;
            this.btnNextAll.Text = "|>";
            this.btnNextAll.UseVisualStyleBackColor = false;
            this.btnNextAll.Click += new System.EventHandler(this.btnNextAll_Click);
            // 
            // btnPrevAll
            // 
            this.btnPrevAll.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevAll.Font = new System.Drawing.Font("Lato Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevAll.Location = new System.Drawing.Point(15, 290);
            this.btnPrevAll.Name = "btnPrevAll";
            this.btnPrevAll.Size = new System.Drawing.Size(50, 47);
            this.btnPrevAll.TabIndex = 56;
            this.btnPrevAll.Text = "|<";
            this.btnPrevAll.UseVisualStyleBackColor = false;
            this.btnPrevAll.Click += new System.EventHandler(this.btnPrevAll_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Lato Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(71, 290);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 47);
            this.btnPrev.TabIndex = 55;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Lato Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(127, 290);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 47);
            this.btnNext.TabIndex = 54;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Adaugă un răspuns";
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAnswer.FlatAppearance.BorderSize = 0;
            this.btnAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnswer.ForeColor = System.Drawing.Color.Ivory;
            this.btnAddAnswer.Image = global::Programville.Properties.Resources.icons8_enter_mac_key_32;
            this.btnAddAnswer.Location = new System.Drawing.Point(571, 289);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(48, 48);
            this.btnAddAnswer.TabIndex = 41;
            this.btnAddAnswer.UseVisualStyleBackColor = false;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // panelVariante
            // 
            this.panelVariante.AutoScroll = true;
            this.panelVariante.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVariante.Location = new System.Drawing.Point(0, 0);
            this.panelVariante.Name = "panelVariante";
            this.panelVariante.Size = new System.Drawing.Size(622, 278);
            this.panelVariante.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnLoadImagine);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSalvare);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(856, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 278);
            this.panel2.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Încărcare";
            // 
            // btnLoadImagine
            // 
            this.btnLoadImagine.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadImagine.FlatAppearance.BorderSize = 0;
            this.btnLoadImagine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImagine.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImagine.ForeColor = System.Drawing.Color.White;
            this.btnLoadImagine.Image = global::Programville.Properties.Resources.icons8_eye_481;
            this.btnLoadImagine.Location = new System.Drawing.Point(24, 100);
            this.btnLoadImagine.Name = "btnLoadImagine";
            this.btnLoadImagine.Size = new System.Drawing.Size(48, 48);
            this.btnLoadImagine.TabIndex = 51;
            this.btnLoadImagine.UseVisualStyleBackColor = false;
            this.btnLoadImagine.Click += new System.EventHandler(this.btnLoadImagine_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Salvare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nou";
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvare.FlatAppearance.BorderSize = 0;
            this.btnSalvare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvare.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.ForeColor = System.Drawing.Color.White;
            this.btnSalvare.Image = global::Programville.Properties.Resources.icons8_save_32;
            this.btnSalvare.Location = new System.Drawing.Point(23, 185);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(48, 48);
            this.btnSalvare.TabIndex = 47;
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::Programville.Properties.Resources.icons8_add_new_32;
            this.btnNew.Location = new System.Drawing.Point(23, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(48, 48);
            this.btnNew.TabIndex = 48;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel3.Location = new System.Drawing.Point(227, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 1);
            this.panel3.TabIndex = 52;
            // 
            // lbIntrebari
            // 
            this.lbIntrebari.AutoSize = true;
            this.lbIntrebari.Location = new System.Drawing.Point(224, 74);
            this.lbIntrebari.Name = "lbIntrebari";
            this.lbIntrebari.Size = new System.Drawing.Size(121, 18);
            this.lbIntrebari.TabIndex = 54;
            this.lbIntrebari.Text = "Întrebarea X din Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(877, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "Publică";
            // 
            // picImagineCerinta
            // 
            this.picImagineCerinta.Location = new System.Drawing.Point(849, 112);
            this.picImagineCerinta.Name = "picImagineCerinta";
            this.picImagineCerinta.Size = new System.Drawing.Size(208, 179);
            this.picImagineCerinta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagineCerinta.TabIndex = 56;
            this.picImagineCerinta.TabStop = false;
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.Transparent;
            this.btnFinal.FlatAppearance.BorderSize = 0;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.ForeColor = System.Drawing.Color.White;
            this.btnFinal.Image = global::Programville.Properties.Resources.icons8_pdf_32;
            this.btnFinal.Location = new System.Drawing.Point(879, 24);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(48, 48);
            this.btnFinal.TabIndex = 44;
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Programville.Properties.Resources.question_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 689);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // EditorIntrebari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 689);
            this.Controls.Add(this.picImagineCerinta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbIntrebari);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.txtCerinta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lato Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditorIntrebari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editează intrebările testului";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorIntrebari_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagineCerinta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCerinta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelVariante;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbIntrebari;
        private System.Windows.Forms.Button btnNextAll;
        private System.Windows.Forms.Button btnPrevAll;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadImagine;
        private System.Windows.Forms.PictureBox picImagineCerinta;
    }
}