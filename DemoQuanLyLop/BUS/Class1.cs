using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class Sach_BUS
    {
        //Load DS tat ca sach
        public static DataTable LoadDanhSachTatCaSach()
        {
            return Sach_DAO.LoadDSTatCaSach();
        }
        // Them 1 sach moi
        public static void ThemMotSachMoi(Sach_DTO sach)
        {
            Sach_DAO.ThemMotSachMoi(sach);
        }
        //Ban Sach
        public static void BanSach(int masach, int soluong)
        {
            Sach_DAO.BanSach(masach, soluong);
        }
        //Xoa 1 sach
        public static void XoaSach (int masach)
        {
            Sach_DAO.XoaSach(masach);
        }
        //Tim theo the loai
        public static DataTable TimTheoTheLoai(int matheloai)
        {
            return Sach_DAO.TimTheoTheLoai(matheloai); 
        }
        //Tim theo tac gia
        public static DataTable TimTheoTacGia(string tentacgia)
        {
            return Sach_DAO.TimTheoTacGia(tentacgia);
        }
        //tim theo ten sach
        public static DataTable TimTheoTenSach(string tensach)
        {
            return Sach_DAO.TimTheoTenSach(tensach);
        }
        //tim theo ma sach
        public static DataTable TimTheoMaSach(int masach)
        {
            return Sach_DAO.TimTheoMaSach(masach);
        }

    }
    public class TheLoai_BUS
    {
        //Load DS the loai
        public static DataTable LoadDanhSachTheLoai()
        {
            return TheLoai_DAO.DanhSachTheLoai();
        }
        //Them 1 the loai
        public static void ThemMotTheLoai(string tentheloai)
        {
            TheLoai_DAO.ThemTheLoai(tentheloai);
        }
        
    }

}
