using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.UI
{
    public partial class uc_HDBan : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_HDBan()
        {
            InitializeComponent();
            LoadMaHDVaoComboBox();
            LoadDanhSachHoaDonVaoGridControl();
        }

        private void LoadDanhSachHoaDonVaoGridControl()
        {
            throw new NotImplementedException();
        }

        private void LoadMaHDVaoComboBox()
        {
            throw new NotImplementedException();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            //Xử lý bằng cách chọn mã hóa đơn và bấm in ra hóa đơn có mã đang được chọn
        }

        private void btnPreviewHoaDon_Click(object sender, EventArgs e)
        {
            //Xử lý bằng cách hiển thị report hóa đơn khi bấm preview hóa đơn đang được chọn ở combobox
        }

        private void btnExportHD_Click(object sender, EventArgs e)
        {
            //Xử lý bằng cách xuất ra danh sách excel, tên file excel sẽ được đặt là "Danh Sách Hóa Đơn - Ngày Xuất"
        }
    }
}
