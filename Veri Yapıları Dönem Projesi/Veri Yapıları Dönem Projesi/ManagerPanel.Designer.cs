namespace Veri_Yapıları_Dönem_Projesi
{
    partial class ManagerPanel
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
            this.dgwStaff = new System.Windows.Forms.DataGridView();
            this.tbcManager = new System.Windows.Forms.TabControl();
            this.tabHotels = new System.Windows.Forms.TabPage();
            this.dgwHotels = new System.Windows.Forms.DataGridView();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCrud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStaff)).BeginInit();
            this.tbcManager.SuspendLayout();
            this.tabHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHotels)).BeginInit();
            this.tabStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwStaff
            // 
            this.dgwStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStaff.Location = new System.Drawing.Point(6, 6);
            this.dgwStaff.Name = "dgwStaff";
            this.dgwStaff.Size = new System.Drawing.Size(970, 171);
            this.dgwStaff.TabIndex = 0;
            // 
            // tbcManager
            // 
            this.tbcManager.Controls.Add(this.tabHotels);
            this.tbcManager.Controls.Add(this.tabStaff);
            this.tbcManager.Location = new System.Drawing.Point(-2, 0);
            this.tbcManager.Name = "tbcManager";
            this.tbcManager.SelectedIndex = 0;
            this.tbcManager.Size = new System.Drawing.Size(1000, 454);
            this.tbcManager.TabIndex = 1;
            // 
            // tabHotels
            // 
            this.tabHotels.Controls.Add(this.btnCrud);
            this.tabHotels.Controls.Add(this.dgwHotels);
            this.tabHotels.Location = new System.Drawing.Point(4, 22);
            this.tabHotels.Name = "tabHotels";
            this.tabHotels.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotels.Size = new System.Drawing.Size(992, 428);
            this.tabHotels.TabIndex = 0;
            this.tabHotels.Text = "Oteller";
            this.tabHotels.UseVisualStyleBackColor = true;
            // 
            // dgwHotels
            // 
            this.dgwHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHotels.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgwHotels.Location = new System.Drawing.Point(6, 6);
            this.dgwHotels.Name = "dgwHotels";
            this.dgwHotels.Size = new System.Drawing.Size(704, 209);
            this.dgwHotels.TabIndex = 0;
            this.dgwHotels.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgwHotels_CellBeginEdit);
            this.dgwHotels.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHotels_CellValueChanged);
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.button1);
            this.tabStaff.Controls.Add(this.dgwStaff);
            this.tabStaff.Location = new System.Drawing.Point(4, 22);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(992, 428);
            this.tabStaff.TabIndex = 1;
            this.tabStaff.Text = "Personeller";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCrud
            // 
            this.btnCrud.Location = new System.Drawing.Point(732, 6);
            this.btnCrud.Name = "btnCrud";
            this.btnCrud.Size = new System.Drawing.Size(238, 209);
            this.btnCrud.TabIndex = 1;
            this.btnCrud.Text = "Ekle-Sil-Güncelle";
            this.btnCrud.UseVisualStyleBackColor = true;
            this.btnCrud.Click += new System.EventHandler(this.btnCrud_Click);
            // 
            // ManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.tbcManager);
            this.Name = "ManagerPanel";
            this.Text = "ManagerPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerPanel_FormClosing);
            this.Load += new System.EventHandler(this.ManagerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStaff)).EndInit();
            this.tbcManager.ResumeLayout(false);
            this.tabHotels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHotels)).EndInit();
            this.tabStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStaff;
        private System.Windows.Forms.TabControl tbcManager;
        private System.Windows.Forms.TabPage tabHotels;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.DataGridView dgwHotels;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrud;
    }
}