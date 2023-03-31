namespace _3_PL
{
    partial class FrmBanHang
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuanLyCuaHang = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plChuaTatCaForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(-1, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Trang chủ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(-1, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bán hàng";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyCuaHang
            // 
            this.btnQuanLyCuaHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuanLyCuaHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyCuaHang.Location = new System.Drawing.Point(-2, 257);
            this.btnQuanLyCuaHang.Name = "btnQuanLyCuaHang";
            this.btnQuanLyCuaHang.Size = new System.Drawing.Size(235, 65);
            this.btnQuanLyCuaHang.TabIndex = 3;
            this.btnQuanLyCuaHang.Text = "Quản lý cửa hàng";
            this.btnQuanLyCuaHang.UseVisualStyleBackColor = false;
            this.btnQuanLyCuaHang.Click += new System.EventHandler(this.btnQuanLyCuaHang_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(-2, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 65);
            this.button4.TabIndex = 2;
            this.button4.Text = "Dịch vụ sửa chữa";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(-1, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 581);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-2, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1348, 70);
            this.panel2.TabIndex = 5;
            // 
            // plChuaTatCaForm
            // 
            this.plChuaTatCaForm.Location = new System.Drawing.Point(239, 73);
            this.plChuaTatCaForm.Name = "plChuaTatCaForm";
            this.plChuaTatCaForm.Size = new System.Drawing.Size(1095, 576);
            this.plChuaTatCaForm.TabIndex = 6;
            this.plChuaTatCaForm.Paint += new System.Windows.Forms.PaintEventHandler(this.plChuaTatCaForm_Paint);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 650);
            this.Controls.Add(this.plChuaTatCaForm);
            this.Controls.Add(this.btnQuanLyCuaHang);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnQuanLyCuaHang;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private Panel plChuaTatCaForm;
    }
}