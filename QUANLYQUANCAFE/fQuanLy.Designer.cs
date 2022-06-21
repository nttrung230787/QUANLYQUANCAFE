
namespace QUANLYQUANCAFE
{
    partial class fQuanLy
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
            this.tcQuanLy = new System.Windows.Forms.TabControl();
            this.tpDoanhThu = new System.Windows.Forms.TabPage();
            this.tpThucAn = new System.Windows.Forms.TabPage();
            this.tpDanhMuc = new System.Windows.Forms.TabPage();
            this.tcQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLy
            // 
            this.tcQuanLy.Controls.Add(this.tpDoanhThu);
            this.tcQuanLy.Controls.Add(this.tpThucAn);
            this.tcQuanLy.Controls.Add(this.tpDanhMuc);
            this.tcQuanLy.Location = new System.Drawing.Point(13, 13);
            this.tcQuanLy.Name = "tcQuanLy";
            this.tcQuanLy.SelectedIndex = 0;
            this.tcQuanLy.Size = new System.Drawing.Size(785, 425);
            this.tcQuanLy.TabIndex = 0;
            // 
            // tpDoanhThu
            // 
            this.tpDoanhThu.Location = new System.Drawing.Point(4, 22);
            this.tpDoanhThu.Name = "tpDoanhThu";
            this.tpDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoanhThu.Size = new System.Drawing.Size(777, 399);
            this.tpDoanhThu.TabIndex = 0;
            this.tpDoanhThu.Text = "Doanh thu";
            this.tpDoanhThu.UseVisualStyleBackColor = true;
            // 
            // tpThucAn
            // 
            this.tpThucAn.Location = new System.Drawing.Point(4, 22);
            this.tpThucAn.Name = "tpThucAn";
            this.tpThucAn.Padding = new System.Windows.Forms.Padding(3);
            this.tpThucAn.Size = new System.Drawing.Size(777, 399);
            this.tpThucAn.TabIndex = 1;
            this.tpThucAn.Text = "Thức ăn";
            this.tpThucAn.UseVisualStyleBackColor = true;
            // 
            // tpDanhMuc
            // 
            this.tpDanhMuc.Location = new System.Drawing.Point(4, 22);
            this.tpDanhMuc.Name = "tpDanhMuc";
            this.tpDanhMuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhMuc.Size = new System.Drawing.Size(777, 399);
            this.tpDanhMuc.TabIndex = 2;
            this.tpDanhMuc.Text = "Danh mục";
            this.tpDanhMuc.UseVisualStyleBackColor = true;
            // 
            // fQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcQuanLy);
            this.Name = "fQuanLy";
            this.Text = "fQuanLy";
            this.tcQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLy;
        private System.Windows.Forms.TabPage tpDoanhThu;
        private System.Windows.Forms.TabPage tpThucAn;
        private System.Windows.Forms.TabPage tpDanhMuc;
    }
}