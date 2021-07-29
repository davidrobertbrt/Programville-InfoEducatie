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
            this.SuspendLayout();
            // 
            // btnStergere
            // 
            this.btnStergere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStergere.BackColor = System.Drawing.Color.Firebrick;
            this.btnStergere.FlatAppearance.BorderSize = 0;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.Location = new System.Drawing.Point(19, 389);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(116, 57);
            this.btnStergere.TabIndex = 17;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnPromovare
            // 
            this.btnPromovare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPromovare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnPromovare.FlatAppearance.BorderSize = 0;
            this.btnPromovare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromovare.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromovare.ForeColor = System.Drawing.Color.White;
            this.btnPromovare.Location = new System.Drawing.Point(141, 389);
            this.btnPromovare.Name = "btnPromovare";
            this.btnPromovare.Size = new System.Drawing.Size(116, 57);
            this.btnPromovare.TabIndex = 16;
            this.btnPromovare.Text = "Promovează";
            this.btnPromovare.UseVisualStyleBackColor = false;
            this.btnPromovare.Click += new System.EventHandler(this.btnPromovare_Click);
            // 
            // listUtilizatori
            // 
            this.listUtilizatori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listUtilizatori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listUtilizatori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUtilizatori.ForeColor = System.Drawing.Color.White;
            this.listUtilizatori.FormattingEnabled = true;
            this.listUtilizatori.ItemHeight = 28;
            this.listUtilizatori.Location = new System.Drawing.Point(14, 76);
            this.listUtilizatori.Name = "listUtilizatori";
            this.listUtilizatori.Size = new System.Drawing.Size(384, 284);
            this.listUtilizatori.TabIndex = 15;
            this.listUtilizatori.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listUtilizatori_Format);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Studenti";
            // 
            // ManageUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(416, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnPromovare);
            this.Controls.Add(this.listUtilizatori);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUtilizatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrează utilizatorii...";
            this.Load += new System.EventHandler(this.ManageUtilizatori_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnPromovare;
        private System.Windows.Forms.ListBox listUtilizatori;
        private System.Windows.Forms.Label label2;
    }
}