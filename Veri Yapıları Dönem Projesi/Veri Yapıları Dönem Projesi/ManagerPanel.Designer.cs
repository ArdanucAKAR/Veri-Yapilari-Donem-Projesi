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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnListStaff = new System.Windows.Forms.Button();
            this.btnCrud = new System.Windows.Forms.Button();
            this.dgwHotels = new System.Windows.Forms.DataGridView();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.btnDelStaff = new System.Windows.Forms.Button();
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
            this.dgwStaff.Location = new System.Drawing.Point(6, 38);
            this.dgwStaff.Name = "dgwStaff";
            this.dgwStaff.Size = new System.Drawing.Size(753, 378);
            this.dgwStaff.TabIndex = 0;
            // 
            // tbcManager
            // 
            this.tbcManager.Controls.Add(this.tabHotels);
            this.tbcManager.Controls.Add(this.tabStaff);
            this.tbcManager.Location = new System.Drawing.Point(-2, -2);
            this.tbcManager.Name = "tbcManager";
            this.tbcManager.SelectedIndex = 0;
            this.tbcManager.Size = new System.Drawing.Size(1000, 456);
            this.tbcManager.TabIndex = 1;
            this.tbcManager.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcManager_Selecting);
            // 
            // tabHotels
            // 
            this.tabHotels.Controls.Add(this.btnAdd);
            this.tabHotels.Controls.Add(this.btnListStaff);
            this.tabHotels.Controls.Add(this.btnCrud);
            this.tabHotels.Controls.Add(this.dgwHotels);
            this.tabHotels.Location = new System.Drawing.Point(4, 22);
            this.tabHotels.Name = "tabHotels";
            this.tabHotels.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotels.Size = new System.Drawing.Size(992, 430);
            this.tabHotels.TabIndex = 0;
            this.tabHotels.Text = "Oteller";
            this.tabHotels.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(684, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(299, 79);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Otel Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnListStaff
            // 
            this.btnListStaff.Location = new System.Drawing.Point(684, 187);
            this.btnListStaff.Name = "btnListStaff";
            this.btnListStaff.Size = new System.Drawing.Size(299, 90);
            this.btnListStaff.TabIndex = 2;
            this.btnListStaff.Text = "Personelleri Listele";
            this.btnListStaff.UseVisualStyleBackColor = true;
            this.btnListStaff.Click += new System.EventHandler(this.btnListStaff_Click);
            // 
            // btnCrud
            // 
            this.btnCrud.Location = new System.Drawing.Point(684, 91);
            this.btnCrud.Name = "btnCrud";
            this.btnCrud.Size = new System.Drawing.Size(299, 90);
            this.btnCrud.TabIndex = 1;
            this.btnCrud.Text = "Oteli sil";
            this.btnCrud.UseVisualStyleBackColor = true;
            this.btnCrud.Click += new System.EventHandler(this.btnCrud_Click);
            // 
            // dgwHotels
            // 
            this.dgwHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHotels.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgwHotels.Location = new System.Drawing.Point(6, 6);
            this.dgwHotels.Name = "dgwHotels";
            this.dgwHotels.Size = new System.Drawing.Size(660, 410);
            this.dgwHotels.TabIndex = 0;
            this.dgwHotels.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgwHotels_CellBeginEdit);
            this.dgwHotels.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHotels_CellValueChanged);
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.lblHotelName);
            this.tabStaff.Controls.Add(this.btnDelStaff);
            this.tabStaff.Controls.Add(this.dgwStaff);
            this.tabStaff.Location = new System.Drawing.Point(4, 22);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(992, 430);
            this.tabStaff.TabIndex = 1;
            this.tabStaff.Text = "Personeller";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHotelName.Location = new System.Drawing.Point(6, 3);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(0, 25);
            this.lblHotelName.TabIndex = 2;
            // 
            // btnDelStaff
            // 
            this.btnDelStaff.Location = new System.Drawing.Point(775, 38);
            this.btnDelStaff.Name = "btnDelStaff";
            this.btnDelStaff.Size = new System.Drawing.Size(208, 100);
            this.btnDelStaff.TabIndex = 1;
            this.btnDelStaff.Text = "Personel Sil";
            this.btnDelStaff.UseVisualStyleBackColor = true;
            this.btnDelStaff.Click += new System.EventHandler(this.btnDelStaff_Click);
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
            this.tabStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStaff;
        private System.Windows.Forms.TabControl tbcManager;
        private System.Windows.Forms.TabPage tabHotels;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.DataGridView dgwHotels;
        private System.Windows.Forms.Button btnDelStaff;
        private System.Windows.Forms.Button btnCrud;
        private System.Windows.Forms.Button btnListStaff;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Button btnAdd;
    }
}