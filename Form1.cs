using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoThuNhat.Text == "" || txt_SoThuHai.Text == "")
                {
                    MessageBox.Show("Chưa nhập số", "Thông báo");
                }
                else
                {
                    float soThuNhat = float.Parse(txt_SoThuNhat.Text);
                    float soThuHai = float.Parse(txt_SoThuHai.Text);
                    float ketQua = soThuNhat + soThuHai;
                    txt_KetQua.Text = ketQua.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoThuNhat.Text == "" || txt_SoThuHai.Text == "")
                {
                    MessageBox.Show("Chưa nhập số", "Thông báo");
                }
                else
                {
                    float soThuNhat = float.Parse(txt_SoThuNhat.Text);
                    float soThuHai = float.Parse(txt_SoThuHai.Text);
                    float ketQua = soThuNhat - soThuHai;
                    txt_KetQua.Text = ketQua.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoThuNhat.Text == "" || txt_SoThuHai.Text == "")
                {
                    MessageBox.Show("Chưa nhập số", "Thông báo");
                }
                else
                {
                    float soThuNhat = float.Parse(txt_SoThuNhat.Text);
                    float soThuHai = float.Parse(txt_SoThuHai.Text);
                    float ketQua = soThuNhat * soThuHai;
                    txt_KetQua.Text = ketQua.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Chia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoThuNhat.Text == "" || txt_SoThuHai.Text == "")
                {
                    MessageBox.Show("Chưa nhập số", "Thông báo");
                }
                else
                {
                    float soThuNhat = float.Parse(txt_SoThuNhat.Text);
                    float soThuHai = float.Parse(txt_SoThuHai.Text);
                    float ketQua = soThuNhat / soThuHai;
                    txt_KetQua.Text = ketQua.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

