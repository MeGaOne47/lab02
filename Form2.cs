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
    public partial class frm_QuanLySinhVien : Form
    {
        public frm_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void frm_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            cmb_Khoa.SelectedIndex = 0; 
        }

        private int GetSelectedRow(string MaSV)
        {
            for(int i = 0; i < dgv_QuanLySinhVien.Rows.Count; i++)
            {
                if (dgv_QuanLySinhVien.Rows[i].Cells[0].Value.ToString() == MaSV)
                {
                    return i;

                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgv_QuanLySinhVien.Rows[selectedRow].Cells[0].Value = txt_MaSV.Text;
            dgv_QuanLySinhVien.Rows[selectedRow].Cells[1].Value = txt_HoTen.Text;
            dgv_QuanLySinhVien.Rows[selectedRow].Cells[2].Value = rdb_Nu.Checked ? "Nu" : "Nam";
            dgv_QuanLySinhVien.Rows[selectedRow].Cells[3].Value = float.Parse(txt_TrungBinh.Text).ToString();
            dgv_QuanLySinhVien.Rows[selectedRow].Cells[3].Value = cmb_Khoa.Text;

        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaSV.Text == "" || txt_HoTen.Text == "" || txt_TrungBinh.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy dủ thông tin sinh viên!");

                    int selecttedRow = GetSelectedRow(txt_MaSV.Text);
                    if (selecttedRow == -1)
                    {
                        selecttedRow = dgv_QuanLySinhVien.Rows.Add();
                        InsertUpdate(selecttedRow);
                        MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        InsertUpdate(selecttedRow);
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selecttedRow = GetSelectedRow(txt_MaSV.Text);
                if (selecttedRow == -1 ) 
                {
                    throw new Exception("Không tìm thấy thông tin sinh viên!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?","YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        dgv_QuanLySinhVien.Rows.RemoveAt(selecttedRow);
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                    }    
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        } 
    }
}
