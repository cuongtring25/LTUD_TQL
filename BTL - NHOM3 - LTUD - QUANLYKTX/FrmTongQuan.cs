using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyktx
{
    public partial class FrmTongQuan : Form
    {
        private int childFormNumber = 0;

        public FrmTongQuan()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FrmTongQuan_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýSinhVIênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuPhong1_Click(object sender, EventArgs e)
        {
            FrmPhong frm1 = new FrmPhong();
            frm1.Show();
        }

        private void mnuPhong2_Click(object sender, EventArgs e)
        {
            FrmDichVu frm2 = new FrmDichVu();
            frm2.Show();
        }

        private void mnuPhong3_Click(object sender, EventArgs e)
        {
            FrmThueTraPhong frm3 = new FrmThueTraPhong();
            frm3.Show();
        }

        private void mnuSinhvien_Click(object sender, EventArgs e)
        {
            FrmSinhVien frm4 = new FrmSinhVien();
            frm4.Show();
        }

        private void mnuDkyDichvu_Click(object sender, EventArgs e)
        {
            FrmDangKyDichVu frm5 = new FrmDangKyDichVu();
            frm5.Show();
        }

        private void mnuQlyHoadon_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm6 = new FrmHoaDon();
            frm6.Show();
        }

        private void mnuQlyKhieunai_Click(object sender, EventArgs e)
        {
            FrmKhieuNai frm7 = new FrmKhieuNai();
            frm7.Show();
        }
    }
}
