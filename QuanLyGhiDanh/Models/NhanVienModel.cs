using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Models
{
    public class NhanVienModel
    {
        public string maNhanVien { get; set; }
        public string ho { get; set; }
        public string tenDemVaTen { get; set; }
        public DateTimeOffset ngaysinh { get; set; }
        public bool gioiTinh { get; set; }
        public string email { get; set; }
        public int sdt { get; set; }
        public string diaChi { get; set; }
        public string maSoThue { get; set; }
        public DateTimeOffset ngayHopTac { get; set; }
        public string anhNhanVien { get; set; }       
        public string maChucVu { get; set; }
    }
}
