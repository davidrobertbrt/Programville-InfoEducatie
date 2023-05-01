
namespace Programville
{
    partial class FrmTeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeste));
            this.label2 = new System.Windows.Forms.Label();
            this.flowTeste = new System.Windows.Forms.FlowLayoutPanel();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 34);
            this.label2.TabIndex = 56;
            this.label2.Text = "Teste";
            // 
            // flowTeste
            // 
            this.flowTeste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowTeste.AutoScroll = true;
            this.flowTeste.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTeste.Location = new System.Drawing.Point(13, 197);
            this.flowTeste.Name = "flowTeste";
            this.flowTeste.Size = new System.Drawing.Size(834, 461);
            this.flowTeste.TabIndex = 64;
            this.flowTeste.WrapContents = false;
            // 
            // comboFilter
            // 
            this.comboFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(32, 98);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(460, 33);
            this.comboFilter.TabIndex = 65;
            this.comboFilter.SelectedIndexChanged += new System.EventHandler(this.comboFilter_SelectedIndexChanged);
            this.comboFilter.SelectedValueChanged += new System.EventHandler(this.comboFilter_SelectedValueChanged);
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
            this.btnDeleteFilter.Location = new System.Drawing.Point(220, 137);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(181, 54);
            this.btnDeleteFilter.TabIndex = 68;
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
            this.btnFilter.Location = new System.Drawing.Point(33, 137);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(181, 54);
            this.btnFilter.TabIndex = 67;
            this.btnFilter.Text = "Filtrează";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.btnAddTest.FlatAppearance.BorderSize = 0;
            this.btnAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAddTest.ForeColor = System.Drawing.Color.White;
            this.btnAddTest.Image = global::Programville.Properties.Resources.new_test_48;
            this.btnAddTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTest.Location = new System.Drawing.Point(646, 12);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(201, 67);
            this.btnAddTest.TabIndex = 22;
            this.btnAddTest.Text = "Adaugă test";
            this.btnAddTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(871, 675);
            this.Controls.Add(this.btnDeleteFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.comboFilter);
            this.Controls.Add(this.flowTeste);
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(798, 543);
            this.Name = "FrmTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste";
            this.Load += new System.EventHandler(this.FrmTeste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.FlowLayoutPanel flowTeste;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDeleteFilter;
    }
}