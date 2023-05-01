
namespace Programville
{
    partial class TestPreviewAdmin
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
            this.lbTitluTest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaterie = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picPreviewTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitluTest
            // 
            this.lbTitluTest.AutoSize = true;
            this.lbTitluTest.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitluTest.ForeColor = System.Drawing.Color.White;
            this.lbTitluTest.Location = new System.Drawing.Point(214, 19);
            this.lbTitluTest.Name = "lbTitluTest";
            this.lbTitluTest.Size = new System.Drawing.Size(121, 38);
            this.lbTitluTest.TabIndex = 1;
            this.lbTitluTest.Text = "TitluTest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Materie:";
            // 
            // lbMaterie
            // 
            this.lbMaterie.AutoSize = true;
            this.lbMaterie.ForeColor = System.Drawing.Color.White;
            this.lbMaterie.Location = new System.Drawing.Point(286, 69);
            this.lbMaterie.Name = "lbMaterie";
            this.lbMaterie.Size = new System.Drawing.Size(93, 19);
            this.lbMaterie.TabIndex = 3;
            this.lbMaterie.Text = "NumeMaterie";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::Programville.Properties.Resources.edit_48;
            this.btnEdit.Location = new System.Drawing.Point(691, 38);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 78);
            this.btnEdit.TabIndex = 67;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Programville.Properties.Resources.delete_48;
            this.btnDelete.Location = new System.Drawing.Point(605, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 78);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // picPreviewTest
            // 
            this.picPreviewTest.Image = global::Programville.Properties.Resources.default_test_question_picture;
            this.picPreviewTest.Location = new System.Drawing.Point(19, 12);
            this.picPreviewTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPreviewTest.Name = "picPreviewTest";
            this.picPreviewTest.Size = new System.Drawing.Size(175, 118);
            this.picPreviewTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreviewTest.TabIndex = 0;
            this.picPreviewTest.TabStop = false;
            // 
            // TestPreviewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbMaterie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitluTest);
            this.Controls.Add(this.picPreviewTest);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestPreviewAdmin";
            this.Size = new System.Drawing.Size(782, 141);
            this.Load += new System.EventHandler(this.TestPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreviewTest;
        private System.Windows.Forms.Label lbTitluTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaterie;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}
