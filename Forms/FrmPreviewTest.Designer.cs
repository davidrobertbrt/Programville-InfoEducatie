
namespace Programville
{
    partial class FrmPreviewTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreviewTest));
            this.lbMaterie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNouRecenzie = new System.Windows.Forms.Button();
            this.flowRecenzii = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDescriere = new System.Windows.Forms.Label();
            this.lbTitlu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picTestPreview = new System.Windows.Forms.PictureBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTestPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaterie
            // 
            this.lbMaterie.AutoSize = true;
            this.lbMaterie.Location = new System.Drawing.Point(119, 279);
            this.lbMaterie.Name = "lbMaterie";
            this.lbMaterie.Size = new System.Drawing.Size(100, 20);
            this.lbMaterie.TabIndex = 78;
            this.lbMaterie.Text = "NumeMaterie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Materie:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.btnNouRecenzie);
            this.panel2.Controls.Add(this.flowRecenzii);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 366);
            this.panel2.TabIndex = 73;
            // 
            // btnNouRecenzie
            // 
            this.btnNouRecenzie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNouRecenzie.FlatAppearance.BorderSize = 0;
            this.btnNouRecenzie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouRecenzie.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouRecenzie.ForeColor = System.Drawing.Color.White;
            this.btnNouRecenzie.Image = global::Programville.Properties.Resources.add_comment_48;
            this.btnNouRecenzie.Location = new System.Drawing.Point(709, 12);
            this.btnNouRecenzie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNouRecenzie.Name = "btnNouRecenzie";
            this.btnNouRecenzie.Size = new System.Drawing.Size(86, 51);
            this.btnNouRecenzie.TabIndex = 79;
            this.btnNouRecenzie.UseVisualStyleBackColor = false;
            this.btnNouRecenzie.Click += new System.EventHandler(this.btnNouRecenzie_Click);
            // 
            // flowRecenzii
            // 
            this.flowRecenzii.AutoScroll = true;
            this.flowRecenzii.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowRecenzii.Location = new System.Drawing.Point(32, 79);
            this.flowRecenzii.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowRecenzii.Name = "flowRecenzii";
            this.flowRecenzii.Size = new System.Drawing.Size(763, 274);
            this.flowRecenzii.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Recenzii";
            // 
            // lbDescriere
            // 
            this.lbDescriere.Location = new System.Drawing.Point(280, 100);
            this.lbDescriere.Name = "lbDescriere";
            this.lbDescriere.Size = new System.Drawing.Size(525, 175);
            this.lbDescriere.TabIndex = 72;
            this.lbDescriere.Text = resources.GetString("lbDescriere.Text");
            this.lbDescriere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitlu
            // 
            this.lbTitlu.AutoSize = true;
            this.lbTitlu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitlu.Location = new System.Drawing.Point(287, 39);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(493, 41);
            this.lbTitlu.TabIndex = 71;
            this.lbTitlu.Text = "Test pentru testarea cunoștințelor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.picTestPreview);
            this.panel1.Location = new System.Drawing.Point(51, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 236);
            this.panel1.TabIndex = 70;
            // 
            // picTestPreview
            // 
            this.picTestPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTestPreview.Image = global::Programville.Properties.Resources.default_test_question_picture;
            this.picTestPreview.Location = new System.Drawing.Point(0, 0);
            this.picTestPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picTestPreview.Name = "picTestPreview";
            this.picTestPreview.Size = new System.Drawing.Size(198, 236);
            this.picTestPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTestPreview.TabIndex = 0;
            this.picTestPreview.TabStop = false;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.btnSolve.FlatAppearance.BorderSize = 0;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSolve.ForeColor = System.Drawing.Color.White;
            this.btnSolve.Image = global::Programville.Properties.Resources.solve_test_48;
            this.btnSolve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolve.Location = new System.Drawing.Point(595, 279);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(200, 84);
            this.btnSolve.TabIndex = 74;
            this.btnSolve.Text = "Rezolvă testul";
            this.btnSolve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // FrmPreviewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(875, 777);
            this.Controls.Add(this.lbMaterie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbDescriere);
            this.Controls.Add(this.lbTitlu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPreviewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPreviewTest";
            this.Load += new System.EventHandler(this.FrmPreviewTest_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTestPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNouRecenzie;
        private System.Windows.Forms.Label lbMaterie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowRecenzii;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDescriere;
        private System.Windows.Forms.Label lbTitlu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picTestPreview;
    }
}