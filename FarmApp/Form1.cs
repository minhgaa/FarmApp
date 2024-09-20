using System;
using System.Windows.Forms;

namespace FarmApp
{
    public partial class Form1 : Form
    {
        private Bo bo = new Bo();
        private Cuu cuu = new Cuu();
        private De de = new De();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            // Nhập số lượng gia súc
            bo.SoLuong = int.Parse(txtBo.Text);
            cuu.SoLuong = int.Parse(txtCuu.Text);
            de.SoLuong = int.Parse(txtDe.Text);

            // Hiển thị tiếng kêu
            listBoxTiengKeu.Items.Clear();
            for (int i = 0; i < bo.SoLuong; i++)
                listBoxTiengKeu.Items.Add(bo.TiengKeu());
            for (int i = 0; i < cuu.SoLuong; i++)
                listBoxTiengKeu.Items.Add(cuu.TiengKeu());
            for (int i = 0; i < de.SoLuong; i++)
                listBoxTiengKeu.Items.Add(de.TiengKeu());

            // Tính tổng số sữa
            int tongSua = 0;
            for (int i = 0; i < bo.SoLuong; i++)
                tongSua += bo.ChoSua();
            for (int i = 0; i < cuu.SoLuong; i++)
                tongSua += cuu.ChoSua();
            for (int i = 0; i < de.SoLuong; i++)
                tongSua += de.ChoSua();
            lblTongSua.Text = $"Tổng sữa: {tongSua} lít";

            // Tính số gia súc sau khi sinh
            int tongGiaSuc = bo.SoLuong + cuu.SoLuong + de.SoLuong;
            for (int i = 0; i < bo.SoLuong; i++)
                tongGiaSuc += bo.SinhCon();
            for (int i = 0; i < cuu.SoLuong; i++)
                tongGiaSuc += cuu.SinhCon();
            for (int i = 0; i < de.SoLuong; i++)
                tongGiaSuc += de.SinhCon();
            lblTongGiaSuc.Text = $"Tổng gia súc sau khi sinh: {tongGiaSuc}";
        }

        private void lblTongGiaSuc_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
