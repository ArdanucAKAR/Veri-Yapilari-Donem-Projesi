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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerPanel));
            this.dgwStaff = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelHotel = new System.Windows.Forms.Button();
            this.dgwHotels = new System.Windows.Forms.DataGridView();
            this.btnDelStaff = new System.Windows.Forms.Button();
            this.btnAddPersonel = new System.Windows.Forms.Button();
            this.btnStaffSortDescRate = new System.Windows.Forms.Button();
            this.gbHotels = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbStaff = new System.Windows.Forms.GroupBox();
            this.gbRateSort = new System.Windows.Forms.GroupBox();
            this.btnStaffSortRate = new System.Windows.Forms.Button();
            this.btnBackHotels = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbDepartmentSort = new System.Windows.Forms.GroupBox();
            this.btnStaffSortDepartment = new System.Windows.Forms.Button();
            this.btnStaffSortDescDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHotels)).BeginInit();
            this.gbHotels.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbStaff.SuspendLayout();
            this.gbRateSort.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDepartmentSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwStaff
            // 
            this.dgwStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStaff.Location = new System.Drawing.Point(6, 29);
            this.dgwStaff.Name = "dgwStaff";
            this.dgwStaff.Size = new System.Drawing.Size(663, 264);
            this.dgwStaff.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(651, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Otel Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // btnDelHotel
            // 
            this.btnDelHotel.Location = new System.Drawing.Point(6, 48);
            this.btnDelHotel.Name = "btnDelHotel";
            this.btnDelHotel.Size = new System.Drawing.Size(651, 23);
            this.btnDelHotel.TabIndex = 1;
            this.btnDelHotel.Text = "Otel Sil";
            this.btnDelHotel.UseVisualStyleBackColor = true;
            this.btnDelHotel.Click += new System.EventHandler(this.btnDelHotel_Click);
            // 
            // dgwHotels
            // 
            this.dgwHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHotels.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgwHotels.Location = new System.Drawing.Point(6, 19);
            this.dgwHotels.Name = "dgwHotels";
            this.dgwHotels.Size = new System.Drawing.Size(663, 264);
            this.dgwHotels.TabIndex = 0;
            this.dgwHotels.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgwHotels_CellBeginEdit);
            this.dgwHotels.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHotels_CellDoubleClick);
            this.dgwHotels.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHotels_CellValueChanged);
            // 
            // btnDelStaff
            // 
            this.btnDelStaff.Location = new System.Drawing.Point(6, 46);
            this.btnDelStaff.Name = "btnDelStaff";
            this.btnDelStaff.Size = new System.Drawing.Size(160, 23);
            this.btnDelStaff.TabIndex = 1;
            this.btnDelStaff.Text = "Personel Sil";
            this.btnDelStaff.UseVisualStyleBackColor = true;
            this.btnDelStaff.Click += new System.EventHandler(this.btnDelStaff_Click);
            // 
            // btnAddPersonel
            // 
            this.btnAddPersonel.Location = new System.Drawing.Point(6, 19);
            this.btnAddPersonel.Name = "btnAddPersonel";
            this.btnAddPersonel.Size = new System.Drawing.Size(160, 23);
            this.btnAddPersonel.TabIndex = 1;
            this.btnAddPersonel.Text = "Personel Ekle";
            this.btnAddPersonel.UseVisualStyleBackColor = true;
            this.btnAddPersonel.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnStaffSortDescRate
            // 
            this.btnStaffSortDescRate.Location = new System.Drawing.Point(6, 19);
            this.btnStaffSortDescRate.Name = "btnStaffSortDescRate";
            this.btnStaffSortDescRate.Size = new System.Drawing.Size(160, 23);
            this.btnStaffSortDescRate.TabIndex = 1;
            this.btnStaffSortDescRate.Text = "Azalan";
            this.btnStaffSortDescRate.UseVisualStyleBackColor = true;
            this.btnStaffSortDescRate.Click += new System.EventHandler(this.btnStaffSortDescRate_Click);
            // 
            // gbHotels
            // 
            this.gbHotels.Controls.Add(this.groupBox2);
            this.gbHotels.Controls.Add(this.dgwHotels);
            this.gbHotels.Location = new System.Drawing.Point(693, 12);
            this.gbHotels.Name = "gbHotels";
            this.gbHotels.Size = new System.Drawing.Size(675, 385);
            this.gbHotels.TabIndex = 2;
            this.gbHotels.TabStop = false;
            this.gbHotels.Text = "Oteller";
            this.gbHotels.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnDelHotel);
            this.groupBox2.Location = new System.Drawing.Point(6, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 80);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otel İşlemleri";
            // 
            // gbStaff
            // 
            this.gbStaff.Controls.Add(this.gbDepartmentSort);
            this.gbStaff.Controls.Add(this.gbRateSort);
            this.gbStaff.Controls.Add(this.btnBackHotels);
            this.gbStaff.Controls.Add(this.groupBox4);
            this.gbStaff.Controls.Add(this.dgwStaff);
            this.gbStaff.Location = new System.Drawing.Point(12, 12);
            this.gbStaff.Name = "gbStaff";
            this.gbStaff.Size = new System.Drawing.Size(675, 385);
            this.gbStaff.TabIndex = 3;
            this.gbStaff.TabStop = false;
            this.gbStaff.Text = "Personeller";
            this.gbStaff.Visible = false;
            // 
            // gbRateSort
            // 
            this.gbRateSort.Controls.Add(this.btnStaffSortRate);
            this.gbRateSort.Controls.Add(this.btnStaffSortDescRate);
            this.gbRateSort.Location = new System.Drawing.Point(497, 300);
            this.gbRateSort.Name = "gbRateSort";
            this.gbRateSort.Size = new System.Drawing.Size(172, 78);
            this.gbRateSort.TabIndex = 5;
            this.gbRateSort.TabStop = false;
            this.gbRateSort.Text = "Puana Göre Sırala";
            // 
            // btnStaffSortRate
            // 
            this.btnStaffSortRate.Location = new System.Drawing.Point(6, 46);
            this.btnStaffSortRate.Name = "btnStaffSortRate";
            this.btnStaffSortRate.Size = new System.Drawing.Size(160, 23);
            this.btnStaffSortRate.TabIndex = 2;
            this.btnStaffSortRate.Text = "Artan";
            this.btnStaffSortRate.UseVisualStyleBackColor = true;
            this.btnStaffSortRate.Click += new System.EventHandler(this.btnStaffSortRate_Click);
            // 
            // btnBackHotels
            // 
            this.btnBackHotels.Location = new System.Drawing.Point(482, 0);
            this.btnBackHotels.Name = "btnBackHotels";
            this.btnBackHotels.Size = new System.Drawing.Size(187, 23);
            this.btnBackHotels.TabIndex = 4;
            this.btnBackHotels.Text = "Otellere Geri Dön";
            this.btnBackHotels.UseVisualStyleBackColor = true;
            this.btnBackHotels.Click += new System.EventHandler(this.btnBackHotels_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelStaff);
            this.groupBox4.Controls.Add(this.btnAddPersonel);
            this.groupBox4.Location = new System.Drawing.Point(7, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 78);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Personel İşlemleri";
            // 
            // gbDepartmentSort
            // 
            this.gbDepartmentSort.Controls.Add(this.btnStaffSortDepartment);
            this.gbDepartmentSort.Controls.Add(this.btnStaffSortDescDepartment);
            this.gbDepartmentSort.Location = new System.Drawing.Point(319, 301);
            this.gbDepartmentSort.Name = "gbDepartmentSort";
            this.gbDepartmentSort.Size = new System.Drawing.Size(172, 78);
            this.gbDepartmentSort.TabIndex = 5;
            this.gbDepartmentSort.TabStop = false;
            this.gbDepartmentSort.Text = "Departmana Göre Sırala";
            // 
            // btnStaffSortDepartment
            // 
            this.btnStaffSortDepartment.Location = new System.Drawing.Point(6, 46);
            this.btnStaffSortDepartment.Name = "btnStaffSortDepartment";
            this.btnStaffSortDepartment.Size = new System.Drawing.Size(160, 23);
            this.btnStaffSortDepartment.TabIndex = 2;
            this.btnStaffSortDepartment.Text = "Artan";
            this.btnStaffSortDepartment.UseVisualStyleBackColor = true;
            this.btnStaffSortDepartment.Click += new System.EventHandler(this.btnStaffSortDepartment_Click);
            // 
            // btnStaffSortDescDepartment
            // 
            this.btnStaffSortDescDepartment.Location = new System.Drawing.Point(6, 19);
            this.btnStaffSortDescDepartment.Name = "btnStaffSortDescDepartment";
            this.btnStaffSortDescDepartment.Size = new System.Drawing.Size(160, 23);
            this.btnStaffSortDescDepartment.TabIndex = 1;
            this.btnStaffSortDescDepartment.Text = "Azalan";
            this.btnStaffSortDescDepartment.UseVisualStyleBackColor = true;
            this.btnStaffSortDescDepartment.Click += new System.EventHandler(this.btnStaffSortDescDepartment_Click);
            // 
            // ManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 408);
            this.Controls.Add(this.gbStaff);
            this.Controls.Add(this.gbHotels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerPanel_FormClosing);
            this.Load += new System.EventHandler(this.ManagerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHotels)).EndInit();
            this.gbHotels.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbStaff.ResumeLayout(false);
            this.gbRateSort.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbDepartmentSort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStaff;
        private System.Windows.Forms.DataGridView dgwHotels;
        private System.Windows.Forms.Button btnDelStaff;
        private System.Windows.Forms.Button btnDelHotel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddPersonel;
        private System.Windows.Forms.Button btnStaffSortDescRate;
        private System.Windows.Forms.GroupBox gbHotels;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbStaff;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBackHotels;
        private System.Windows.Forms.GroupBox gbRateSort;
        private System.Windows.Forms.Button btnStaffSortRate;
        private System.Windows.Forms.GroupBox gbDepartmentSort;
        private System.Windows.Forms.Button btnStaffSortDepartment;
        private System.Windows.Forms.Button btnStaffSortDescDepartment;
    }
}