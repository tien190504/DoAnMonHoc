using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO_AN_LT_WIN.Entities;


namespace DO_AN_LT_WIN.Admin.Chung
{
    public partial class ucMonHoc : UserControl
    {
        DBContext db = new DBContext();
        public ucMonHoc()
        {
            InitializeComponent();
        }

        private void ucMonHoc_Load(object sender, EventArgs e)
        {
            List<Mon_Hoc> monHocList = db.Mon_Hoc.ToList();
            dgvMonHoc.Rows.Clear();
            fillDGVMonHoc(monHocList);
            setGridViewStyle(dgvMonHoc);
        }
        private void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgview.ReadOnly = true;
        }

        private void fillDGVMonHoc(List<Mon_Hoc> monHocList)
        {
            dgvMonHoc.Rows.Clear();
            foreach (Mon_Hoc item in monHocList)
            {
                int newRow = dgvMonHoc.Rows.Add();

                dgvMonHoc.Rows[newRow].Cells[0].Value = dgvMonHoc.Rows.Count;
                dgvMonHoc.Rows[newRow].Cells[1].Value = item.Ma_Mon_Hoc.Trim();
                dgvMonHoc.Rows[newRow].Cells[2].Value = item.Ten_Mon_Hoc;
            }
        }
        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvMonHoc.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaMon.Text = dgvMonHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtTenMon.Text = dgvMonHoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
        }
        
        private int GetSelectedRow(string maMon)
        {

            for (int i = 0; i < dgvMonHoc.Rows.Count; i++)
            {
                if (dgvMonHoc.Rows[i].Cells[1].Value != null &&
                    dgvMonHoc.Rows[i].Cells[1].Value.ToString() == maMon)
                {
                    return i;
                }
            }
            return -1;
        }
        private void insertUpdata(int selectRow)
        {
            dgvMonHoc.Rows[selectRow].Cells[0].Value = dgvMonHoc.Rows.Count;
            dgvMonHoc.Rows[selectRow].Cells[1].Value = txtMaMon.Text.Trim();
            dgvMonHoc.Rows[selectRow].Cells[2].Value = txtTenMon.Text.Trim();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMon.Text.Trim() == "" || txtTenMon.Text.Trim() == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");

                int selectRow = GetSelectedRow(txtMaMon.Text.Trim());
                if (selectRow == -1)
                {
                    selectRow = dgvMonHoc.Rows.Add();
                    insertUpdata(selectRow);
                    Mon_Hoc newMon = new Mon_Hoc
                    {
                        Ma_Mon_Hoc = txtMaMon.Text.Trim(),
                        Ten_Mon_Hoc = txtTenMon.Text.Trim(),
                    };

                    db.Mon_Hoc.Add(newMon);
                    db.SaveChanges();
                    MessageBox.Show("Thêm môn học mới thành công!", "Thông báo");
                    var ucChuongInstance = (ucChuong)this.Parent.Controls.Find("ucChuong", true).FirstOrDefault();
                    ucChuongInstance?.ReloadComboBoxMonHoc();
                }
                else
                {
                    MessageBox.Show("Đã có môn học này! Vui lòng dùng chức năng sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectRow = GetSelectedRow(txtMaMon.Text.Trim());
            if (selectRow == -1)
            {
                MessageBox.Show("Không tìm thấy môn học để sửa", "THÔNG BÁO");
                return;
            }
            insertUpdata(selectRow);
            var monHoc = db.Mon_Hoc.FirstOrDefault(s => s.Ma_Mon_Hoc == txtMaMon.Text.Trim());
            if (monHoc != null)
            {
                monHoc.Ten_Mon_Hoc = txtTenMon.Text.Trim();
                db.SaveChanges(); // Lưu
            }
            MessageBox.Show("Cập nhật thông tin môn thành công!", "Thông báo");
        }
        private void toolRefresh_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //Program.ReloadMainForm();
        }
    }
}