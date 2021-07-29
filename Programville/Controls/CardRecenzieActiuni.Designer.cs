
namespace Programville
{
    partial class CardRecenzieActiuni
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
            this.lbDateTime = new System.Windows.Forms.Label();
            this.lbScor = new System.Windows.Forms.Label();
            this.lbDescriere = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(313, 3);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(45, 19);
            this.lbDateTime.TabIndex = 9;
            this.lbDateTime.Text = "label1";
            // 
            // lbScor
            // 
            this.lbScor.AutoSize = true;
            this.lbScor.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScor.Location = new System.Drawing.Point(531, 36);
            this.lbScor.Name = "lbScor";
            this.lbScor.Size = new System.Drawing.Size(51, 32);
            this.lbScor.TabIndex = 8;
            this.lbScor.Text = "0/5";
            // 
            // lbDescriere
            // 
            this.lbDescriere.Location = new System.Drawing.Point(97, 24);
            this.lbDescriere.Name = "lbDescriere";
            this.lbDescriere.Size = new System.Drawing.Size(428, 64);
            this.lbDescriere.TabIndex = 7;
            this.lbDescriere.Text = "label1";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.ForeColor = System.Drawing.Color.White;
            this.lbNume.Location = new System.Drawing.Point(97, 3);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(67, 19);
            this.lbNume.TabIndex = 6;
            this.lbNume.Text = "John Doe";
            // 
            // picUser
            // 
            this.picUser.Image = global::Programville.Properties.Resources.default_profile_picture;
            this.picUser.Location = new System.Drawing.Point(14, 15);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(64, 64);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 5;
            this.picUser.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Programville.Properties.Resources.delete_48;
            this.btnDelete.Location = new System.Drawing.Point(613, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 78);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CardRecenzieActiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.lbScor);
            this.Controls.Add(this.lbDescriere);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.picUser);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CardRecenzieActiuni";
            this.Size = new System.Drawing.Size(709, 105);
            this.Load += new System.EventHandler(this.RecenzieTestCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbScor;
        private System.Windows.Forms.Label lbDescriere;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnDelete;
    }
}
