
namespace Programville
{
    partial class TestPreview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMaterie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitluTest = new System.Windows.Forms.Label();
            this.btnRezolva = new System.Windows.Forms.Button();
            this.picPreviewTest = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDescriere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaterie
            // 
            this.lbMaterie.AutoSize = true;
            this.lbMaterie.Location = new System.Drawing.Point(290, 76);
            this.lbMaterie.Name = "lbMaterie";
            this.lbMaterie.Size = new System.Drawing.Size(93, 19);
            this.lbMaterie.TabIndex = 70;
            this.lbMaterie.Text = "NumeMaterie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Materie:";
            // 
            // lbTitluTest
            // 
            this.lbTitluTest.AutoSize = true;
            this.lbTitluTest.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitluTest.Location = new System.Drawing.Point(218, 26);
            this.lbTitluTest.Name = "lbTitluTest";
            this.lbTitluTest.Size = new System.Drawing.Size(121, 38);
            this.lbTitluTest.TabIndex = 68;
            this.lbTitluTest.Text = "TitluTest";
            // 
            // btnRezolva
            // 
            this.btnRezolva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnRezolva.FlatAppearance.BorderSize = 0;
            this.btnRezolva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezolva.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezolva.ForeColor = System.Drawing.Color.White;
            this.btnRezolva.Image = global::Programville.Properties.Resources.icons8_right_48;
            this.btnRezolva.Location = new System.Drawing.Point(536, 45);
            this.btnRezolva.Name = "btnRezolva";
            this.btnRezolva.Size = new System.Drawing.Size(80, 78);
            this.btnRezolva.TabIndex = 71;
            this.btnRezolva.UseVisualStyleBackColor = false;
            this.btnRezolva.Click += new System.EventHandler(this.btnRezolva_Click);
            // 
            // picPreviewTest
            // 
            this.picPreviewTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreviewTest.Location = new System.Drawing.Point(28, 26);
            this.picPreviewTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPreviewTest.Name = "picPreviewTest";
            this.picPreviewTest.Size = new System.Drawing.Size(175, 118);
            this.picPreviewTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreviewTest.TabIndex = 67;
            this.picPreviewTest.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Descriere:";
            // 
            // lbDescriere
            // 
            this.lbDescriere.AutoSize = true;
            this.lbDescriere.Location = new System.Drawing.Point(221, 115);
            this.lbDescriere.Name = "lbDescriere";
            this.lbDescriere.Size = new System.Drawing.Size(75, 19);
            this.lbDescriere.TabIndex = 73;
            this.lbDescriere.Text = "o descriere";
            // 
            // TestPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbDescriere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezolva);
            this.Controls.Add(this.lbMaterie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitluTest);
            this.Controls.Add(this.picPreviewTest);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestPreview";
            this.Size = new System.Drawing.Size(642, 170);
            this.Load += new System.EventHandler(this.TestPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRezolva;
        private System.Windows.Forms.Label lbMaterie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitluTest;
        private System.Windows.Forms.PictureBox picPreviewTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDescriere;
    }
}
