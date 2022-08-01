using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
           
        }
        XuLy xl = new XuLy();
        public bool checkForm(string name) 
        {
            if (this.MdiChildren.Length>0)
            {
                Form[] frm = this.MdiChildren;
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    if (frm[i].Name==name)
                    {
                        return false;
                    }
                }
            }
            return true;
        
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            string chucvu = xl.getChucVu(getData.manv);
            if (chucvu=="Quản Lý")
            {
                nhânViênToolStripMenuItem.Enabled = true;
                tàiKhoảnToolStripMenuItem.Enabled = true;
            }
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang nv = new KhachHang();
            if (checkForm(nv.Name))
            {
                nv.MdiParent = this;
                nv.Show();
            }
            
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVu nv = new DichVu();
            if (checkForm(nv.Name))
            {
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong nv = new Phong();
            if (checkForm(nv.Name))
            {
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon nv = new HoaDon();
            if (checkForm(nv.Name))
            {
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void hóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonDV nv = new HoaDonDV();
            if (checkForm(nv.Name))
            {
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan nv = new TaoTaiKhoan();
            if (checkForm(nv.Name))
            {
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            if (checkForm(nv.Name))
            {
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuePhong nv = new ThuePhong();
            if (checkForm(nv.Name))
            {
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraPhong nv = new TraPhong();
            if (checkForm(nv.Name))
            {
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
