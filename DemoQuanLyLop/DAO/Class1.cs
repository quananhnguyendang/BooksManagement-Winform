using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class sqlConncectionData
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-I7ORRBVV;Initial Catalog=QLNHASACH;Integrated Security=True");
            return cnn;
        }
    }
    public class Sach_DAO
    {
        //load danh sach tat ca sach
        public static DataTable LoadDSTatCaSach()
        {
            SqlConnection cnn = sqlConncectionData.HamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_TatCaSach", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public static void ThemMotSachMoi(Sach_DTO sach)
        {
            SqlConnection cnn = sqlConncectionData.HamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_ThemSach", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@DonGia", SqlDbType.Int);
            cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int);
            cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@MaTheLoai", SqlDbType.Int);
            //gan gia tri
            cmd.Parameters["@TenSach"].Value = sach.TenSach;
            cmd.Parameters["@DonGia"].Value = sach.DonGia;
            cmd.Parameters["@SoLuongTon"].Value = sach.SoLuongTon;
            cmd.Parameters["@TacGia"].Value = sach.TacGia;
            cmd.Parameters["@MaTheLoai"].Value = sach.MaTheLoai;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        // Ban n cuon sach
        public static void BanSach (int masach, int soluong)
        {
            SqlConnection cnn = sqlConncectionData.HamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_BanSach", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach",SqlDbType.Int);
            cmd.Parameters.Add("@n", SqlDbType.Int);
            cmd.Parameters["@MaSach"].Value = masach;
            cmd.Parameters["@n"].Value = soluong;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        // xoa 1 sach
        public static void XoaSach(int masach)
        {
            SqlConnection cnn = sqlConncectionData.HamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_XoaSach", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.Int);
            cmd.Parameters["@MaSach"].Value = masach;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable TimTheoTheLoai(int matheloai)
        {
            SqlConnection cnn = sqlConncectionData.HamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_TimTheoTheLoai", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTheLoai", SqlDbType.Int);
            cmd.Parameters["@MaTheLoai"].Value = matheloai;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        //Tim theo tac gia
        public static DataTable TimTheoTacGia(string tentacgia)
        {
            SqlConnection cnn = sqlConncectionData.HamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_TimTheoTacGia", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 50);
            cmd.Parameters["@TacGia"].Value = tentacgia;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        //tim theo ten sach
        public static DataTable TimTheoTenSach(string tensach)
        {

            SqlConnection cnn = sqlConncectionData.HamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_TimTheoTenSach", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 50);
            cmd.Parameters["@TenSach"].Value = tensach;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;

        }
        //Tim theo ma sach
        public static DataTable TimTheoMaSach(int masach)
        {
            SqlConnection cnn = sqlConncectionData.HamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_TimTheoMaSach", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.Int);
            cmd.Parameters["@MaSach"].Value = masach;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }

    }
    public class TheLoai_DAO
    {
        public static DataTable DanhSachTheLoai()
        {
            SqlConnection cnn = sqlConncectionData.HamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_DanhSachTheLoai", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public static void ThemTheLoai(string tentheloai)
        {
            SqlConnection cnn = sqlConncectionData.HamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_ThemTheLoai", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenTheLoai", SqlDbType.NVarChar, 50);
            cmd.Parameters["@TenTheLoai"].Value = tentheloai;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
