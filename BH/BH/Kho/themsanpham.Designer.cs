namespace BH.Kho
{
    partial class themsanpham
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sanpham1 = new BH.Kho.sanpham();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(507, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 600);
            this.dataGridView1.TabIndex = 1;
            // 
            // sanpham1
            // 
            this.sanpham1.BackColor = System.Drawing.Color.Silver;
            this.sanpham1.Location = new System.Drawing.Point(1, -1);
            this.sanpham1.Name = "sanpham1";
            this.sanpham1.Size = new System.Drawing.Size(500, 600);
            this.sanpham1.TabIndex = 0;
            // 
            // themsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 604);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sanpham1);
            this.MaximumSize = new System.Drawing.Size(1142, 643);
            this.MinimumSize = new System.Drawing.Size(1142, 643);
            this.Name = "themsanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM SẢN PHẨM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sanpham sanpham1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}