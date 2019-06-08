using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int typeSearch=0;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = Sach_BUS.LoadDanhSachTatCaSach();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = TheLoai_BUS.LoadDanhSachTheLoai();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(typeSearch)
            {
                case 1:
                    {
                        dataGridView4.DataSource = Sach_BUS.TimTheoTheLoai(int.Parse(textBox1.Text));
                        break;
                    }
                case 2:
                    {
                        dataGridView4.DataSource = Sach_BUS.TimTheoTacGia(textBox1.Text);
                        break;
                    }
                case 3:
                    {
                        dataGridView4.DataSource = Sach_BUS.TimTheoTenSach(textBox1.Text);
                        break;
                    }
                case 4:
                    {
                        dataGridView4.DataSource = Sach_BUS.TimTheoMaSach(int.Parse(textBox1.Text));
                        break;
                    }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                typeSearch = 1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                typeSearch = 2;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                typeSearch = 3;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked)
            {
                typeSearch = 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Sach_BUS.LoadDanhSachTatCaSach();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sach_BUS.XoaSach(int.Parse(textBox2.Text));
            dataGridView1.DataSource = Sach_BUS.LoadDanhSachTatCaSach();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Sach_BUS.LoadDanhSachTatCaSach();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tensach = textBox3.Text;
            int dongia = int.Parse(textBox4.Text);
            int soluongton = int.Parse(textBox5.Text);
            string tacgia = textBox6.Text;
            int matheloai = int.Parse(textBox7.Text);
            Sach_DTO sach = new Sach_DTO(tensach, dongia, soluongton, tacgia, matheloai);
            Sach_BUS.ThemMotSachMoi(sach);
            dataGridView2.DataSource = Sach_BUS.LoadDanhSachTatCaSach();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = TheLoai_BUS.LoadDanhSachTheLoai();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TheLoai_BUS.ThemMotTheLoai(textBox8.Text);
            dataGridView3.DataSource = TheLoai_BUS.LoadDanhSachTheLoai();

        }
    }
}
