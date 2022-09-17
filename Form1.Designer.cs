namespace lab02
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Nhan = new System.Windows.Forms.Button();
            this.btn_Cong = new System.Windows.Forms.Button();
            this.btn_Tru = new System.Windows.Forms.Button();
            this.btn_Chia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoThuNhat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoThuHai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Máy tính đơn giản";
            // 
            // btn_Nhan
            // 
            this.btn_Nhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Nhan.BackColor = System.Drawing.Color.Yellow;
            this.btn_Nhan.Location = new System.Drawing.Point(365, 22);
            this.btn_Nhan.Name = "btn_Nhan";
            this.btn_Nhan.Size = new System.Drawing.Size(75, 23);
            this.btn_Nhan.TabIndex = 11;
            this.btn_Nhan.Text = "Nhân";
            this.btn_Nhan.UseVisualStyleBackColor = false;
            this.btn_Nhan.Click += new System.EventHandler(this.btn_Nhan_Click);
            // 
            // btn_Cong
            // 
            this.btn_Cong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Cong.BackColor = System.Drawing.Color.Yellow;
            this.btn_Cong.Location = new System.Drawing.Point(163, 22);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(75, 23);
            this.btn_Cong.TabIndex = 9;
            this.btn_Cong.Text = "Cộng";
            this.btn_Cong.UseVisualStyleBackColor = false;
            this.btn_Cong.Click += new System.EventHandler(this.btn_Cong_Click);
            // 
            // btn_Tru
            // 
            this.btn_Tru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Tru.BackColor = System.Drawing.Color.Yellow;
            this.btn_Tru.Location = new System.Drawing.Point(266, 22);
            this.btn_Tru.Name = "btn_Tru";
            this.btn_Tru.Size = new System.Drawing.Size(75, 23);
            this.btn_Tru.TabIndex = 10;
            this.btn_Tru.Text = "Trừ";
            this.btn_Tru.UseVisualStyleBackColor = false;
            this.btn_Tru.Click += new System.EventHandler(this.btn_Tru_Click);
            // 
            // btn_Chia
            // 
            this.btn_Chia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Chia.BackColor = System.Drawing.Color.Yellow;
            this.btn_Chia.Location = new System.Drawing.Point(468, 22);
            this.btn_Chia.Name = "btn_Chia";
            this.btn_Chia.Size = new System.Drawing.Size(75, 23);
            this.btn_Chia.TabIndex = 12;
            this.btn_Chia.Text = "Chia";
            this.btn_Chia.UseVisualStyleBackColor = false;
            this.btn_Chia.Click += new System.EventHandler(this.btn_Chia_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số thứ nhất ";
            // 
            // txt_SoThuNhat
            // 
            this.txt_SoThuNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_SoThuNhat.Location = new System.Drawing.Point(215, 81);
            this.txt_SoThuNhat.Name = "txt_SoThuNhat";
            this.txt_SoThuNhat.Size = new System.Drawing.Size(380, 20);
            this.txt_SoThuNhat.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kết quả ";
            // 
            // txt_SoThuHai
            // 
            this.txt_SoThuHai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_SoThuHai.Location = new System.Drawing.Point(215, 107);
            this.txt_SoThuHai.Name = "txt_SoThuHai";
            this.txt_SoThuHai.Size = new System.Drawing.Size(380, 20);
            this.txt_SoThuHai.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số thứ hai";
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_KetQua.HideSelection = false;
            this.txt_KetQua.Location = new System.Drawing.Point(215, 133);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(380, 20);
            this.txt_KetQua.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_SoThuNhat);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_SoThuHai);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_KetQua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 179);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Nhan);
            this.panel1.Controls.Add(this.btn_Cong);
            this.panel1.Controls.Add(this.btn_Tru);
            this.panel1.Controls.Add(this.btn_Chia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 57);
            this.panel1.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 50);
            this.panel3.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 236);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Nhan;
        private System.Windows.Forms.Button btn_Cong;
        private System.Windows.Forms.Button btn_Tru;
        private System.Windows.Forms.Button btn_Chia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoThuNhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SoThuHai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KetQua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}

