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
            this.dgwHotels = new System.Windows.Forms.DataGridView();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnRateHotel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHotels)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwHotels
            // 
            this.dgwHotels.AllowUserToAddRows = false;
            this.dgwHotels.AllowUserToDeleteRows = false;
            this.dgwHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHotels.Location = new System.Drawing.Point(12, 23);
            this.dgwHotels.Name = "dgwHotels";
            this.dgwHotels.ReadOnly = true;
            this.dgwHotels.Size = new System.Drawing.Size(776, 248);
            this.dgwHotels.TabIndex = 0;
            this.dgwHotels.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHotels_CellDoubleClick);
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(187, 320);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(75, 23);
            this.btnAddComment.TabIndex = 1;
            this.btnAddComment.Text = "Yorum Ekle";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnRateHotel
            // 
            this.btnRateHotel.Location = new System.Drawing.Point(297, 320);
            this.btnRateHotel.Name = "btnRateHotel";
            this.btnRateHotel.Size = new System.Drawing.Size(75, 23);
            this.btnRateHotel.TabIndex = 2;
            this.btnRateHotel.Text = "Puan Ver";
            this.btnRateHotel.UseVisualStyleBackColor = true;
            this.btnRateHotel.Click += new System.EventHandler(this.btnRateHotel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "İl-İlçeye Göre Sırala";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnsortByCityTown_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(407, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRateHotel);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.dgwHotels);
            this.Name = "CustomerPanel";
            this.Text = "CustomerPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerPanel_FormClosing);
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHotels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwHotels;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnRateHotel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}