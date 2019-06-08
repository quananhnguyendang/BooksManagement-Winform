using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach_DTO
    {
        private int maSach;
        private string tenSach;
        private int donGia;
        private int soLuongTon;
        private string tacGia;
        private int maTheLoai;
        public int MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public int MaTheLoai { get => maTheLoai; set => maTheLoai = value; }

        public Sach_DTO(string tensach, int dongia, int soluongton, string tacgia, int matheloai)
        {
            TenSach = tensach;
            DonGia = dongia;
            SoLuongTon = soluongton;
            TacGia = tacgia;
            MaTheLoai = matheloai;


        }
    }
    public class TheLoai_DTO
    {
        private int maTheLoai;
        private string tenTheLoai;


        public int MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }

        public TheLoai_DTO(string tentheloai)
        {
           TenTheLoai=tentheloai;
        }
    }
}
