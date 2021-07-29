namespace Programville
{
    partial class ManageMaterii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMaterii));
            this.listMaterii = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterie = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listMaterii
            // 
            this.listMaterii.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMaterii.FormattingEnabled = true;
            this.listMaterii.ItemHeight = 28;
            this.listMaterii.Location = new System.Drawing.Point(18, 87);
            this.listMaterii.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listMaterii.Name = "listMaterii";
            this.listMaterii.Size = new System.Drawing.Size(342, 200);
            this.listMaterii.TabIndex = 2;
            this.listMaterii.SelectedIndexChanged += new System.EventHandler(this.listMaterii_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Materii";
            // 
            // txtMaterie
            // 
            this.txtMaterie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterie.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterie.Location = new System.Drawing.Point(18, 330);
            this.txtMaterie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaterie.Name = "txtMaterie";
            this.txtMaterie.Size = new System.Drawing.Size(342, 24);
            this.txtMaterie.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(230, 382);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Salvează";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeselect.FlatAppearance.BorderSize = 0;
            this.btnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselect.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeselect.ForeColor = System.Drawing.Color.White;
            this.btnDeselect.Location = new System.Drawing.Point(22, 382);
            this.btnDeselect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(130, 50);
            this.btnDeselect.TabIndex = 12;
            this.btnDeselect.Text = "Deselecteaza";
            this.btnDeselect.UseVisualStyleBackColor = false;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nume materie";
            // 
            // ManageMaterii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(376, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMaterie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listMaterii);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageMaterii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materii";
            this.Load += new System.EventHandler(this.ManageMaterii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listMaterii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaterie;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeselect;
        private System.Windows.Forms.Label label1;
    }
}