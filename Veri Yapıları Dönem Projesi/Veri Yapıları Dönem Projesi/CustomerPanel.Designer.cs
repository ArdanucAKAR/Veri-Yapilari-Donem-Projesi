namespace Veri_Yapıları_Dönem_Projesi
{
    partial class CustomerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPanel));
            this.dgwHotels = new System.Windows.Forms.DataGridView();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnRateHotel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnListHotelOrderByStar = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnTreeInformation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHotels)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwHotels
            // 
            this.dgwHotels.AllowUserToAddRows = false;
            this.dgwHotels.AllowUserToDeleteRows = false;
            this.dgwHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHotels.Location = new System.Drawing.Point(12, 12);
            this.dgwHotels.Name = "dgwHotels";
            this.dgwHotels.ReadOnly = true;
            this.dgwHotels.Size = new System.Drawing.Size(694, 248);
            this.dgwHotels.TabIndex = 0;
            this.dgwHotels.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHotels_CellDoubleClick);
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(6, 19);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(134, 23);
            this.btnAddComment.TabIndex = 1;
            this.btnAddComment.Text = "Yorum Ekle";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnRateHotel
            // 
            this.btnRateHotel.Location = new System.Drawing.Point(6, 48);
            this.btnRateHotel.Name = "btnRateHotel";
            this.btnRateHotel.Size = new System.Drawing.Size(134, 23);
            this.btnRateHotel.TabIndex = 2;
            this.btnRateHotel.Text = "Puan Ver";
            this.btnRateHotel.UseVisualStyleBackColor = true;
            this.btnRateHotel.Click += new System.EventHandler(this.btnRateHotel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "İl-İlçeye Göre Listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnsortByCityTown_Click);
            // 
            // btnListHotelOrderByStar
            // 
            this.btnListHotelOrderByStar.Location = new System.Drawing.Point(6, 48);
            this.btnListHotelOrderByStar.Name = "btnListHotelOrderByStar";
            this.btnListHotelOrderByStar.Size = new System.Drawing.Size(134, 23);
            this.btnListHotelOrderByStar.TabIndex = 4;
            this.btnListHotelOrderByStar.Text = "Yıldıza Göre Listele";
            this.btnListHotelOrderByStar.UseVisualStyleBackColor = true;
            this.btnListHotelOrderByStar.Click += new System.EventHandler(this.btnListHotelOrderByStar_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.Location = new System.Drawing.Point(146, 19);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(134, 23);
            this.btnPostOrder.TabIndex = 5;
            this.btnPostOrder.Text = "PostOrder";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.Location = new System.Drawing.Point(6, 19);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(134, 23);
            this.btnPreOrder.TabIndex = 6;
            this.btnPreOrder.Text = "PreOrder";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.Location = new System.Drawing.Point(6, 48);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(134, 23);
            this.btnInOrder.TabIndex = 7;
            this.btnInOrder.Text = "İnOrder";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.Location = new System.Drawing.Point(6, 19);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(134, 23);
            this.btnSortByName.TabIndex = 8;
            this.btnSortByName.Text = "İsme Göre Listele";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnTreeInformation
            // 
            this.btnTreeInformation.Location = new System.Drawing.Point(146, 47);
            this.btnTreeInformation.Name = "btnTreeInformation";
            this.btnTreeInformation.Size = new System.Drawing.Size(134, 23);
            this.btnTreeInformation.TabIndex = 9;
            this.btnTreeInformation.Text = "Ağaç Bilgilerini Göster";
            this.btnTreeInformation.UseVisualStyleBackColor = true;
            this.btnTreeInformation.Click += new System.EventHandler(this.btnTreeInformation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSortByName);
            this.groupBox1.Controls.Add(this.btnListHotelOrderByStar);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(560, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listele";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPreOrder);
            this.groupBox2.Controls.Add(this.btnPostOrder);
            this.groupBox2.Controls.Add(this.btnInOrder);
            this.groupBox2.Controls.Add(this.btnTreeInformation);
            this.groupBox2.Location = new System.Drawing.Point(230, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 80);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ağaç İşlemleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddComment);
            this.groupBox3.Controls.Add(this.btnRateHotel);
            this.groupBox3.Location = new System.Drawing.Point(12, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 80);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otel İşlemleri";
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 380);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwHotels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerPanel_FormClosing);
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHotels)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwHotels;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnRateHotel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnListHotelOrderByStar;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnTreeInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}